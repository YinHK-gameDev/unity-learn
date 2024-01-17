## Event system
The **Event System** is a way of **sending events** to objects in the application based on **input, be it keyboard, mouse, touch, or custom input**. The **Event System** consists of a few components that work together to send events.

When you add an **Event System component** to a GameObject you will notice that it does not have much functionality exposed, this is because the Event System itself is designed as a manager and facilitator of communication between **Event System** modules.

The primary roles of the **Event System** are as follows:

-   Manage which GameObject is **considered selected**
-   Manage which **Input Module** is in use
-   Manage **Raycasting** (if required)
-   **Updating all Input Modules** as required


Unity’s EventSystem allows your UI to respond to events.

> An **EventSystem component** is **automatically created alongside your UI** and **contains several Input Modules**. These modules are responsible for deciding how GameObjects in your UI respond to input — if a corresponding GameObject within your UI contains the same Input Module as the one in your EventSystem, it can be interacted with.



### Input Modules

An Input Module is where the main logic of how you want the Event System to behave lives, they are used for:

-   Handling Input
-   Managing event state
-   Sending events to scene objects.

Only one Input Module can be active in the Event System at a time, and they must be components on the same GameObject as the Event System component.

If you want to write a custom Input Module, send events supported by existing UI components in Unity.


### Raycasters

Raycasters are used for figuring out what the pointer is over. It is common for Input Modules to use the Raycasters configured in the Scene to calculate what the pointing device is over.

There are 3 provided Raycasters that exist by default:

- **Graphic Raycaster** - Used for UI elements
- **Physics 2D Raycaster** - Used for 2D physics elements
- **Physics Raycaster** - Used for 3D physics elements


### Event System Component
This subsystem is responsible for controlling all the other elements that make up eventing. It coordinates which Input Module is currently active, which GameObject is currently considered 'selected', and a host of other high level Event System concepts.

Each 'Update' the Event System receives the call, looks through its Input Modules and figures out which is the Input Module that should be used for this tick. It then delegates the processing to the modules.

Add **Event System** component to an UI gameobject.

![](./img/EventSystemManager.png)

#### Properties

| **_Property:_** | **_Function:_** |
| --- | --- |
| **First Selected** | The GameObject that was selected first. |
| **Send Navigation Events** | Should the EventSystem allow navigation events (move / submit / cancel). |
| **Drag Threshold** | The soft area for dragging in pixels. |



### ref
https://docs.unity3d.com/Packages/com.unity.ugui@1.0/manual/EventSystem.html

**learn event system** \
https://learn.unity.com/tutorial/working-with-the-event-system#

**`UnityEngine.EventSystems`** \
https://docs.unity3d.com/Packages/com.unity.ugui@1.0/api/UnityEngine.EventSystems.html

**`UnityEditor.EventSystems`** \
https://docs.unity3d.com/Packages/com.unity.ugui@1.0/api/UnityEditor.EventSystems.html

https://docs.unity3d.com/Packages/com.unity.ugui@1.0/manual/SupportedEvents.html

https://docs.unity3d.com/Packages/com.unity.ugui@1.0/manual/Raycasters.html

**Event System Reference** \
https://docs.unity3d.com/Packages/com.unity.ugui@1.0/manual/script-EventSystem.html

**Creating a Simple Messaging System** \
https://learn.unity.com/tutorial/create-a-simple-messaging-system-with-events#5cf5960fedbc2a281acd21fa
