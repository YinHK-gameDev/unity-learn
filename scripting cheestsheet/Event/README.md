## Event
A common way to compose a game scene in Unity is attaching one GameObject to another to share methods and properties. This practice causes a highly coupled architecture that is **hard to maintain**.

### Create Event Manager
In order to overcome these problems, just created a pure C# Event Manager to implement an event-driven architecture.
allow items in our projects to subscribe to events, and have events trigger actions in our games. This will reduce dependencies and allow easier maintenance of our projects.


### How to set up
- create an empty Unity GameObject named **`XXXManager`**(Event Manager) and attach the **`XXXManager.cs`** script to it.
- include **`void StartListening`**, **`void StopListening`**, **`void TriggerEvent`** methods. 
- in **`void TriggerEvent`** , `Invoke()` to invoke the event.
- other game object, in its script subscribe and unscribe to the event listener.
- **`void OnEnable()`** to subcribe the event.
- **`void OnDisable()`** to unsubscribethe event. 


https://learn.unity.com/tutorial/create-a-simple-messaging-system-with-events#

### Events & Delegates
https://gamedevbeginner.com/events-and-delegates-in-unity/
