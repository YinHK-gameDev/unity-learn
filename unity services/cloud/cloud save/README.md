## Cloud Save
Cloud Save is a set of calls that allows storage of JSON snippets for a player of a game within an environment. You can use Cloud Save from your project in the Unity Engine, assuming you have linked your project and installed the required Cloud Save SDK.

Before using Cloud Save, you must complete an authentication flow for your player using Unity Authentication.

You can use Unity's Cloud Save service to save persistent player data (such as game progress) from a game into the cloud, making it independent of device. Because it's cloud-based, players can access their data anywhere and across devices, mitigating data loss when a player changes devices or re-installs a game.

Player data is primarily suited for data tied to a specific player (such as save game states and player preferences) that other players won’t need to access.


### Cloud Code integration
Using Cloud Code together with Cloud Save provides a powerful way to incorporate server-side code to update the player's state or to perform actions based on the player’s state.

To integrate **Cloud Save through Cloud Code**, see the **Cloud Code Services SDK** documentation.



### ref

https://docs.unity.com/cloud-save/en/manual/implementation

https://unity.com/products/cloud-save

Cloud Save REST API \
https://services.docs.unity.com/cloud-save/v1/index.html

Cloud Save SDK Scripting API \
https://docs.unity.com/cloud-save/en/packages/com.unity.services.cloudsave/2.0/api/Unity.Services.CloudSave
