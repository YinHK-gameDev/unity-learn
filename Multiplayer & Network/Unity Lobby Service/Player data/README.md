## Update Player data
**Players can update their own data in a lobby**. The lobby host and other players can read this data depending on the data visibility option


#### Player data: 

-   **Maximum properties**: 10/player
-   **Maximum size**: 2KB
-   Not indexable




```cs

try
        {
            UpdatePlayerOptions options = new UpdatePlayerOptions();

            options.Data = new Dictionary<string, PlayerDataObject>()
            {
                {
                    "existing data key", new PlayerDataObject(
                        visibility: PlayerDataObject.VisibilityOptions.Private,
                        value: "updated data value")
                },
                {
                    "new data key", new PlayerDataObject(
                        visibility: PlayerDataObject.VisibilityOptions.Public,
                        value: "new data value")
                }
            };

            //Ensure you sign-in before calling Authentication Instance
            //See IAuthenticationService interface
            string playerId = AuthenticationService.Instance.PlayerId;

            var lobby = await LobbyService.Instance.UpdatePlayerAsync("lobbyId", playerId, options);

            //...
        }
        catch (LobbyServiceException e)
        {
            Debug.Log(e);
        }


```

### ref 
https://docs.unity.com/lobby/en-us/manual/update-player-data
