## Network Manager HUD

The **Network Manager HUD ("heads-up display")** provides the basic functions so that people playing your game can start hosting a networked game, or find and join an existing networked game. Unity displays the **Network Manager HUD** as a **collection of simple UI** buttons in the Game view.

The Network Manager HUD is a quick-start tool to help you start building your multiplayer game straight away, without first having to build a user interface for game creation/connection/joining. The idea is that these controls are useful to get you started, but you should create your own UI later on, to allow your players to find and join games in a way that suits your game.

To start using the Network Manager HUD, create an empty GameObject in your Scene (menu: **GameObject > Create Empty**) and add the **Network Manager HUD component** to the new GameObject.


The **Network Manager HUD** has two basic modes: **LAN (Local Area Network) mode** and **Matchmaker mode**. 

-  **LAN mode** is for creating or joining games hosted on a **local area network** (that is, multiple computers connected to the same network)
-  **Matchmaker mode** is for creating, finding and joining games across the internet (multiple computers connected to separate networks)

The **Network Manager HUD** starts in **LAN mode**, and displays buttons relating to hosting and joining a **LAN-based multiplayer game**. To switch the HUD to **Matchmaker mode**, click the **Enable Match Maker (M) button**.


> **Note**: Remember that the Network Manager HUD feature is a temporary aid to development. It allows you to get your multiplayer game running quickly, but you should replace it with your own UI controls when you are ready.



### ref 
https://docs.unity.cn/Manual/UNetManagerHUD.html

