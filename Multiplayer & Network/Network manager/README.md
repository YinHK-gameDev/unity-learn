## Network Manager

### Game state management
A Networking multiplayer game can run in **three modes** - as a **client**, as a **dedicated server**, or as a **"Host"** which is both a client and a server at the same time.

If you’re using the **Network Manager HUD**, it automatically tells the Network Manager which mode to start in, based on which options the player selects. If you’re writing your own UI
 that allows the player to start the game, you’ll need to call these from your own code. These methods are:

- **`NetworkManager.StartClient`**
- **`NetworkManager.StartServer`**
- **`NetworkManager.StartHost`**


### Spawn management

Use the **Network Manager** to manage the spawning (networked instantiation) of networked GameObjects from Prefabs.

The **"Spawn Info"** section of the **Network Manager** component.

Most games have a Prefab which represents the player, so the Network Manager has a Player Prefab slot. You should assign this slot with your player Prefab. When you have a player Prefab set, a player GameObject is automatically spawned from that Prefab for each user in the game. This applies to the local player on a hosted server, and remote players on remote clients. You must attach a **`Network Identity` component** to the Player Prefab.

Once you have assigned a player Prefab, you can start the game as a host and see the player GameObject spawn. Stopping the game destroys the player GameObject. If you build and run another copy of the game and connect it as a client to _localhost_, the Network Manager makes another player GameObject appear. When you stop that client, it destroys that player’s GameObject.


### ref 
https://docs.unity.cn/Manual/UNetManager.html

