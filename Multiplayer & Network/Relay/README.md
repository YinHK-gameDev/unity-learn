## Unity Relay
Netcode for GameObjects (Netcode) allows you to connect to a host by its IP and port. However, if the host isn't on the same network as you (for example, somewhere over the Internet), you will need some extra services to achieve a successful connection and, as a result, a successful game.

**Using a Relay server**: \
The server is on the Internet with a **public-facing IP that you and the host can reach**. After **each side binds with the Relay**, they can **establish a connection and send data to each other via the Relay server**.

Relay **allows players to connect and enjoy immersive multiplayer gaming experiences - all without needing a dedicated game server.** Our service enables **easy and secure peer-to-peer communication between players**.

### Relay servers
The Relay service facilitates multiplayer support without dedicated game servers by allowing players to communicate with each other through Relay servers. **Relay servers deliver messages between connected players using low-latency datagram exchange between game clients**, so no two players ever connect directly to each other. Relay servers are ideal for games that use a listen server pattern where one player (the host player) acts as the "server" and the other players (the joining players) act as **"clients"**.



### ref 
https://docs.unity.com/relay/en/manual/introduction
