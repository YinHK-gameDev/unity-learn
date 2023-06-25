## Anonymous sign-in

Anonymous sign-in creates a new player for the game session without any input from the player. It's a quick way for a player to get started with your game.

If a session token is cached on the SDK, then the SignInAnonymouslyAsync() method recovers the existing credentials of the cached player, regardless whether they signed in anonymously or through a platform account. If there is no player sign-in information, this method creates a new anonymous player.

**Note**: The anonymous account is not recoverable if it’s not linked to a platform-specific account. For example, the player won’t be able to log in to their anonymous account if they uninstall and then reinstall the game.

The following code sample shows how to set up the ability for players to sign into your game anonymously and get an access token.

```cs
async Task SignInAnonymouslyAsync()
{
    try
    {
        await AuthenticationService.Instance.SignInAnonymouslyAsync();
        Debug.Log("Sign in anonymously succeeded!");
        
        // Shows how to get the playerID
        Debug.Log($"PlayerID: {AuthenticationService.Instance.PlayerId}"); 

    }
    catch (AuthenticationException ex)
    {
        // Compare error code to AuthenticationErrorCodes
        // Notify the player with the proper error message
        Debug.LogException(ex);
    }
    catch (RequestFailedException ex)
    {
        // Compare error code to CommonErrorCodes
        // Notify the player with the proper error message
        Debug.LogException(ex);
     }
}
```

### ref 
https://docs.unity.com/authentication/en-us/manual/use-anon-signin


