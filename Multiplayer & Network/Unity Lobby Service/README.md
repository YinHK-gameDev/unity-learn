## Unity Lobby Service
The **Lobby service** provides a way for players to **discover and connect to each other** to accomplish a variety of multiplayer gaming scenarios.

Lobby **allows your players to connect before or during a game session**. Players create public lobbies using simple game attributes which other players can then search, discover, and join. **Invite-only** lobbies also allow players to create private spaces for select participants only.

Lobby service can do:

- Browse a list of available game sessions and allow the player to select and join one.
- Share a join code with your friend to allow them to directly connect to your game session.
- Use Quick Join to find any available match and jump in.
- Create a private lobby and send invites to your in-game friends list.
- Host a lobby from a game server and use it to manage and restrict access to the server session.
- Query for lobbies that match a specific set of requirements (e.g. game mode, map type).


### Install Lobby SDK
Unity Package named **`com.unity.services.lobby`**.


1.  In Unity, navigate to **Window** > **Package Manager**.
2.  From the **Package Manager**, search for **`com.unity.services.lobby`** or scroll through the **Unity Registry** to find the **Lobby** package.
3.  Select the package and click **Install**.

   
### Authentication
To use the Lobby service, authenticate yourself using [Unity Authentication](https://docs.unity.com/authentication/en/manual/intro-unity-authentication). Make sure to [initialize the authentication service](https://docs.unity.com/authentication/en/manual/initialize-sdk) and sign in before making any calls using the Lobby SDK. While there are many sign in methods, the easiest way to get started is with Anonymous sign in. See the [Unity Authentication anonymous sign in guide](https://docs.unity.com/authentication/en/manual/use-anon-signin) to get started.


### Create a lobby

When a player creates a new lobby, they can set the following properties with the create call:

-   Lobby name (**required**)
-   Lobby visibility (**public or private**)
-   Lobby size (the maximum occupancy)
    -   This is referred to as **Max Players** in the code.
-   Password
    -   An **8 to 64 character password** required to join a lobby.
-   Initial custom lobby data
    -   This can include any **arbitrary data**. For example, map IDs and game modes.
    -   Lobby data with string or numeric values can be indexed, allowing for filtering and ordering on those indexes in queries.
-   Initial (host) player data
    -   For example, player display names, skills and characters.

> **Note**: When a player creates a lobby, they automatically become the host.


#### Public lobby

Public lobbies do not require a lobby code to join and are displayed in query results for anyone to join.

The following code sample shows how to create a public lobby:

```cs

string lobbyName = "new lobby";
int maxPlayers = 4;
CreateLobbyOptions options = new CreateLobbyOptions();
options.IsPrivate = false;

Lobby lobby = await LobbyService.Instance.CreateLobbyAsync(lobbyName, maxPlayers, options);

```



### Game Lobby Sample
This sample demonstrates how to use the Lobby and Relay packages to create a typical game lobby experience.


-   **Anonymous Auth login**: Track player credentials without a persistent account.
-   **Lobby creation**: Players host lobbies for others to join.
-   **Lobby query**: Find a list of lobbies with filters, or use lobby codes.
-   **Relay obfuscation**: Players in a lobby are connected through an anonymous IP.
-   **UTP communication**: Players transmit basic data to lobby members in real time.
-   **Lobby + Relay connection management**: Together, the services automatically handle new connections and disconnections.
-   **Vivox Voice**: Create a voice channel for the lobby to allow for voice communication, with per-user volume control and muting.

https://docs.unity.com/lobby/en-us/manual/game-lobby-sample \  
https://github.com/Unity-Technologies/com.unity.services.samples.game-lobby

### ref 
https://docs.unity.com/lobby/en/manual/unity-lobby-service

https://unity.com/products/lobby

https://www.youtube.com/watch?v=-KDlEBfCBiU
