## NetworkVariable

NetworkVariable is the way data can be synchronized between peers in abstracted ways.

At a high level, a `NetworkVariable` is a way to synchronize a property ("variable") between a server and client(s) without having to use custom messages or RPCs. Since `NetworkVariable` is a wrapper ("container") of the stored value of type `T`, you must use the `NetworkVariable.Value` property to access the actual value being synchronized

-   Newly joining clients (that is, "Late Joining Clients")
    -   When the associated `NetworkObject` of a `NetworkBehaviour`, with `NetworkVariable` properties, is spawned, any `NetworkVariable`'s current state (`Value`) is automatically synchronized on the client side.
-   Connected clients
    -   When a `NetworkVariable` value changes, any connected clients that subscribed to `NetworkVariable.OnValueChanged` event (prior to the value being changed) will be notified of the change.
        -   Two parameters are passed to any `NetworkVariable.OnValueChanged` subscribed callback method:
            -   First parameter (Previous): The previous value before the value was changed
            -   Second parameter (Current): The newly changed `NetworkVariable.Value`.



### ref 
https://docs-multiplayer.unity3d.com/netcode/current/basics/networkvariable/
