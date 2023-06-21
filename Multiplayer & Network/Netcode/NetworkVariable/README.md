## NetworkVariable

NetworkVariable is the way **data can be synchronized between peers** in abstracted ways.

At a high level, a `NetworkVariable` is a way to **synchronize a property ("variable") between a server and client(s) without having to use custom messages or RPCs**. 

Since `NetworkVariable` is **a wrapper ("container") of the stored value of type `T`**, you must use the `NetworkVariable.Value` property to access the actual value being synchronized

-   Newly joining clients (that is, "Late Joining Clients")
    -   When the associated `NetworkObject` of a `NetworkBehaviour`, with `NetworkVariable` properties, is spawned, any `NetworkVariable`'s current state (`Value`) is automatically synchronized on the client side.
-   Connected clients
    -   When a `NetworkVariable` value changes, any connected clients that subscribed to `NetworkVariable.OnValueChanged` event (prior to the value being changed) will be notified of the change.
        -   Two parameters are passed to any `NetworkVariable.OnValueChanged` subscribed callback method:
            -   First parameter (**Previous**): The previous value before the value was changed
            -   Second parameter (**Current**): The newly changed `NetworkVariable.Value`.

A `NetworkVariable`:

-   Property _must_ be defined within a `NetworkBehaviour` derived class attached to a `GameObject`
    -   The `GameObject` or a parent `GameObject` **must** also have a `NetworkObject` component attached to it.
-   A `NetworkVariable`'s value can only be set when:
    -   Initializing the property (either when it's declared or within the Awake method)
    -   While the associated `NetworkObject` is spawned (upon being spawned or any time while it's still spawned).


| Dynamically Spawned | In-Scene Placed |
| --- | --- |
| Awake | Awake |
| OnNetworkSpawn | Start |
| Start | OnNetworkSpawn |


#### In-Scene (Placed) NetworkObjects
 An in-scene placed **NetworkObject** means a GameObject with a **NetworkObject component** was added to a scene from within the editor. 

https://docs-multiplayer.unity3d.com/netcode/current/basics/scenemanagement/inscene-placed-networkobjects/


#### OnValueChanged Example

While the first example highlighted the differences between synchronizing a NetworkVariable with newly joining clients and notifying connected clients when a NetworkVariable changes, it didn't provide any concrete example usage. The next example shows a simple server authoritative NetworkVariable being used to track the state of a door (that is, open or closed):


```cs
public class Door : NetworkBehaviour
{
    public NetworkVariable<bool> State = new NetworkVariable<bool>();

    public override void OnNetworkSpawn()
    {
        State.OnValueChanged += OnStateChanged;
    }

    public override void OnNetworkDespawn()
    {
        State.OnValueChanged -= OnStateChanged;
    }

    public void OnStateChanged(bool previous, bool current)
    {
        // note: `State.Value` will be equal to `current` here
        if (State.Value)
        {
            // door is open:
            //  - rotate door transform
            //  - play animations, sound etc.
        }
        else
        {
            // door is closed:
            //  - rotate door transform
            //  - play animations, sound etc.
        }
    }

    [ServerRpc(RequireOwnership = false)]
    public void ToggleServerRpc()
    {
        // this will cause a replication over the network
        // and ultimately invoke `OnValueChanged` on receivers
        State.Value = !State.Value;
    }
}
```

In the above example, we show how you can keep a server authoritative `NetworkVariable` by using a non-ownership based server RPC (that is, `RequireOwnership = false` means non-owners can invoke it) so any client can notify the server that it's performing an "action" on the door. For this example, each time the door is used by a client the `Door.ToggleServerRpc` is invoked and the server-side toggles the state of the door. Upon the `Door.State.Value` changing, all connected clients are synchronized to the (new) current `Value` and the `OnStateChanged` method is invoked locally on each client.


### Permission
You can adjust who can write to or read from the **`NetworkVariable`**. Use `NetworkVariable` permissions.


The **NetworkVariable constructor** can take up to **3 parameters**:

```cs
public NetworkVariable(T value = default, 
NetworkVariableReadPermission readPerm = NetworkVariableReadPermission.Everyone, 
NetworkVariableWritePermission writePerm = NetworkVariableWritePermission.Server);
```

The default permissions are:
- **Server**: Has read and write permissions
- **Clients**: Have read only permissions.

#### Read permission
There are two options for reading a `NetworkVariable.Value`:

-   _Everyone(_default_):_ this means the owner and non-owners of the `NetworkObject` can read the value.
    -   This is useful for "global states" that everyone should be aware of.
    -   We provided an example of maintaining a door's open or closed state using the everyone permission.
        -   You might also use this for player scores, health, or any other state that "everyone" should know about.
-   _Owner:_ This means only the owner of the `NetworkObject` and the server can read the value.
    -   This is useful if your `NetworkVariable` represents something specific to the client's player that only the server and client should know about
        -   This might be a player's inventory or gun's ammo count (etc.)

#### Write Permissions
There are two options for writing a `NetworkVariable.Value`:

-   _Server(_default_):_ the server is the only one that can write the value.
    -   This is useful for server side specific states that all clients should should be aware of but can't change.
        -   Some examples would be an NPC's status (health, alive, dead, etc) or some global world environment state (that is, is it night or day time?).
-   _Owner:_ This means only the owner of the `NetworkObject` can write to the value.
    -   This is useful if your `NetworkVariable` represents something specific to the client's player that only the owning client should be able to set
        -   This might be a player's skin or other cosmetics


https://github.com/Unity-Technologies/com.unity.netcode.gameobjects/blob/release/1.0.0/com.unity.netcode.gameobjects/Runtime/NetworkVariable/NetworkVariablePermission.cs

#### Permissions Example


```cs
public class PlayerState : NetworkBehaviour
{
    private const float k_DefaultHealth = 100.0f;
    /// <summary>
    /// Default Permissions: Everyone can read, server can only write
    /// Player health is typically something determined (updated/written to) on the server
    ///  side, but a value everyone should be synchronized with (that is, read permissions).
    /// </summary>
    public NetworkVariable<float> Health = new NetworkVariable<float>(k_DefaultHealth);

    /// <summary>
    /// Owner Read Permissions: Owner or server can read
    /// Owner Write Permissions: Only the Owner can write
    /// A player's ammo count is something that you might want, for convenience sake, the
    /// client-side to update locally. This might be because you are trying to reduce 
    /// bandwidth consumption for the server and all non-owners/ players or you might be 
    /// trying to incorporate a more client-side "hack resistant" design where non-owners 
    /// are never synchronized with this value.
    /// </summary>
    public NetworkVariable<int> AmmoCount = new NetworkVariable<int>(default, 
        NetworkVariableReadPermission.Owner, NetworkVariableWritePermission.Owner);

    /// <summary>
    /// Owner Write & Everyone Read Permissions:
    /// A player's model's skin selection index. You might have the option to allow players
    /// to select different skin materials as a way to further encourage a player's personal
    /// association with their player character.  It would make sense to make the permissions 
    /// setting of the NetworkVariable such that the client can change the value, but everyone 
    /// will be notified when it changes to visually reflect the new skin selection.
    /// </summary>
    public NetworkVariable<int> SkinSelectionIndex = new NetworkVariable<int>(default,
        NetworkVariableReadPermission.Everyone, NetworkVariableWritePermission.Owner);

    /// <summary>
    /// Owner Read & Server Write Permissions:
    /// You might incorporate some form of reconnection logic that stores a player's state on 
    /// the server side and can be used by the client to reconnect a player if disconnected
    /// unexpectedly.  In order for the client to let the server know it's the "same client" 
    /// you might have implemented a keyed array (that is, Hashtable, Dictionary, etc, ) to track
    /// each connected client. The key value for each connected client would only be written to
    /// the each client's PlayerState.ReconnectionKey. Under this scenario, you only want the 
    /// server to have write permissions and the owner (client) to be synchronized with this 
    /// value (via owner only read permissions).
    /// </summary>
    public NetworkVariable<ulong> ReconnectionKey = new NetworkVariable<ulong>(default,
    NetworkVariableReadPermission.Owner, NetworkVariableWritePermission.Server);
}

```

> **Note**: You might be wondering about the above door example and why we chose to use a **server RPC** for clients to notify the server that the door's open/closed state has changed. Under that scenario, the owner of the door will most likely be owned by the server just like **non-player characters** will almost always be **owned by the server**. Under a server owned scenario, using an RPC to handle updating a **NetworkVariable** is the proper choice above permissions for most cases.


### Supported Types

`NetworkVariable` provides support for the following types:

-   C# unmanaged [primitive types](https://docs-multiplayer.unity3d.com/netcode/current/advanced-topics/serialization/cprimitives/) (which are serialized by direct memcpy into/out of the buffer): `bool`, `byte`, `sbyte`, `char`, `decimal`, `double`, `float`, `int`, `uint`, `long`, `ulong`, `short`, and `ushort`
    
-   Unity unmanaged [built-in types](https://docs-multiplayer.unity3d.com/netcode/current/advanced-topics/serialization/unity-primitives/) (which will be serialized by direct memcpy into/out of the buffer.): `Vector2`, `Vector3`, `Vector2Int`, `Vector3Int`, `Vector4`, `Quaternion`, `Color`, `Color32`, `Ray`, `Ray2D`
    
-   Any [`enum`](https://docs-multiplayer.unity3d.com/netcode/current/advanced-topics/serialization/enum_types/) types (which will be serialized by direct memcpy into/out of the buffer).
    
-   Any type (managed or unmanaged) that implements [`INetworkSerializable`](https://docs-multiplayer.unity3d.com/netcode/current/advanced-topics/serialization/inetworkserializable/) (which will be serialized by calling their `NetworkSerialize` method.) **On the reading side, these values are deserialized in-place, meaning the existing instance will be reused and any non-serialized values will be left in their current state.**
    
-   Any unmanaged struct type that implements [`INetworkSerializeByMemcpy`](https://docs-multiplayer.unity3d.com/netcode/current/advanced-topics/serialization/inetworkserializebymemcpy/) (which will be serialized by direct memcpy of the entire struct into/out of the buffer).
    
-   Unity [fixed string](https://docs-multiplayer.unity3d.com/netcode/current/advanced-topics/serialization/fixedstrings/) types: `FixedString32Bytes`, `FixedString64Bytes`, `FixedString128Bytes`, `FixedString512Bytes`, and `FixedString4096Bytes` (which are serialized intelligently, only sending the used part across the network and adjusting the "length" of the string on the other side to fit the received data).



> Netcode for GameObjects also supports **complex types** (as mentioned in the above), and can support both **unmanaged types** and **managed types** (although avoiding managed types where possible will improve your game's performance).





### ref 
https://docs-multiplayer.unity3d.com/netcode/current/basics/networkvariable/
