## NetworkVariable

NetworkVariable is the way **data can be synchronized between peers** in abstracted ways.

At a high level, a `NetworkVariable` is a way to synchronize a property ("variable") between a server and client(s) without having to use custom messages or RPCs. Since `NetworkVariable` is **a wrapper ("container") of the stored value of type `T`**, you must use the `NetworkVariable.Value` property to access the actual value being synchronized

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




### ref 
https://docs-multiplayer.unity3d.com/netcode/current/basics/networkvariable/
