## Lobby events

The Lobby package includes the Lobby Events system, which allows you to subscribe to real-time lobby events. Events are sent every time member-observable player/lobby state is changed. For example, when a player joins or leaves, a player updates public/member data, or the host updates public/member lobby data. Events are not sent if a player or the host updates a private property of the lobby.


Using events can be more efficient than polling for lobby state through gets, especially since it requires no action until some data is changed. Events are efficient when the number of gets per second is significantly larger than the number of events received per second. Furthermore, event payloads only contain patches, so in general, they have the additional benefit that their payloads are much smaller than those returned by a get. The biggest downside to events is that they are unreliable and do not guarantee in-order delivery. See Lobby versions for more.

> **Note**: Events can be unreliable and do not guarantee in-order delivery.

Call the **`SubscribeToLobbyEventsAsync`** method on a Lobby instance to subscribe to receiving updates for that instance. Once subscribed, the Lobby service invokes the **`LobbyChanged`** event each time a change occurs. You can also use the **`ApplyToLobby`** helper method to apply the changes to the **`Models.Lobby`** object.



### Receive updates

To subscribe to a lobby’s real-time updates, you must call:

```cs 
Lobbies.Instance.SubscribeToLobbyEventsAsync(lobbyId, callbacks);
```

```cs 
Lobbies.Instance.SubscribeToLobbyEventsAsync(lobbyId, callbacks);
```

-   The callbacks object provides the callbacks for consuming the real-time changes.
-   The callbacks parameter accepts an instance of **`LobbyEventsCallbacks`**, which you must create and subscribe to.

> **Note**: A player can only receive events for a lobby if they are in that lobby.

```cs

// OnLobbyChanged, OnKickedFromLobby and OnLobbyEventConnectionStateChanged handle the events.


m_Lobby = await Lobbies.Instance.CreateLobbyAsync(lobbyName, maxPlayers, options);
var callbacks = new LobbyEventCallbacks();
callbacks.LobbyChanged += OnLobbyChanged;
callbacks.KickedFromLobby += OnKickedFromLobby;
callbacks.LobbyEventConnectionStateChanged += OnLobbyEventConnectionStateChanged;
try {
    m_LobbyEvents = await Lobbies.Instance.SubscribeToLobbyEventsAsync(m_Lobby.Id, callbacks);
}
catch (LobbyServiceException ex)
{
    switch (ex.Reason) {
        case LobbyExceptionReason.AlreadySubscribedToLobby: Debug.LogWarning($"Already subscribed to lobby[{m_Lobby.Id}]. We did not need to try and subscribe again. Exception Message: {ex.Message}"); break;
        case LobbyExceptionReason.SubscriptionToLobbyLostWhileBusy: Debug.LogError($"Subscription to lobby events was lost while it was busy trying to subscribe. Exception Message: {ex.Message}"); throw;
        case LobbyExceptionReason.LobbyEventServiceConnectionError: Debug.LogError($"Failed to connect to lobby events. Exception Message: {ex.Message}"); throw;
        default: throw;
    }
}
```

The following code sample provides an example handler for OnLobbyChanged. It demonstrates how to handle a deleted lobby instance.

```cs
private void OnLobbyChanged(ILobbyChanges changes)
{
    if (changes.LobbyDeleted)
    {
        // Handle lobby being deleted
        // Calling changes.ApplyToLobby will log a warning and do nothing
    }
    else
    {
        changes.ApplyToLobby(m_Lobby);
    }
    // Refresh the UI in some way
}
```

### ref 
https://docs.unity.com/lobby/en-us/manual/lobby-events
