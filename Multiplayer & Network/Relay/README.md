## Unity Relay
Netcode for GameObjects (Netcode) allows you to connect to a host by its IP and port. However, if the host isn't on the same network as you (for example, somewhere over the Internet), you will need some extra services to achieve a successful connection and, as a result, a successful game.

Unity Relay exposes a way for game developers to securely offer increased connectivity between players by using a join code style workflow without needing to invest in a third-party solution, maintain dedicated game servers (DGS), or worry about the network complexities of a peer-to-peer game. Instead of using DGS, the Relay service **provides connectivity through a universal Relay server** **acting as a proxy**.

**Using a Relay server**: \
The server is on the Internet with a **public-facing IP that you and the host can reach**. After **each side binds with the Relay**, they can **establish a connection and send data to each other via the Relay server**.

Relay **allows players to connect and enjoy immersive multiplayer gaming experiences - all without needing a dedicated game server.** Our service enables **easy and secure peer-to-peer communication between players**.

### What Is A Relay Server?
By default Sync does its best to establish direct connection between peers to achieve maximum speed. However, sometimes direct connection is not possible due to sophisticated NATs, firewalls, proxy servers, etc. that block Sync's port. In this case relay server will allow Sync to establish connection to other peers and transfer data without direct connection. This will impact the speed at which the files sync though. Files are synced to the relay server and passed over to other peers. Files are always encrypted and are not exposed to a third party server, relay cannot read them and they are not stored anywhere.



The Relay service facilitates multiplayer support without dedicated game servers by allowing players to communicate with each other through Relay servers. **Relay servers deliver messages between connected players using low-latency datagram exchange between game clients**, so no two players ever connect directly to each other. Relay servers are ideal for games that use a listen server pattern where one player (the host player) acts as the **"server"** and the other players (the joining players) act as **"clients"**.



### ref 
https://docs.unity.com/relay/en/manual/introduction

https://help.resilio.com/hc/en-us/articles/204754779-What-is-a-Relay-Server-
