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

### ref 
https://docs.unity.com/lobby/en-us/manual/join-a-lobby
