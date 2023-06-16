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



