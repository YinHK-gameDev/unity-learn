## Relay server
The Relay service facilitates multiplayer support without dedicated game servers by allowing players to communicate with each other through Relay servers. Relay servers deliver messages between connected players using low-latency datagram exchange between game clients, so no two players ever connect directly to each other. Relay servers are ideal for games that use a listen server pattern where one player (the host player) acts as the “server” and the other players (the joining players) act as “clients.”

A Relay server disconnects a player if the player connection times out. The default time to live (TTL) before Relay disconnects a client is 10 seconds. The disconnect TTL is 60 seconds when the host in alone . 

### Relay locations and regions
By selecting the closest Relay server, the player can minimize the potential latency and guarantee the smoothest possible experience for their game session.

However, you don't need to include a region with an allocation request. If you omit the region, the Allocations service uses **QoS**.

### Quality of service (QoS)
Relay’s quality of service (QoS) feature allows you to select a region automatically based on quality of service data by starting the NetworkDriver as a host player without selecting a target region.

Creating an allocation request without specifying a region triggers the Allocations service to use quality of service data to select the best available region based on the quality of the connection between each region and the host. Relay considers both latency and packet loss.

Eg:

```cs
// Launch this method as a coroutine
private IEnumerator StartRelayServer()
{

  // Request an allocation to the Relay service without a target region
  var relayMaxPlayers = 5;
  var allocationTask = RelayService.Instance.CreateAllocationAsync(relayMaxPlayers);

  while(!allocationTask.IsCompleted)
  {
      yield return null;
  }

  if (allocationTask.IsFaulted)
  {
      Debug.LogError("Create allocation request failed");
      yield break;
  }

  var allocation = allocationTask.Result;

  // Request the join code to the Relay service
  var joinCodeTask = RelayService.Instance.GetJoinCodeAsync(allocation.AllocationId);

  while(!joinCodeTask.IsCompleted)
  {
      yield return null;
  }

  if (joinCodeTask.IsFaulted)
  {
      Debug.LogError("Create join code request failed");
      yield break;
  }

  // Get the Join Code, you can then share it with the clients so they can join
  JoinCode = joinCodeTask.Result;

  // Format the server data, based on desired connectionType
  var relayServerData = HostRelayData(allocation, "dtls");

  // Create the network parameters using the Relay server data
  var relayNetworkParameter = new RelayNetworkParameter{ ServerData = relayServerData };

  // Bind and listen to the Relay server
  yield return ServerBindAndListen(relayNetworkParameter);
}
```

> A **maximum of 100 players can join the host** in the same game session. Not all game types will scale to that high amount of players without the use of a dedicated game server. Carefully consider the impact on the host player when attempting high player count sessions with Relay. This limit's aligned with the maximum number of players allowed in a Lobby.

> Currently, there is no region-locking functionality; anyone can request an allocation in any region if the region has enough capacity to support the request.

> 

### ref 
https://docs.unity.com/relay/en-us/manual/relay-servers

Relay locations and regions \
https://docs.unity.com/relay/en-us/manual/locations-and-regions
