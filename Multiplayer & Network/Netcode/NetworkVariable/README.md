## NetworkVariable

NetworkVariable is the way data can be synchronized between peers in abstracted ways.

At a high level, a `NetworkVariable` is a way to synchronize a property ("variable") between a server and client(s) without having to use custom messages or RPCs. Since `NetworkVariable` is a wrapper ("container") of the stored value of type `T`, you must use the `NetworkVariable.Value` property to access the actual value being synchronized





### ref 
https://docs-multiplayer.unity3d.com/netcode/current/basics/networkvariable/
