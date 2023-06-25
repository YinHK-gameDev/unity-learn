## Relay server
The Relay service facilitates multiplayer support without dedicated game servers by allowing players to communicate with each other through Relay servers. Relay servers deliver messages between connected players using low-latency datagram exchange between game clients, so no two players ever connect directly to each other. Relay servers are ideal for games that use a listen server pattern where one player (the host player) acts as the “server” and the other players (the joining players) act as “clients.”

A Relay server disconnects a player if the player connection times out. The default time to live (TTL) before Relay disconnects a client is 10 seconds. The disconnect TTL is 60 seconds when the host in alone . 

### Relay locations and regions
By selecting the closest Relay server, the player can minimize the potential latency and guarantee the smoothest possible experience for their game session.

### ref 
https://docs.unity.com/relay/en-us/manual/relay-servers

Relay locations and regions \
https://docs.unity.com/relay/en-us/manual/locations-and-regions
