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


### ref 

https://docs.unity.com/lobby/en-us/manual/query-for-lobbies





