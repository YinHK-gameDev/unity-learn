## Update Lobby data
The **lobby host is the only player that can update the lobby’s data**. Other players can read this data depending on the visibility option


Lobby-level data can be used in various ways:

-   **Public** indexed lobby properties can be used in query filters to find matching lobbies
    
    -   For example, your game can use "game mode" as a custom public, indexed property, and players can search for "game mode = foo" in their queries to find matching lobbies.
-   **Members-only** lobby properties can be set by the host but are visible to all members
    
    -   This can be used to share data with just lobby members
-   **Private** lobby data is only visible and set by the host
    
    -   This can be used to set data that might be used on reconnects or for the next host if there is a host migration.


#### Lobby data: 

-   **Maximum properties**: 20
-   **Non-indexed**: 2 KB / each
-   **Indexed**: 128 B / each
-   **Maximum number of indexed strings**: 5
-   **Maximum number of indexed numbers**: 5


The following code sample shows how to update lobby data:

```cs
try
        {
            UpdateLobbyOptions options = new UpdateLobbyOptions();
            options.Name = "testLobbyName";
            options.MaxPlayers = 4;
            options.IsPrivate = false;

            // Ensure you sign-in before calling Authentication Instance
            // See IAuthenticationService interface
            options.HostId = AuthenticationService.Instance.PlayerId;

            options.Data = new Dictionary<string, DataObject>()
            {
                {
                    "ExamplePrivateData", new DataObject(
                        visibility: DataObject.VisibilityOptions.Private,
                        value: "PrivateData")
                },
                {
                    "ExamplePublicData", new DataObject(
                        visibility: DataObject.VisibilityOptions.Public,
                        value: "PublicData",
                        index: DataObject.IndexOptions.S1)
                },
            };

            var lobby = await LobbyService.Instance.UpdateLobbyAsync("lobbyId", options);

            //...
        }
        catch (LobbyServiceException e)
        {
            Debug.Log(e);
        }
```

### ref 
https://docs.unity.com/lobby/en-us/manual/update-lobby-data
