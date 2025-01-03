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

> To use Unity Lobby service, link your unity project to Unity gaming service in project setting first.


   
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

Public lobbies do not require a lobby code to join and are **displayed in query results** for anyone to join.

The following code sample shows how to create a public lobby:

```cs

string lobbyName = "new lobby";
int maxPlayers = 4;
CreateLobbyOptions options = new CreateLobbyOptions();
//Set IsPrivate to false for public lobby
options.IsPrivate = false;  //set IsPrivate to false for public lobby

Lobby lobby = await LobbyService.Instance.CreateLobbyAsync(lobbyName, maxPlayers, options);

```

#### Private lobby
Private lobbies are **never visible in query results** and **require the lobby code or I**D to be manually provided to new players.

```cs
string lobbyName = "new lobby";
int maxPlayers = 4;
CreateLobbyOptions options = new CreateLobbyOptions();
//Set IsPrivate to true for private lobby
options.IsPrivate = true;

Lobby lobby = await LobbyService.Instance.CreateLobbyAsync(lobbyName, maxPlayers, options);
```

#### Create a lobby with standard, non-indexed data

Lobby data can be included in the create request as well as in subsequent update requests.

The following code sample shows how to create a lobby with standard, non-indexed data:

```cs
string lobbyName = "new lobby";
int maxPlayers = 4;
CreateLobbyOptions options = new CreateLobbyOptions();
options.Data = new Dictionary<string, DataObject>()
{
    {
        "ExamplePublicLobbyData", new DataObject(
            visibility: DataObject.VisibilityOptions.Public, // Visible publicly.
            value: "ExamplePublicLobbyData")
    },
};

Lobby lobby = await LobbyService.Instance.CreateLobbyAsync(lobbyName, maxPlayers, options);
```


#### Create a lobby with indexed string data
The following code sample shows how to create a lobby with indexed string data:

```cs
string lobbyName = "new lobby";
int maxPlayers = 4;
CreateLobbyOptions options = new CreateLobbyOptions();
options.Data = new Dictionary<string, DataObject>()
{
    {
        "GameMode", new DataObject(
            visibility: DataObject.VisibilityOptions.Public, // Visible publicly.
            value: "Conquest",
            index: DataObject.IndexOptions.S1)
    },
};

Lobby lobby = await LobbyService.Instance.CreateLobbyAsync(lobbyName, maxPlayers, options);

```
#### Create a lobby with indexed numeric data

The following code sample shows how to create a lobby with indexed numeric data:

```cs
string lobbyName = "new lobby";
int maxPlayers = 4;
CreateLobbyOptions options = new CreateLobbyOptions();
options.Data = new Dictionary<string, DataObject>()
{
    {
        "MinimumSkillLevel", new DataObject(
            visibility: DataObject.VisibilityOptions.Public, // Visible publicly.
            value: "25",
            index: DataObject.IndexOptions.N1)
    },
};

Lobby lobby = await LobbyService.Instance.CreateLobbyAsync(lobbyName, maxPlayers, options);
```

#### Create a lobby with player data for the host
As with lobby data, player data for the host can also be included in the create request instead of adding it with a separate update request.

The following code sample shows how to create a lobby with player data for the host:

```cs
string lobbyName = "new lobby";
int maxPlayers = 4;
CreateLobbyOptions options = new CreateLobbyOptions();
// Ensure you sign-in before calling Authentication Instance.
// See IAuthenticationService interface.
options.Player = new Player(
    id: AuthenticationService.Instance.PlayerId,
    data: new Dictionary<string, PlayerDataObject>()
    {
        {
            "ExampleMemberPlayerData", new PlayerDataObject(
                visibility: PlayerDataObject.VisibilityOptions.Member, // Visible only to members of the lobby.
                value: "ExampleMemberPlayerData")
        }
    });

Lobby lobby = await LobbyService.Instance.CreateLobbyAsync(lobbyName, maxPlayers, options);

```

#### Active and inactive lobbies

Lobbies are marked as **inactive** if they haven’t been updated or sent a heartbeat request in the **past 30 seconds**. You can **configure this timeout period**. **Inactive public lobbies do not appear in query results**, and **both public and private inactive lobbies are automatically deleted**. **Inactive lobbies** can be **reactivated** by being updated or sending a **heartbeat request**.


#### Lobby data and player data

Lobbies support two types of **custom data**:

-   **Lobby-scoped data** is associated with the entire lobby and can include fields that are indexed for querying.
-   **Player-scoped data** is associated with a specific player in a specific lobby. Each player in the lobby can have different set properties.

#### Limits

**Lobby data**

-   **Maximum properties**: 20
-   **Non-indexed**: 2 KB / each
-   **Indexed**: 128 B / each
-   **Maximum number of indexed strings**: 5
-   **Maximum number of indexed numbers**: 5

**Player data**

-   **Maximum properties**: 10/player
-   **Maximum size**: 2KB
-   Not indexable


#### Data access and visibility

There are three levels of access to data:

##### Public data
-   Data that is visible to anyone, including players who are not in the lobby.
-   Examples of public data include maps and profile icons.

##### Member data

-   Data that is only visible to players who have joined the lobby.

##### Private data

-   Data that is only visible to an individual player who is in the lobby.
-   Lobby data that is only visible to the host, player data that is only visible to the owning player and the host.

Depending on a player's role in the lobby (host, member, or non-member), they have different access restrictions to data:

| Role of Player | Write lobby data | Read lobby data | Write player data for their player | Write player data for other players | Read player data with the following visibility |
| --- | --- | --- | --- | --- | --- |
| Lobby Host | Yes | Yes: **Public, Member & Private** | Yes | No | Yes: **Public & Member** |
| Lobby Member | No | Yes: **Public** & **Member** | Yes | No | Yes: **Public & Member** |
| Non-member | No | Yes: **Public** | No | No | Yes: **Public** |

> **Note**: Only the host can modify lobby data. In addition, a player’s data can only be modified by the player themselves.


### Delete a lobby
**Lobby hosts can delete their lobbies**. **Deleted lobbies are no longer accessible**; deleted lobbies **do not appear in queries** and all APIs targeting a deleted lobby (for example, **Get** and **Update**) fail.

> **Note**: The lobby is automatically deleted when the last player leaves the lobby.

> Clients should expect that they can be removed from a lobby at any time. This could be due to the lobby being deleted, the player being removed from a lobby by the host, the player being removed from the lobby due to a relay disconnect, or a service outage.


```cs
try
{
    await LobbyService.Instance.DeleteLobbyAsync("lobbyId");
}
catch (LobbyServiceException e)
{
    Debug.Log(e);
}

```


### Leave a lobby
When players leave a lobby, their **player ID** is removed from the **players list**. If the host leaves the lobby, another player in the lobby is randomly selected as the host. The host also has the ability to remove other players from the lobby. The same **`RemovePlayerAsync API`** call is used in both cases where the host simply specifies the other player's playerId instead of their own. Lobbies are automatically deleted when the last player in the lobby leaves.

```cs
try
{
            //Ensure you sign-in before calling Authentication Instance
            //See IAuthenticationService interface
            string playerId = AuthenticationService.Instance.PlayerId;
            await LobbyService.Instance.RemovePlayerAsync("lobbyId", playerId);
}
catch (LobbyServiceException e)
{
            Debug.Log(e);
}
```

### Relay integration

https://docs.unity.com/lobby/en-us/manual/relay-integration





### Game Lobby Sample
This sample demonstrates how to use the Lobby and Relay packages to create a typical game lobby experience.


-   **Anonymous Auth login**: Track player credentials without a persistent account.
-   **Lobby creation**: Players host lobbies for others to join.
-   **Lobby query**: Find a list of lobbies with filters, or use lobby codes.
-   **Relay obfuscation**: Players in a lobby are connected through an anonymous IP.
-   **UTP communication**: Players transmit basic data to lobby members in real time.
-   **Lobby + Relay connection management**: Together, the services automatically handle new connections and disconnections.
-   **Vivox Voice**: Create a voice channel for the lobby to allow for voice communication, with per-user volume control and muting.

https://docs.unity.com/lobby/en-us/manual/game-lobby-sample  
https://github.com/Unity-Technologies/com.unity.services.samples.game-lobby

https://www.youtube.com/watch?v=mgIDwkaVAqw&t=153s

### ref 
https://docs.unity.com/lobby/en/manual/unity-lobby-service

https://unity.com/products/lobby

https://www.youtube.com/watch?v=-KDlEBfCBiU

Lobby SDK Scripting API \
https://docs.unity.com/lobby/en-us/packages/com.unity.services.lobby/1.0/api/Unity.Services.Lobbies

Lobby REST API \
https://services.docs.unity.com/lobby/v1/index.html


