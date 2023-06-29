## Reconnect to lobby

When using **Relay and Lobby** together, the services attempt to synchronize the **relay connection state** with the **lobby membership**. If the user unexpectedly disconnects from Relay, it notifies the Lobby service, which marks the user as disconnected in the lobby metadata.


If the user is unable to reconnect to the services, they are automatically removed from the lobby after a timeout. If the user is able to reconnect, they can ask the Lobby service to mark the user as connected by using the **ReconnectToLobby API**.

This functionality is provided in the SDK through the **`ReconnectToLobbyAsync`** function


```cs

using System;
using UnityEngine;
using Unity.Services.Authentication;
using Unity.Services.Core;
​
async Task Reconnect()
{
    await LobbyService.Instance.ReconnectToLobbyAsync(lobbyApi);
}


```




### ref 
https://docs.unity.com/lobby/en-us/manual/reconnect-to-lobby



