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

### KickedFromLobby

The Lobby Event service uses the **`KickedFromLobby`** handler to remove a user from the lobby. This can happen for a number of reasons. For example, when the connection fails or if the host removes the user from the lobby. When a user gets kicked out of a lobby, they receive a message that the lobby event connection state has changed ( **`LobbyEventConnectionStateChanged`**) to **`unsubscribed`**.

The following code sample provides an example handler for **`OnKickedFromLobby`**:

```cs
private void OnKickedFromLobby()
{


    // These events will never trigger again, so let’s remove it.
    this.m_LobbyEvents = null;
    // Refresh the UI in some way
}
```

The following code sample provides an example handler for OnLobbyEventConnectionStateChanged:

> **Note**: When there’s an error with the connection to Lobby Events, Lobby will not attempt to reconnect.


```cs
private void OnLobbyEventConnectionStateChanged(LobbyEventConnectionState state)
{
    switch (state)
    {
        case LobbyEventConnectionState.Unsubscribed: /* Update the UI if necessary, as the subscription has been stopped. */ break;
        case LobbyEventConnectionState.Subscribing: /* Update the UI if necessary, while waiting to be subscribed. */ break;
        case LobbyEventConnectionState.Subscribed: /* Update the UI if necessary, to show subscription is working. */ break;
        case LobbyEventConnectionState.Unsynced: /* Update the UI to show connection problems. Lobby will attempt to reconnect automatically. */ break;
        case LobbyEventConnectionState.Error: /* Update the UI to show the connection has errored. Lobby will not attempt to reconnect as something has gone wrong. */
    }
}
```

### Apply changes to a lobby

When you subscribe to the **`LobbyEventCallbacks.LobbyChanged`** event, you receive **a set of changes** each time the lobby updates. It’s possible for a lobby to have **a large number of changes** at any given time, so the Lobby package includes a helper function to apply these changes to a lobby.

The following code snippet shows how to use the **`ApplyToLobby`** helper function to apply lobby changes:

```cs
private void OnLobbyChanged(ILobbyChanges changes)
{
    changes.ApplyToLobby(m_Lobby);
    // Refresh the UI in some way
}
```

Calling **`changes.ApplyToLobby`** updates all fields that have changed on a lobby in-place. When changes occur to a lobby in-place, the call modifies the values of the lobby object that were passed into the **`ApplyToLobby`** function. If you need to check whether a specific change was applied, check the **`ChangedLobbyValue`** members on the **`ILobbyChanges`** interface.

```cs
private void OnLobbyChanged(ILobbyChanges changes)
{
    changes.ApplyToLobby(m_Lobby);
    if (changes.Name.Changed)
    {
        // Do something specific due to this change
    }
    // Refresh the UI in some way
}
```

### Lobby versions

Lobby versions are useful for checking if a newly fetched lobby has changed since the last observed lobby. Every lobby exposes a **`Version`** property. **Versions start at 1 and are incremented every time member**-**observable player/lobby state is changed**.

If the version associated with a new set of lobby changes is not exactly one greater than the last observed lobby version, an update has been received out of order or lost. If you have a missing message, perform a get to retrieve the latest version.

The **`GetLobby`** API can optionally accept the version of the lobby as an argument. To save bandwidth, a lobby is only returned if the specified version doesn’t match the current version.

```cs
var lobby = await Lobbies.Instance.GetLobbyAsync("lobbyId");
var version = lobby.Version;

// check if a newer version of the lobby is available:
var newLobby = await Lobbies.Instance.GetLobbyAsync("lobbyId", version);
if (newLobby != null)
{
    // New lobby version received
    version = lobby.Version;
    // observe changed values in newLobby:

}

```

### OnLobbyEventConnectionStateChanged

The connection status for the Lobby Events indicates whether or not you will be receiving events.

The following are the connection statuses:

**Unsubscribed**

-   You have chosen to unsubscribe using `ILobbyEvents.UnsubscribeAsync`
-   You will not receive lobby events anymore.

**Subscribing**

-   The Lobby Events is trying to connect.
-   You will not receive lobby events.

**Subscribed**

-   The Lobby Events connects successfully.
-   You will receive lobby events.

**Unsynced**

-   There is a temporary problem with the connection.
-   Lobby Events will automatically try to reconnect.
-   You will not receive lobby events.

**Error**

-   There is an unrecoverable problem with the connection.
-   This might indicate a larger issue, such as an internet outage. A solution will require manual intervention and you might have to subscribe again.
-   You will not receive lobby events.
-   





### ref 
https://docs.unity.com/lobby/en-us/manual/lobby-events
