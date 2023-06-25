## Clients
In the scope of Relay, there are two types of clients:

1. **Host client** - A host client is a game client of a host player. The target client is the target of a request from a joining client to join a game session on a Relay server.
2. **Joining client** - A joining client is a game client of a joining player. The joining client requests to join a host client on a Relay server for a game session.


### Disconnection

Disconnection is what happens when a joining player sends a DISCONNECT message to the host player. 

> This only disconnects the player from the host player in the game session. It **doesn't remove the player’s allocation from the Relay server**.

For a player to **deallocate from a Relay server (remove their allocation from the Relay server)**, they must send a **CLOSE message** to the Relay server. As a result, players must rebind to the Relay server through the connection flow after closing their connection.

In a typical game session, every player closes their own connection, with the host closing their connection last. Because the host player is the one who created the join code, closing their connection triggers Relay to:

- Release the host player’s allocation and the join code they created.
- End the host player’s connection to the Relay server.

When a player closes a connection, the Relay server updates all connected players to remove the disconnected player.

> Relay servers also disconnect players if the **connection times out**. You can prevent timeouts by keeping the connection alive.

DISCONNECT message \
https://docs.unity.com/relay/en-us/manual/relay-message-protocol#DISCONNE

CLOSE message \
https://docs.unity.com/relay/en-us/manual/relay-message-protocol#CLOSE

https://docs.unity.com/relay/en-us/manual/disconnection


### ref

https://docs.unity.com/relay/en-us/manual/clients
