## Event system
The **Event System** is a way of sending events to objects in the application based on **input, be it keyboard, mouse, touch, or custom input**. The Event System consists of a few components that work together to send events.

When you add an Event System component to a GameObject you will notice that it does not have much functionality exposed, this is because the Event System itself is designed as a manager and facilitator of communication between Event System modules.

The primary roles of the Event System are as follows:

-   Manage which GameObject is considered selected
-   Manage which Input Module is in use
-   Manage Raycasting (if required)
-   Updating all Input Modules as required


Unity’s EventSystem allows your UI to respond to events.

> An **EventSystem component** is automatically created alongside your UI and contains several Input Modules. These modules are responsible for deciding how GameObjects in your UI respond to input — if a corresponding GameObject within your UI contains the same Input Module as the one in your EventSystem, it can be interacted with.



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


### ref
https://docs.unity3d.com/Packages/com.unity.ugui@1.0/manual/EventSystem.html

**learn event system** \
https://learn.unity.com/tutorial/working-with-the-event-system#

**Event** \
https://learn.unity.com/tutorial/events-uh#5c894782edbc2a1410355442

https://www.youtube.com/watch?v=gx0Lt4tCDE0

https://www.youtube.com/watch?v=70PcP_uPuUc

https://www.youtube.com/watch?v=EvqdcyTgZNg

UnityEvents \
https://docs.unity3d.com/Manual/UnityEvents.html

https://docs.unity3d.com/ScriptReference/Events.UnityEvent.html

**`UnityEngine.EventSystems`** \
https://docs.unity3d.com/Packages/com.unity.ugui@1.0/api/UnityEngine.EventSystems.html

**`UnityEditor.EventSystems`** \
https://docs.unity3d.com/Packages/com.unity.ugui@1.0/api/UnityEditor.EventSystems.html

https://docs.unity3d.com/Packages/com.unity.ugui@1.0/manual/SupportedEvents.html

https://docs.unity3d.com/Packages/com.unity.ugui@1.0/manual/Raycasters.html
