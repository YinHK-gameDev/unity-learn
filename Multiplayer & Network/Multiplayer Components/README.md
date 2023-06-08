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




### ref
https://docs.unity.cn/Manual/UNetReference.html
