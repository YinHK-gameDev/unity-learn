## Multiplayer & Network


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

### Photon fusion
https://www.photonengine.com/fusion#

### Tutorial for multi player online
https://medium.com/@GamingRoy/unity-%E5%A4%9A%E4%BA%BA%E9%80%A3%E7%B7%9A-mlapi-1-739fccc98bd3

https://www.cg.com.tw/UnityMultiplayerNetworking/

https://www.youtube.com/watch?v=eymqAMmnqPg

https://www.youtube.com/watch?v=IvCVFywNXMc&t=19s

https://www.youtube.com/watch?v=aTnBAzin9vE&t=32s

https://www.youtube.com/watch?v=eymqAMmnqPg&t=51s


### ref
https://docs.unity.cn/Manual/UNetOverview.html

https://www.youtube.com/watch?v=7glCsF9fv3s

https://docs.unity3d.com/Manual/UNet.html

https://www.youtube.com/watch?v=swIM2z6Foxk

**MLAPI documentation** \
https://github.com/Unity-Technologies/com.unity.netcode.gameobjects

**`UnityEngine.Networking` Svripting API** \
https://docs.unity3d.com/Packages/com.unity.multiplayer-hlapi@0.2/api/UnityEngine.Networking.html
