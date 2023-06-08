## Multiplayer Component Reference

### Network Animator
The **Network Animator component** allows you to **synchronize animation states for networked objects**.
It synchronizes state and parameters from an AnimatorController.

The Network Animator ensures the synchronisation of GameObject animation across the network - meaning that all players see the animation happen at the same.

https://docs.unity.cn/Manual/class-NetworkAnimator.html

### Network Discovery
**Network Discovery** is a component that allows Unity applications using the **networking system to find each other** on a **local network (LAN)**.

The Network Discovery component does not require any integration with Unity services, and is intended as a fully stand-alone solution to finding other games on your local network to connect with.

https://docs.unity.cn/Manual/class-NetworkDiscovery.html


### Network Identity
The **Network Identity component** is at the heart of the Unity networking high-level API. It controls a **GameObject’s unique identity on the network**, and it uses that identity to make the networking system aware of the GameObject.

https://docs.unity.cn/Manual/class-NetworkIdentity.html

### Network Lobby Manager
The **NetworkLobbyManager** is a specialized type of **NetworkMana**ger that **provides a multiplayer lobby before entering the main play scene** of the game. It allows you to set up a network with:

-   A maximum player limit
-   Automatic start when all players are ready
-   Option to prevent players from joining a game in progress
-   Support for “Couch Multiplayer” (i.e. multiple players per client)
-   Customizable ways for players to choose options while in lobby

There are **two types of player objects** with the NetworkLobbyManager:

1. LobbyPlayer Object
   -  One for each player
   -  Created when client connects, or player is added
   -  Persists until client disconnects
   -  Holds ready flag and configuration data
   -  Handles commands in the lobby
   -  should use the **NetworkLobbyPlayer component**


2. GamePlayer Object
   -   One for each player
   -   Created when game scene is started
   -   Destroyed when re-entering lobby
   -   Handles commands in the game

https://docs.unity.cn/Manual/class-NetworkLobbyManager.html


### Network Lobby Player
The **Network Lobby Player** stores **per-player state** for the **Network Lobby Manager** while in the lobby. When using this component, you need to write a script which **allows players to indicate they are ready to begin playing**, which sets the **`readyToBegin`** property.



https://docs.unity.cn/Manual/class-NetworkLobbyPlayer.html


### Network Manager HUD
The **Network Manager HUD** is a simple and quick way to provide the basic functions that players of your game need in order to host a networked game, or find and join an existing networked game. It displays a collection of simple UI buttons which appear in the Game view when the Editor is in Play mode. It is intended as a helpful short term solution to get you started quickly with making your game. You should replace the UI it provides with your own that better suits your game when you are ready.
 
https://docs.unity.cn/Manual/class-NetworkManagerHUD.html

### Network Manager 
The **Network Manager component** allows you to control the state of a networked game. It provides an interface in the Editor for you to configure the network, the Prefabs you use for spawning GameObjects, and the Scenes you use for different game states.
 
https://docs.unity.cn/Manual/class-NetworkManagerUNet.html 


### Network Proximity Checker
The **Network Proximity Checker** component controls the visibility of GameObjects for network clients, based on proximity to players.
 
 
https://docs.unity.cn/Manual/class-NetworkProximityChecker.html


### NetworkStartPosition
**NetworkStartPosition** is used by the **NetworkManager** when creating player objects. The position and rotation of the **NetworkStartPosition** are used to place the newly created player object.
 
https://docs.unity.cn/Manual/class-NetworkStartPosition.html

### Network Transform
The **Network Transform component** **synchronizes the movement and rotation** of GameObjects across the network. 
> **Note**: the network Transform component **only synchronizes spawned networked GameObjects**.

https://docs.unity.cn/Manual/class-NetworkTransform.html


### Network Transform Child

The **Network Transform Child component** **synchronizes the position and rotation of the child GameObject of a GameObject with a Network Transform component.**

You should use this component in situations where you need to synchronize an independently-moving child object of a Networked GameObject.

https://docs.unity.cn/Manual/class-NetworkTransformChild.html


### Network Transform Visualizer

The **Network Transform Visualizer** is a utility component that allows you to visualize the interpolation of GameObjects that use the **Network Transform component**.
 
To use it, add it to a GameObject that already has a **Network Transform component**, and assign a Prefab in the Inspector. The Prefab can be anything you choose, it will be used as a visual representation of the incoming transform data for GameObject.

![](./img/NetworkTransformVisualizerExample2.gif)

 https://docs.unity.cn/Manual/class-NetworkTransformVisualizer.html
 
 

 
 
### ref
https://docs.unity.cn/Manual/UNetReference.html
