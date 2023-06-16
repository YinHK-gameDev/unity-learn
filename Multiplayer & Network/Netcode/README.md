## Netcode
**Netcode for GameObjects (Netcode)** is a **high-level networking library** built for Unity for you to **abstract networking logic**. It enables you to **send GameObjects and world data across a networking session to many players at once**. With Netcode, you can focus on building your game instead of **low-level protocols and networking frameworks.**


The **Netcode for Entities**, part of the Unity's **Data Oriented Technology Stack (DOTS)**, provides a **server authoritive with client prediction framewor**k that you can use to create multiplayer games.

-   [Netcode for Entities](https://docs.unity3d.com/Packages/com.unity.netcode@latest) - Unity's official netcode SDK for Entities workflows.
-   [Netcode for GameObjects](https://github.com/Unity-Technologies/com.unity.netcode.gameobjects) - Unity's official netcode SDK for GameObject workflows. \
    https://docs-multiplayer.unity3d.com/netcode/current/tutorials/get-started-ngo/

### Starting NGO guide
https://docs-multiplayer.unity3d.com/netcode/current/tutorials/get-started-ngo/

### Create a command line helper
Shows how to create a command line helper that launches the project outside the Unity Editor to make testing builds easier.

https://docs-multiplayer.unity3d.com/netcode/current/tutorials/command-line-helper/

### Test & Debugging

**Testing multiplayer games locally** \
https://docs-multiplayer.unity3d.com/netcode/current/tutorials/testing/testing_locally/

**Testing multiplayer games with artificial network conditions** \
https://docs-multiplayer.unity3d.com/netcode/current/tutorials/testing/testing_with_artificial_conditions/#system-wide-network-conditioners


#### Local multiplayer setup
First, build an executable by selecting **File > Build Settings > Build**.

After you have the build, you can **launch several instances of the build executable to host or join a game**.

#### Multiplayer over Internet
First, build an executable and distribute it to all players.
Next, you need to set up Uunity **relay**. 

Alternatively you can use Port Forwarding. The [https://portforward.com/](https://portforward.com/) site has guides on how to enable port forwarding on a huge number of routers.

### Network Synchronizing
https://docs-multiplayer.unity3d.com/netcode/current/advanced-topics/ways-synchronize/

#### Remote Procedure Calls
At a high level, when calling an **`RPC`** client side, the SDK will take a note of the object, component, method and any parameters for that **`RPC`** and send that information over the network. The server will receive that information, find the specified object, find the specified method and call it on the specified object with the received parameters.

When calling an **`RPC`**, you call a method remotely on an object that can be anywhere in the world. They're **"events"** you can trigger when needed.

If you call an **`RPC`** method on your side, it will execute on a different machine.

Netcode has two variations of RPCs to execute logic on either server-side or client-side: [`ServerRpc`](https://docs-multiplayer.unity3d.com/netcode/current/advanced-topics/message-system/serverrpc/) and [`ClientRpc`](https://docs-multiplayer.unity3d.com/netcode/current/advanced-topics/message-system/clientrpc/).


![](../img/ServerRPCs.png)
![](../img/ServerRPCs_ClientHosts_CalledByClient.png)
![](../img/ServerRPCs_ClientHosts_CalledByClientHost.png)

![](../img/ClientRPCs.png)
![](../img/ClientRPCs_ClientHosts_CalledByClientHost.png)

![](../img/table.png)

https://docs-multiplayer.unity3d.com/netcode/current/advanced-topics/messaging-system/

#### RPC usage checklist:
To use RPCs, make sure
​
-   **`[ClientRpc]`** or **`[ServerRpc]`** attributes are on your method
-   Your method name ends with **`ClientRpc`** or **`ServerRpc`** (ex: **`DoSomethingServerRpc()`**)
-   your method is declared in a class that inherits from **`NetworkBehaviour`**
    -   your GameObject has a **NetworkObject component** attached
-   Make sure to call your RPC method server side or client side (using **`isClient`** or **`isServer`**)
-   **Only accept value types as parameters**

#### Serialization Types and RPCs


[](https://docs-multiplayer.unity3d.com/netcode/current/advanced-topics/messaging-system//#serialization-types-and-rpcs "Direct link to Serialization Types and RPCs")

Instances of Serializable Types are passed into an RPC as parameters and are serialized and replicated to the remote side.

See [Serialization](https://docs-multiplayer.unity3d.com/netcode/current/advanced-topics/serialization/serialization-intro/) for more information.

### Sample project better understanding Netcode

#### Boss Room
https://unity.com/demos/small-scale-coop-sample?_ga=2.100857537.1177058850.1686617745-1095169982.1671075740&_gac=1.221831914.1686617745.CjwKCAjwhJukBhBPEiwAniIcNT_ODysZ3wmhZlXGoXup3iC7aEHgtkcVtYcP2gLPMuESHpxH-IR4qhoCnroQAvD_BwE

https://docs-multiplayer.unity3d.com/netcode/current/learn/bossroom/bossroom/

https://github.com/Unity-Technologies/com.unity.multiplayer.samples.coop

#### Bitesize Samples
https://docs-multiplayer.unity3d.com/netcode/current/learn/bitesize/bitesize-introduction/


#### Galactic Kittens (2D cooperative game)

https://unity.com/demos/galactic-kittens

https://github.com/UnityTechnologies/GalacticKittens

https://github.com/UnityTechnologies/GalacticKittens/wiki/Setup-Instructions

### Netcode tutorial

https://www.youtube.com/watch?v=3yuBOB3VrCk

https://www.youtube.com/watch?v=7glCsF9fv3s

https://www.youtube.com/watch?v=dKrdrPjJG04

https://www.youtube.com/watch?v=swIM2z6Foxk

https://www.youtube.com/watch?v=Kzmq0O06y-I

https://greenbeansplay.com/unity-netcode-relay-unitytransport/

https://blog.csdn.net/qq_46044366/article/details/125138735

https://www.youtube.com/watch?v=eymqAMmnqPg

https://youtu.be/d1FpS5hYlVE

https://youtu.be/rFCFMkzFaog

https://youtu.be/GOtE96OKyVA

https://youtu.be/82Lbho7S0OA

### ref 
https://docs.unity3d.com/Packages/com.unity.netcode@1.0/manual/index.html?_ga=2.162961848.561805926.1686181003-1095169982.1671075740&_gac=1.155129034.1686003811.Cj0KCQjwj_ajBhCqARIsAA37s0zIin1gt0fr6pQ7Ni-iXQAS4JhPYDqcq8wDPFa5kR40YMdFCtAKbM8aAiltEALw_wcB

https://docs-multiplayer.unity3d.com/netcode/current/installation/index.html?_ga=2.25615289.561805926.1686181003-1095169982.1671075740&_gac=1.217903332.1686003811.Cj0KCQjwj_ajBhCqARIsAA37s0zIin1gt0fr6pQ7Ni-iXQAS4JhPYDqcq8wDPFa5kR40YMdFCtAKbM8aAiltEALw_wcB

**Document reference** \
https://docs-multiplayer.unity3d.com/netcode/current/about/

**API reference** \
https://docs.unity3d.com/Packages/com.unity.netcode.gameobjects@1.4/api/index.html

https://docs-multiplayer.unity3d.com/netcode/current/api/introduction/

