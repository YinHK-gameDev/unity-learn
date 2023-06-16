## Networking components

### NetworkObject
Netcode for GameObjects' high level components, the RPC system, object spawning, and NetworkVariables all rely on there being at least two Netcode components added to a GameObject:

- **NetworkObject**
- **NetworkBehaviour**
>
> > Note: To replicate any Netcode aware properties or send/receive RPCs, a GameObject must have a **NetworkObject component** and at least one **NetworkBehaviour component**.
>
> 
https://docs-multiplayer.unity3d.com/netcode/current/basics/networkobject/

### NetworkObject Parenting
https://docs-multiplayer.unity3d.com/netcode/current/advanced-topics/networkobject-parenting/


### NetworkBehaviour
NetworkBehaviour is an abstract class that derives from MonoBehaviour and is primarily used to create unique netcode/game logic.

NetworkBehaviours can contain RPC methods and NetworkVariables.


> Note: Both the **NetworkObject** and **NetworkBehaviour** components require the use of specialized structures to be serialized and used with RPCs and **NetworkVariables**:

https://docs-multiplayer.unity3d.com/netcode/current/basics/networkbehavior/


### Physics

https://docs-multiplayer.unity3d.com/netcode/current/advanced-topics/physics/


### NetworkManager
The NetworkManager is a required Netcode for GameObjects (Netcode) component that has all of your project's netcode related settings. Think of it as the "central netcode hub" for your netcode enabled project.

#### Starting a Server, Host, or Client
```cs
NetworkManager.Singleton.StartServer();      // Starts the NetworkManager as just a server (that is, no local client).
NetworkManager.Singleton.StartHost();        // Starts the NetworkManager as both a server and a client (that is, has local client)
NetworkManager.Singleton.StartClient();      // Starts the NetworkManager as just a client.
```

https://docs-multiplayer.unity3d.com/netcode/current/components/networkmanager/


