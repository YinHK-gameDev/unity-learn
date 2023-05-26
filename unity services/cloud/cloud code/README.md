## Cloud Code
A modern game requires a lot of components in order to be successful, such as an [in-game economy](https://docs.unity.com/economy), [storage for player data](https://docs.unity.com/cloud-save), and [dynamic settings configuration](https://docs.unity.com/remote-config/Content/WhatsRemoteConfig.htm). Using these components from a player device is not always preferable because it can lead to security issues and introduce unnecessary complexity. Sometimes, you need to isolate your game logic away from the client device, such as when:

-   You need to instantly update the game logic without requiring the player to update their installed version.
-   You want to prevent malicious users from altering the client code, changing their state, and cheating. You might also want to prevent users from reverse-engineering your game logic.
-   You want to use multiple online services without making the game feel sluggish or difficult to write on the game client as you integrate with more server-side components.

Typically, you create and maintain a game server that can handle these use cases. However, effectively managing, scaling, and upgrading backend infrastructure can require a lot of effort. You also need to manage the compatibility of many components, including:

-   Hardware
-   Server security
-   The game application programming interface (API)

By using Unity's Cloud Code to write stateless server-side code on a fully managed infrastructure, you can focus more on developing your game logic. Cloud Code automatically provisions server capacity based on load so you can ensure that your players receive a good experience without any lag or downtime. Cloud Code also ensures that you only pay for what you use because there are never any wasted resources when the game is not receiving traffic. In addition, because your code runs in a secure sandbox, you can protect your game logic from reverse engineering. Seamless integration with other Unity services allows you to write code that ties in multiple components without concern for authentication or compatibility. You can instantly deploy code to live games without rolling out a client update that would require users to update their installs.




### ref 
https://docs.unity.com/cloud-code/en/manual

Cloud code SDK Scripting API \
https://docs.unity.com/cloud-code/en/packages/com.unity.services.cloudcode/2.1/api/Unity.Services.CloudCode
