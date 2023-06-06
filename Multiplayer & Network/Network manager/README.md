## Network Manager

### Game state management
A Networking multiplayer game can run in **three modes** - as a **client**, as a **dedicated server**, or as a **"Host"** which is both a client and a server at the same time.

If you’re using the **Network Manager HUD**, it automatically tells the Network Manager which mode to start in, based on which options the player selects. If you’re writing your own UI
 that allows the player to start the game, you’ll need to call these from your own code. These methods are:

- **`NetworkManager.StartClient`**
- **`NetworkManager.StartServer`**
- **`NetworkManager.StartHost`**

Whichever mode the game starts in (client, server, or host), the Network Address and Network Port properties are used.

In client mode, the game attempts to connect to the address and port specified. 

In server or host mode, the game listens for incoming connections on the port specified.

### Spawn management

Use the **Network Manager** to manage the spawning (networked instantiation) of networked GameObjects from Prefabs.

The **"Spawn Info"** section of the **Network Manager** component.

Most games have a Prefab which represents the player, so the Network Manager has a Player Prefab slot. You should assign this slot with your player Prefab. When you have a player Prefab set, a player GameObject is automatically spawned from that Prefab for each user in the game. This applies to the local player on a hosted server, and remote players on remote clients. You must attach a **`Network Identity` component** to the Player Prefab.

Once you have assigned a player Prefab, you can start the game as a host and see the player GameObject spawn. Stopping the game destroys the player GameObject. If you build and run another copy of the game and connect it as a client to _localhost_, the Network Manager makes another player GameObject appear. When you stop that client, it destroys that player’s GameObject.

In addition to the player Prefab, you **must also register other Prefabs** that you want to dynamically spawn during gameplay with the Network Manager.

You can add Prefabs to the list shown in the inspector labelled **Registered Spawnable Prefabs**. You can also can **register prefabs via code**, with the **`ClientScene.RegisterPrefab()`** method.

> **Note:** If you have only one Network Manager, you need to register to it all prefabs which might be spawned in any Scene. If you have a separate Network Manager in each Scene, you only need to register the prefabs relevant for that Scene.

### Customizing Player Instantiation

The Network Manager spawns player GameObjects using its implementation of **`NetworkManager.OnServerAddPlayer()`**.

 If you want to customize the way player GameObjects are created, you can override that virtual function.
 
 ```cs
 public virtual void OnServerAddPlayer(NetworkConnection conn, short playerControllerId)
{
    var player = (GameObject)GameObject.Instantiate(playerPrefab, playerSpawnPos, Quaternion.identity);
    NetworkServer.AddPlayerForConnection(conn, player, playerControllerId);
}
```
Note: If you are implementing a custom version of OnServerAddPlayer, the method **`NetworkServer.AddPlayerForConnection()`** **must be called for the newly created player GameObject**, so that it is spawned and associated with the client’s connection. 

### Start positions
To control where players are spawned, you can use the **Network Start Position component**. To use these, attach a **Network Start Position component** to a GameObject in the Scene, and position the GameObject where you would like one of the players to start. 


The Network Manager has a **Player Spawn Method** property, which allows you to configure how start positions are chosen.

- Choose Random to spawn players at randomly chosen startPosition options.
- Choose Round Robin to cycle through startPosition options in a set list.

You can customize how the start positions are selected by using code. You can access the available Network Start Position components by the list **`NetworkManager.startPositions`**, and you can use the helper method **`GetStartPosition()`** on the **Network Manager** that can be used in implementation of **`OnServerAddPlayer`** to find a start position.

### ref 
https://docs.unity.cn/Manual/UNetManager.html

