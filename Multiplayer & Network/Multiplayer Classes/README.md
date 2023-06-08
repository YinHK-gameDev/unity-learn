## Multiplayer Classes

You can create **scripts**A piece of code that allows you to create your own Components, trigger game events, modify Component properties over time and respond to user input in any way you like. [More info](https://docs.unity.cn/Manual/UNetClassesReference.htmlCreatingAndUsingScripts.html)  

-   The [NetworkBehaviour](https://docs.unity.cn/Manual/UNetClassesReference.htmlclass-NetworkBehaviour.html) class works with **GameObjects**The fundamental object in Unity scenes, which can represent characters, props, scenery, cameras, waypoints, and more. A GameObject’s functionality is defined by the Components attached to it. [More info](https://docs.unity.cn/Manual/UNetClassesReference.htmlclass-GameObject.html)  
-   The [NetworkClient](https://docs.unity.cn/Manual/UNetClassesReference.htmlclass-NetworkClient.html) class manages a network connection from a client to a server, and can send and receive messages between the client and the server.
-   The [NetworkConnection](https://docs.unity.cn/Manual/UNetClassesReference.htmlclass-NetworkConnection.html) encapsulates a network connection. (NetworkClient)\[class-NetworkClient\] objects have a `NetworkConnection`, and [NetworkServers](https://docs.unity.cn/Manual/UNetClassesReference.htmlclass-NetworkServer.html) have multiple connections - one from each client. NetworkConnections have the ability to send byte arrays, or serialized objects as network messages.
-   The [NetworkServer](https://docs.unity.cn/Manual/UNetClassesReference.htmlclass-NetworkServer.html) manages connections from multiple clients, and provides game-related functionality such as spawning, local clients, and player manager.
-   The [NetworkServerSimple](https://docs.unity.cn/Manual/UNetClassesReference.htmlclass-NetworkServerSimple.html) is a basic server class with no game-related functionality. While the NetworkServer class handles game-like things such as spawning, local clients, and player manager, and has a static interface, the NetworkServerSimple class is a pure network server with no game related functionality. It also has no static interface or singleton, so more than one instance can exist in a process at a time.


### NetworkBehaviour
https://docs.unity.cn/Manual/class-NetworkBehaviour.html

https://docs.unity.cn/Packages/com.unity.multiplayer-hlapi@1.0/api/UnityEngine.Networking.html

### NetworkClient
https://docs.unity.cn/Manual/class-NetworkClient.html

https://docs.unity.cn/Packages/com.unity.multiplayer-hlapi@1.0/api/UnityEngine.Networking.NetworkClient.html


### NetworkConnection

https://docs.unity.cn/Manual/class-NetworkConnection.html

https://docs.unity.cn/Packages/com.unity.multiplayer-hlapi@1.0/api/UnityEngine.Networking.NetworkConnection.html


### NetworkServer

https://docs.unity.cn/Manual/class-NetworkServer.html

https://docs.unity.cn/Packages/com.unity.multiplayer-hlapi@1.0/api/UnityEngine.Networking.NetworkServer.html


### NetworkServerSimple

https://docs.unity.cn/Manual/class-NetworkServerSimple.html

https://docs.unity.cn/Packages/com.unity.multiplayer-hlapi@1.0/api/UnityEngine.Networking.NetworkServerSimple.html



### ref 
https://docs.unity.cn/Manual/UNetClassesReference.html

https://docs.unity.cn/Packages/com.unity.multiplayer-hlapi@1.0/api/UnityEngine.Networking.html
