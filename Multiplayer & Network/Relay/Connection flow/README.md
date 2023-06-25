## Connection flow


### Join codes

**Join codes are player-shared codes** that **allow players to group together into a logical game session**. Players can share these codes anyway they want, such as through a **Lobby**, **in-game chat**, or an **outside method such as chat service**.

> The join codes are case insensitive, simple, and short. This makes them easy to share, such as in situations where copy and pasting isn't available.

After a host player creates a game session, they then request a join code from the Allocations service to send to their friends. Their friends can then use the join code to join the host player's game session with their game client.

> Allocations and join codes are valid for as long as the host player is connected to the Relay server.

> Allocations and join codes are valid for as long as the host player is connected to the Relay server. If the host player disconnects from the Relay server, or if the connection times out, the allocation and join code become invalid. There is no way to explicitly invalidate a join code.


### ref
https://docs.unity.com/relay/en-us/manual/connection-flow
