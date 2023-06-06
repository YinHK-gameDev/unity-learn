## Network Manager

### Game state management
A Networking multiplayer game can run in **three modes** - as a **client**, as a **dedicated server**, or as a **"Host"** which is both a client and a server at the same time.

If you’re using the **Network Manager HUD**, it automatically tells the Network Manager which mode to start in, based on which options the player selects. If you’re writing your own UI
 that allows the player to start the game, you’ll need to call these from your own code. These methods are:

- **`NetworkManager.StartClient`**
- **`NetworkManager.StartServer`**
- **`NetworkManager.StartHost`**


### ref 
https://docs.unity.cn/Manual/UNetManager.html

