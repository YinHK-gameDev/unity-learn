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

You might want your players to be able to choose the host they want to connect to. When you get to that stage, the **Network Discovery component** can be used for broadcasting and finding **addresses** and **ports** on a **local area network (LAN)**, and the **Matchmaker** service can be used for players to find internet matches to connect to 

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


### Scene management
There are two slots on the NetworkManager Inspector for scenes: 
- the **Offline** Scene  
- the **Online** Scene.

When a server or host is started, the **Online Scene is loaded**. This then becomes the current network Scene. Any clients that connect to that server are instructed to also load that Scene. The **name of this Scene** is stored in the **`networkSceneName` property**.

When the network is stopped, by stopping the server or host or by a **client disconnecting**, the **offline Scene is loaded**. This allows the game to automatically return to a **menu Scene** when **disconnected from a multiplayer game**.


Change Scenes while the game is active by calling **`NetworkManager.ServerChangeScene()`**. This makes all the currently connected clients change Scene too, and updates **`networkSceneName`** so that new clients also load the new Scene.

While networked Scene management is active, any calls to **game state management functions** such as **`NetworkManager.StartHost()`** or **`NetworkManager.StopClient()`** can **cause Scene changes**. 

> **Note**: Scene changes cause all the GameObjects in the previous Scene to be destroyed.

You should normally make sure the Network Manager persists between Scenes, otherwise the network connection is broken upon a Scene change. To do this, ensure the **Don’t Destroy On Load box** is checked in the Inspector. However it is also possible to have a separate Network Manager in each Scene with different settings, which may be helpful if you wish to control incremental Prefab loading, or different Scene transitions.

### Customization
There are virtual functions on the NetworkManager class that you can customize by creating **your own derived class** that inherits from **NetworkManager**. When implementing these functions, be sure to take care of the functionality that the default implementations provide.


https://docs.unity3d.com/Packages/com.unity.multiplayer-hlapi@0.2/api/UnityEngine.Networking.NetworkManager.html

The inspector for the NetworkManager provides the ability to change some connection parameters and timeouts. Some parameters have not been exposed here but can be changed through code.

```cs
using UnityEngine;
using UnityEngine.Networking;

public class CustomManager : NetworkManager {
    // Set custom connection parameters early, so they are not too late to be enforced
    void Start()
    {
        customConfig = true;
        connectionConfig.MaxCombinedReliableMessageCount = 40;
        connectionConfig.MaxCombinedReliableMessageSize = 800;
        connectionConfig.MaxSentMessageQueueSize = 2048;
        connectionConfig.IsAcksLong = true;
        globalConfig.ThreadAwakeTimeout = 1;
    }
}
```

### Converting a single-player game to Unity Multiplayer

#### NetworkManager set-up
- Add a new **GameObject** to the Scene and rename it **"NetworkManager"**.
- Add the **NetworkManager component** to the **"NetworkManager"** GameObject.
- Add the **NetworkManagerHUD component** to the GameObject. This provides the default UI
 for managing the network game state.
 
 
#### Player Prefab set-up
- Find the Prefab for the player GameObject in the game, or create a Prefab from the player GameObject.
- Add the **NetworkIdentity component** to the player Prefab.
- Check the **LocalPlayerAuthority box** on the NetworkIdentity
- Set the **playerPrefab** in the **NetworkManager’s Spawn Info** section to the **player Prefab**
- Remove the player GameObject instance from the Scene if it exists in the Scene

#### Player movement

- Add a **`NetworkTransform` component** to the player Prefab
- Update input and control scripts to respect `isLocalPlayer`
- Fix **Camera **to use spawned player and `isLocalPlayer`

eg:

```cs
using UnityEngine;
using UnityEngine.Networking;

public class Controls : NetworkBehaviour
{
    void Update()
    {
        if (!isLocalPlayer)
        {
            // exit from update if this is not the local player
            return;
        }

        // handle player input for movement
    }
}
```

#### Basic player game state

- Make scripts that contain important data into **NetworkBehaviours** instead of **MonoBehaviours**
- Make important member variables into SyncVars

#### Networked actions
-   Make scripts that perform important actions into NetworkBehaviours instead of MonoBehaviours
-   Update functions that perform important player actions to be commands


#### Non-player GameObjects

Fix non-player prefabs such as enemies:

- Add the **`NetworkIdentify`** component
- Add the **`NetworkTransform`** component
- Register spawnable Prefabs with the **NetworkManager**
- Update scripts with **game state and actions**


#### Spawners

- Potentially change spawner scripts to be **NetworkBehaviours**
- Modify spawners to only run on the server (use isServer property or the **`OnStartServer()`** function)
- Call **`NetworkServer.Spawn()`** for created GameObjects

#### Spawn positions for players

- Add a new GameObject and place it at player’s start location
- Add the **`NetworkStartPosition` component** to the new GameObjec


#### Lobby

-   Create Lobby Scene
-   Add a new GameObject to the Scene and rename it to “NetworkLobbyManager”.
-   Add the NetworkLobbyManager component to the new GameObject.
-   Configure the Manager:
    -   Scenes
    -   Prefabs
    -   Spawners




### ref 
https://docs.unity.cn/Manual/UNetManager.html

