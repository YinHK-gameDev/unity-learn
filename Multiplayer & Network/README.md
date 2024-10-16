## Multiplayer & Network

### Gaming networking topologies


#### Local or couch multiplayer
Using just client runtime Couch multiplayer games consist of local multiplayer games that can be played on the same screen, such as a TV, from one couch.

#### Lan game (offline)
Server and Client Runtime involved and transport, usually a hosted server on a site.

#### Peer-to-Peer (P2P)

A peer-to-peer network is created when two or more PCs are connected and share resources without going through a separate server computer.

![](./img/peer2peer1-ead2681c659d6587ef6adf05b1b70d70.png)

#### Client hosted (Listen server)
![](./img/client-hosted-16be0b1c9b5020f21325b1e6a7beca73.png)

> Note: They function like dedicated servers, but typically have the disadvantage of having to communicate with remote players over the residential internet connection of the hosting player. Performance is also reduced by the simple fact that the machine running the server is also generating an output image.


#### Dedicated Game Server (DGS)
![](./img/ded_server-d5369721966357b9b4d5e1fa96b05b22.png)

https://docs-multiplayer.unity3d.com/netcode/current/terms-concepts/network-topologies/


### Setting up a multiplayer project

- A **Network Manager**
- A **user interface** (for players to find and join games)
- **Networked Player Prefabs** (for players to control)
- Scripts and GameObjects which are multiplayer-aware


### Network Manager component
The Network Manager is responsible for managing the networking aspects of your multiplayer game. You should have one (and only one) Network Manager active in your Scene at a time.
 
Unity’s built-in Network Manager component wraps up all of the features for managing your multiplayer game into one single component. If you have custom requirements which aren’t covered by this component, you can write your own network manager in script instead of using this component. If you’re just starting out with multiplayer games, you should use this component.

The **Network Manager** is the core controlling component of a multiplayer game. To get started, create an **empty GameObject** in your starting Scene, and add the **NetworkManager** component. 


https://docs.unity.cn/Manual/UNetManager.html


### Multiplayer-aware Scripts
Writing scripts for a multiplayer game is different to writing scripts for a single-player game. This is because when you write a script for a multiplayer game, you need to think about the different contexts that the scripts run in.


For example, the scripts you place on your player Prefab should allow the “owner” of that player instance to control it, but it should not allow other people to control it.

For player GameObjects, each person usually has active control over their own player instance. This means each client has local authority over its own player, and the server accepts what the client tells it about what the player is doing.

For non-player GameObjects, the server usually has authority over what happens (such as whether an item has been collected), and all clients accept what the server tells them about what has happened to that GameObject.

### A listen server
A listen server acts as both a server and client on a single player's machine for multiplayer game play. This means one player both plays the game and owns the game world while other players connect to this server.

Personal computers are hidden behind NATs (Network Address Translation devices) and routers to protect them from direct access. To connect to a listen server, you may choose an option such as [port forwarding](https://docs-multiplayer.unity3d.com/netcode/current/learn/listen-server-host-architecture/#port-forwarding#port-forwarding), a [relay server](https://docs-multiplayer.unity3d.com/netcode/current/learn/listen-server-host-architecture/#port-forwarding#relay-server), [NAT punch-through](https://docs-multiplayer.unity3d.com/netcode/current/learn/listen-server-host-architecture/#port-forwarding#nat-punchthrough), or a [NAT punch with relay fallback](https://docs-multiplayer.unity3d.com/netcode/current/learn/listen-server-host-architecture/#port-forwarding#nat-punch-and-relay-fallback).


### Tutorial for multiplayer online
https://medium.com/@GamingRoy/unity-%E5%A4%9A%E4%BA%BA%E9%80%A3%E7%B7%9A-mlapi-1-739fccc98bd3

https://www.cg.com.tw/UnityMultiplayerNetworking/

https://www.youtube.com/watch?v=eymqAMmnqPg

https://www.youtube.com/watch?v=IvCVFywNXMc&t=19s

https://www.youtube.com/watch?v=aTnBAzin9vE&t=32s

https://www.youtube.com/watch?v=eymqAMmnqPg&t=51s

**OFFICIAL Unity Multiplayer Sample How it Works (Galactic Kittens Unity Tutorial)** \
https://www.youtube.com/watch?v=JIN9BRNMtjI

**Unity Lobby + Relay for peer-to-peer multiplayer game** \
https://greenbeansplay.com/unity3d-lobby-relay/

**Unity Netcode + Relay for peer-to-peer multiplayer game connection** \
https://greenbeansplay.com/unity-netcode-relay-unitytransport/

#### MULTIPLAYER NETWORKING ROADMAP
https://unity.com/roadmap/unity-platform/multiplayer-networking


### Unity Services Web APIs
Unity's Web APIs allow you to use Unity Services to build and manage your projects with your preferred language and engine.
https://services.docs.unity.com/

### ref
https://docs.unity.cn/Manual/UNetOverview.html

https://www.youtube.com/watch?v=7glCsF9fv3s

https://docs.unity3d.com/Manual/UNet.html

https://www.youtube.com/watch?v=swIM2z6Foxk

**MLAPI documentation** \
https://github.com/Unity-Technologies/com.unity.netcode.gameobjects

**`UnityEngine.Networking` Scripting API** \
https://docs.unity3d.com/Packages/com.unity.multiplayer-hlapi@0.2/api/UnityEngine.Networking.html
