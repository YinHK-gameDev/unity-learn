## Join a lobby
Players can join a lobby by specifying a **lobby ID** or by providing a **lobby code**. Lobby codes are short, auto-generated codes that map to specific lobbies and are intended for players to share with each other. The lobby code for a lobby is available as a members-only lobby property.



### Join by specifying a lobby ID
```cs
try
{
    await LobbyService.Instance.JoinLobbyByIdAsync("lobbyId");
}
catch (LobbyServiceException e)
{
    Debug.Log(e);
}
```

### Join by providing a lobby code

```cs
try
{
    await LobbyService.Instance.JoinLobbyByCodeAsync("lobbyCode");
}
catch (LobbyServiceException e)
{
    Debug.Log(e);
}

```

### Join a password-protected lobby

```cs
try
{
    // Join by ID:
    var idOptions = new JoinLobbyByIdOptions{Password ="mySecret"};
    await Lobbies.Instance.JoinLobbyByIdAsync("lobbyId", idOptions);

    // Join by Code:
    var codeOptions = new JoinLobbyByCodeOptions{Password ="mySecret"};
    await Lobbies.Instance.JoinLobbyByCodeAsync("lobbyId", codeOptions);
}
catch (LobbyServiceException e)
{
    Debug.Log(e);
}
```


### Quick join 
The **Quick Join API** allows players to quickly find and join a lobby **without needing to manually select a specific lobby** from a query. Players **set their query filters, call the Quick Join API**, and the Lobby service then tries to place them in a lobby that matches their criteria and has capacity.


Quick Join is designed to solve the common problem where a player manually does a query, looks at the results, selects a lobby to try to join, and then repeatedly fails to join because the lobby has already filled up by the time they attempt to join. It can also be used as a form of basic matchmaking (although only in existing lobbies, it does not create new ones).

> if there are **no lobbies** that match the query criteria, or if the join is attempted and then fails. In these scenarios, clients should expect to receive a **404** Not Found error. If a failure happens, clients can try to Quick Join again, or can fall back to creating a new lobby and assuming the host role.

```cs
try
{
    // Quick-join a random lobby with a maximum capacity of 10 or more players.
    QuickJoinLobbyOptions options = new QuickJoinLobbyOptions();

    options.Filter = new List<QueryFilter>()
    {
        new QueryFilter(
            field: QueryFilter.FieldOptions.MaxPlayers,
            op: QueryFilter.OpOptions.GE,
            value: "10")
    };

    var lobby = await LobbyService.Instance.QuickJoinLobbyAsync(options);

    // ...
}
catch (LobbyServiceException e)
{
      Debug.Log(e);
}


```








### ref 
https://docs.unity.com/lobby/en-us/manual/join-a-lobby
