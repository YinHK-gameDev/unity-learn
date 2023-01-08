## UnityEvents

### Using UnityEvents
To configure a callback in the editor there are a few steps to take:

- Make sure your script **`imports/uses UnityEngine.Event`**.

- Select the **`+`** icon to add a slot for a callback

- Select the UnityEngine.Object you wish to receive the callback (You can use the object selector for this)

- Select the function you wish to be called

- You can add more than one callback for the event

When configuring a UnityEvent in the Inspector there are two types of function calls that are supported:

- **Static**. Static calls are preconfigured calls, with preconfigured values that are set in the UI
. This means that when the callback is invoked, the target function is invoked with the argument that has been entered into the UI.
- **Dynamic**. Dynamic calls are invoked using an argument that is sent from code, and this is bound to the type of UnityEvent that is being invoked. The UI filters the callbacks and only shows the dynamic calls that are valid for the UnityEvent.

https://docs.unity3d.com/Manual/UnityEvents.html \
https://docs.unity3d.com/ScriptReference/Events.UnityEvent.html \
https://www.youtube.com/watch?v=oc3sQamIh-Q \

https://www.youtube.com/watch?v=AGGmnVIhHvc



### Events & Delegates
https://gamedevbeginner.com/events-and-delegates-in-unity/


