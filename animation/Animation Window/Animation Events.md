## Animation Events

Use **Animation Events** to **call functions** at **specific points** in the timeline. 
These functions can be in **any script attached to the GameObject**.

The function called by an Animation Event also has the option to **take one parameter**. The parameter can be a **`float`**, **`string`**, **`int`**, or **`object`** reference, or an **AnimationEvent** object. The **AnimationEvent** object has member variables that allow a **`float`**, **`string`**, **`integer`** and **`object`** reference to be passed into the function all at once, along with other information about the Event that triggered the function call.


To add an **Animation Event** to a clip at the current playhead position, click the Event button. 
To add an **Animation event** to any point in the Animation, **double-click the Event line** at the point where you want the Event to be triggered. 
**Once added**, you can **drag the mouse to reposition the Event**. To **delete an Event**, select it and press the **Delete** key, or right-click on it and select **Delete Event**.

![](./AnimationEditorEventLine.png)


When you add an Event, the Inspector
Window **displays several fields**. These fields allow you to **specify the name of the function** you want to call, and the **value of the parameter** you want to pass to it.


> Call the function which in **any script attached to the current animated GameObject**

![](./AnimationEventInspector.png)

You can select and manipulate multiple Events in the Event Line. To select multiple Events in the Event Line, hold the **Shift** key and click each Event marker one by one. To remove a marker from the selection, hold **Shift** and click a selected marker.

You can also use a selection box to select multiple Animation Events. To do this, click and drag within the Event Line

![](./AnimationEditorMultipleEventSelection.png)

To delete an Animation Event, select it and press the **Delete** key. You can also right-click the Animation Event and choose **Delete Event** from the context menu.


### ref 

https://docs.unity3d.com/Manual/script-AnimationWindowEvent.html


