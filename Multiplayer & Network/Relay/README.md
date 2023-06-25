## Unity Relay
**Netcode for GameObjects (Netcode)** allows you to connect to a host by its IP and port. However, if the **host isn't on the same network as you** (for example, somewhere over the Internet), you will need some **extra services to achieve a successful connection** and, as a result, a successful game.

Unity Relay exposes a way for game developers to securely offer increased connectivity between players by using a join code style workflow without needing to invest in a third-party solution, maintain dedicated game servers (DGS), or worry about the network complexities of a peer-to-peer game. Instead of using DGS, the Relay service **provides connectivity through a universal Relay server** **acting as a proxy**.

**Using a Relay server**: \
The server is on the Internet with a **public-facing IP that you and the host can reach**. After **each side binds with the Relay**, they can **establish a connection and send data to each other via the Relay server**.

Relay **allows players to connect and enjoy immersive multiplayer gaming experiences - all without needing a dedicated game server.** Our service enables **easy and secure peer-to-peer communication between players**.

### What Is A Relay Server?
By default Sync does its best to establish direct connection between peers to achieve maximum speed. However, sometimes direct connection is not possible due to sophisticated NATs, firewalls, proxy servers, etc. that block Sync's port. In this case relay server will allow Sync to establish connection to other peers and transfer data without direct connection. This will impact the speed at which the files sync though. Files are synced to the relay server and passed over to other peers. Files are always encrypted and are not exposed to a third party server, relay cannot read them and they are not stored anywhere.

The Relay service facilitates multiplayer support without dedicated game servers by allowing players to communicate with each other through Relay servers. **Relay servers deliver messages between connected players using low-latency datagram exchange between game clients**, so no two players ever connect directly to each other. Relay servers are ideal for games that use a listen server pattern where one player (the host player) acts as the **"server"** and the other players (the joining players) act as **"clients"**.

The peer-to-peer client server model hosts games on the machine of a player, saving you the cost of renting or maintaining dedicated servers.

**Relay supports DTLS (Datagram Transport Layer Security) encryption of all UDP communication to and from the Relay servers which enables users to deliver data that is authenticated and encrypted**.

### Get started with Relay

#### Set up a Relay project
**Relay is a PAYG (pay as you go) service** with a free tier. If you exceed the free tier monthly usage limit, you must enter payment information to keep full access to Relay and any other services.

1. Create a Unity Dashboard project.
2. Enable the Relay service.
    1.  From the Unity Dashboard, select **Multiplayer** > **Relay**.
    2.  Select **Set up Relay**.
    3.  Continue to the Relay **Setup guide** embedded in the Unity Dashboard.
3. Link your Relay project in the Unity Editor.
    1.  Open your project in the Unity Engine and navigate to **Edit** > **Project Settings**.
    2.  From the **Project Settings** window, go to the **Services** tab.
    3.  Select **Use an existing Unity project ID** and link to the Dashboard project displayed in the **Setup guide**.
    4.  After you the project links successfully, you're ready to move on to the next step of the integration process.
4. Install the Relay package.
    1.  In Unity, navigate to **Window** > **Package Manager**.
    2.  From the Package Manager, search or scroll to find the “Relay” package within the Unity Registry.
    3.  Select the package and click the Install button.
5. Check out **Simple Relay sample** to learn how to interact with the sample project.

### ref 
https://docs.unity.com/relay/en/manual/introduction

https://unity.com/products/relay

https://help.resilio.com/hc/en-us/articles/204754779-What-is-a-Relay-Server-

https://docs-multiplayer.unity3d.com/netcode/current/relay/
