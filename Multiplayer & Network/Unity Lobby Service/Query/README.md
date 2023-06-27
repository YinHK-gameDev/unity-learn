## Query for lobbies

Players can use the query API to discover public lobbies they might want to join. They can browse through the lobbies and view their public information. 


Every lobby has its own metadata, which includes the **lobby name**, **project ID**, **maximum number of players**, and **a list of players**. 

Game developers can also add **custom metadata** to add **specific types of data** that are **unique** to the game, such as the **map ID**. Only custom data which is set to **public** visibility is visible by players who have not joined a lobby.


### Sorting
Players can specify the sort order of the lobbies that are returned by the **query API**. For example, if players want to only view the most recently created lobbies, then they can sort by **lobby creation time**.


### Filtering lobbies
Players can **specify one or more filters** when using the **query API** to view only the lobbies that **fit their parameters**.


For example, players can filter by **lobby name**, **maximum lobby size**, **available player slots**, and **creation date**, or by **using custom data such as game type**, **map**, or **level requirements**. You can **only filter within your own project and environment**.

Eg: 

```cs
try
{
    QueryLobbiesOptions options = new QueryLobbiesOptions();
    options.Count = 25;

    // Filter for open lobbies only
    options.Filters = new List<QueryFilter>()
    {
        new QueryFilter(
            field: QueryFilter.FieldOptions.AvailableSlots,
            op: QueryFilter.OpOptions.GT,
            value: "0")
    };

    // Order by newest lobbies first
    options.Order = new List<QueryOrder>()
    {
        new QueryOrder(
            asc: false,
            field: QueryOrder.FieldOptions.Created)
    };

    QueryResponse lobbies = await Lobbies.Instance.QueryLobbiesAsync(options);

    //...
}
catch (LobbyServiceException e)
{
    Debug.Log(e);
}
```

### Filtering with custom data
Lobbies have **five custom string fields (S1-S5)** and **five custom number fields (N1-N5)** that 
you can **use for querying**. This is helpful for customizing lobby browsing experiences for players. For example, **a game can enable players to filter by mode, map, region, and skill**.

```cs

// Creating a custom indexed string property to be used as lobby data
var lobbyData = new Dictionary<string, DataObject>
{
    {
        "GameMode", new DataObject(
            visibility: DataObject.VisibilityOptions.Public,
            value: "Conquest",
            index: DataObject.IndexOptions.S1)
    }
};

// ... set the lobby data ...

// Create query filter for the custom data that was set above
var queryFilter = new List<QueryFilter>()
{
    new QueryFilter(
        field: QueryFilter.FieldOptions.S1,
        op: QueryFilter.OpOptions.EQ,
        value: "Conquest")
};

```

### Randomized query results
When multiple players with the same query filter want to query for lobbies at the same time and there are more results available than requested, the lobby service uses randomized sampling to return different query results. This helps to minimize contention and to distribute players evenly between lobbies so they can start their games as soon as possible. This alleviates the load time and facilitates connection to games when multiple players are looking to connect to similar games.

Randomized sampling ensures that players with the same search criteria are not shown the same query result, which could lead to players trying to join lobbies that have filled up since the query was performed. However, there is always a potential race condition where players might attempt to join a lobby that has already filled up; client logic should expect this to happen and should plan to gracefully handle lobby join failures.


### Pagination
Clients can also choose not to randomize their query results, in which case results can be paginated. When querying for non-randomized results, a continuation token is returned in the response. This token can be provided to a subsequent query to fetch the next page of results. Note that even if the next page has 0 lobbies, a continuation token will still be provided.

The following code sample shows the basic pattern for using continuation tokens:

```cs

// Common query options to use for paging
        var queryOptions = new QueryLobbiesOptions
        {
            SampleResults = false, // Paging cannot use randomized results
            Filters = new List<QueryFilter>
                    {
                        // Only include open lobbies in the pages
                        new QueryFilter(
                            field: QueryFilter.FieldOptions.AvailableSlots,
                            op: QueryFilter.OpOptions.GT,
                            value: "0")
                    },
            Order = new List<QueryOrder>
                    {
                        // Show the oldest lobbies first
                        new QueryOrder(true, QueryOrder.FieldOptions.Created),
                    }
        };

        var response = await LobbyService.Instance.QueryLobbiesAsync(queryOptions);
        var lobbies = response.Results;

        // A continuation token will still be returned when the next page is empty,
        // so continue paging until there are no new lobbies in the response
        while (lobbies.Count > 0)
        {
            // Do something here with the lobbies in the current page

            // Get the next page. Be careful not to modify the filter or order in the
            // query options, as this will return an error
            queryOptions.ContinuationToken = response.ContinuationToken;
            response = await LobbyService.Instance.QueryLobbiesAsync(queryOptions);
            lobbies = response.Results;
        }


```




### ref 

https://docs.unity.com/lobby/en-us/manual/query-for-lobbies





