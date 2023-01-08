## Event
A common way to compose a game scene in Unity is attaching one GameObject to another to share methods and properties. This practice causes a highly coupled architecture that is **hard to maintain**.

### Create Event Manager
In order to overcome these problems, just created a pure C# Event Manager to implement an event-driven architecture.
allow items in our projects to subscribe to events, and have events trigger actions in our games. This will reduce dependencies and allow easier maintenance of our projects.

https://learn.unity.com/tutorial/create-a-simple-messaging-system-with-events#

### How to set up
- create an empty Unity GameObject named **`XXXManager`** and attach the **`XXXManager.cs`** script to it.
