## Spawning and Ownership
Either the server (default) or any connected and approved client each NetworkObject. Netcode for GameObjects is **server-authoritative, which means the server controls** (the only system authorized) spawning and despawning NetworkObjects.

### Object Spawning, Destroying and Despawning
In Unity, you typically create a new game object using the `Instantiate` function. Creating a game object with `Instantiate` will only create that object on the local machine. `Spawning` in Netcode for GameObjects (Netcode) means to instantiate and/or spawn the object that is synchronized between all clients by the server.

Netcode uses a server authoritative networking model so spawning netcode objects can only be done on a server or host. To spawn a network prefab, you must first create an instance of the network Prefab and then invoke the spawn method on the `NetworkObject` component of the instance you created.  
_In most cases, you will want to keep the `NetworkObject` component attached to the root `GameObject` of the network prefab._

By default a newly spawned network Prefab instance is owned by the server unless otherwise specified.

https://docs-multiplayer.unity3d.com/netcode/current/basics/object-spawning/


### Object Pooling

Netcode for GameObjects (Netcode) provides built-in support for Object Pooling, which allows you to override the default Netcode destroy and spawn handlers with your own logic. This allows you to store destroyed network objects in a pool to reuse later. 


This is useful for often used objects, such as projectiles, and is a way to increase the application's overall performance. By pre-instantiating and reusing the instances of those objects, object pooling removes the need to create or destroy objects at runtime, which can save a lot of work for the CPU. This means that instead of creating or destroying the same object over and over again, it's simply deactivated after use, then, when another object is needed, the pool recycles one of the deactivated objects and reactivates it.

https://docs-multiplayer.unity3d.com/netcode/current/advanced-topics/object-pooling/





