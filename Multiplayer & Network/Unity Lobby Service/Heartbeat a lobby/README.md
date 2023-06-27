## Heartbeat a lobby

> Lobbies are marked as **inactive** if they **haven’t been updated or sent a heartbeat request** by the host within a given duration. The default active lifespan of a lobby is **30 seconds**.


Inactive public lobbies do not appear in query results nor are they joinable through ‘Quick Join’, and both public and private inactive lobbies will eventually be automatically deleted. Inactive lobbies can be reactivated by being updated or sent a heartbeat request by the host.




After **1 hour of inactivity**, a lobby is considered **expired**. An expired lobby may be deleted at any time. Upon deletion, a lobby is no longer available in queries or any APIs. This duration is not configurable. You may reactivate an expired lobby by updating it or sending a heartbeat.



```cs
async Task<Lobby> CreateLobbyWithHeartbeatAsync()
    {
        string lobbyName = "test lobby";
        int maxPlayers = 4;
        CreateLobbyOptions options = new CreateLobbyOptions();

        // Lobby parameters code goes here...
        // See 'Creating a Lobby' for example parameters
        var lobby = await LobbyService.Instance.CreateLobbyAsync(lobbyName, maxPlayers, options);

        // Heartbeat the lobby every 15 seconds.
        StartCoroutine(HeartbeatLobbyCoroutine(lobby.Id, 15));
        return lobby;
    }

    IEnumerator HeartbeatLobbyCoroutine(string lobbyId, float waitTimeSeconds)
    {
        var delay = new WaitForSecondsRealtime(waitTimeSeconds);

        while (true)
        {
            LobbyService.Instance.SendHeartbeatPingAsync(lobbyId);
            yield return delay;
        }

```
While hosts should periodically heartbeat their lobbies when in use, hosts should also be mindful of these lobbies and delete them afterward. A very simple way to do this is to loop over created lobbies during shutdown.

The following code sample shows how to utilize a **MonoBehavior**’s **OnApplicationQuit()** function to delete created lobbies:



```cs
ConcurrentQueue<string> createdLobbyIds = new ConcurrentQueue<string>();

void OnApplicationQuit()
{
    while (createdLobbyIds.TryDequeue(out var lobbyId))
    {
        LobbyService.Instance.DeleteLobbyAsync(lobbyId);
    }
}


```

### ref 
https://docs.unity.com/lobby/en-us/manual/heartbeat-a-lobby


