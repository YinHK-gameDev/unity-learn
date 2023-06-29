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

### Get joined lobbies

If players need to determine their current lobby membership, they can use the **GetJoinedLobbies** API. This API returns a list of lobby IDs for the lobbies that the active player is currently a member of.

One common use for **`GetJoinLobbies`** is handling **unexpected disconnects**. If a game crashes or the user disconnects from a lobby for any reason, you can use this API to get a **list of all lobbies a player is a member** of and then use the GetLobby API to retrieve the full lobby details or Reconnect to lobby.

```CS
try
{
        var lobbyIds = await LobbyService.Instance.GetJoinedLobbiesAsync();
}
catch (LobbyServiceException e)
{
        Debug.Log(e);
}
```

> **Note**: You can't get a private lobby unless you're a member of the lobby.



### ref 
https://docs.unity.com/lobby/en-us/manual/reconnect-to-lobby



