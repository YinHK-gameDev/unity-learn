## Event system
The **Event System** is a way of **sending events to objects** in the application based on **input, be it keyboard, mouse, touch, or custom input**. 

**Objects receive these events based on on user input**.

To make objects interact with sending events based on input, use Event System.

The **Event System** consists of a **few components** that work together to send events.

> When you add an **Event System component** to a GameObject you will notice that it does not have much functionality exposed, this is because the Event System itself is designed as a **manager and facilitator** of communication between **Event System** modules.

The primary roles of the **Event System** are as follows:

-   Manage which GameObject is **considered selected**
-   Manage which **Input Module** is in use
-   Manage **Raycasting** (if required)
-   **Updating all Input Modules** as required


> **Unity’s Event System allows your UI to respond to events**.

> An **Event System component** is **automatically created alongside your UI** and **contains several Input Modules**. These modules are responsible for deciding how GameObjects in your UI respond to input — if a corresponding GameObject within your UI contains the same Input Module as the one in your EventSystem, it can be interacted with.

### Input Modules

An Input Module is where the main logic of how you want the Event System to behave lives, they are used for:

- **Handling Input**
- **Managing event state**
- **Sending events** to **scene objects**.

> **Note**: **Only one Input Module can be active in the Event System at a time**, and they **must be components on the same GameObject as the Event System component**.

If you want to write a **custom Input Module**, send events supported by existing UI components in Unity.

An Input Module is where the main logic of an event system can be configured and customized. Out of the box there are two provided Input Modules, one designed for Standalone, and one designed for Touch input. Each module receives and dispatches events as you would expect on the given configuration.

Input modules are where the 'business logic' of the Event System take place. When the Event System is enabled it looks at what Input Modules are attached and passes update handling to the specific module.

Input modules are designed to be extended or modified based on the input systems that you wish to support. Their purpose is to map hardware specific input (such as touch, joystick, mouse, motion controller) into events that are sent via the messaging system.

The built in Input Modules are designed to support common game configurations such as touch input, controller input, keyboard input, and mouse input. They send a variety of events to controls in the application, if you implement the specific interfaces on your MonoBehaviours. All of the UI components implement the interfaces that make sense for the given component.

#### Standalone Input Module

The module is designed to work as you would expect a **controller / mouse input to work**. Events for button presses, dragging, and similar are sent in response to input.

The module sends pointer events to components as a mouse / input device is moved around, and uses the Graphics Raycaster and Physics Raycaster to calculate which element is currently pointed at by a given pointer device. You can configure these raycasters to detect or ignore parts of your Scene, to suit your requirements.

The module sends move events and submit / cancel events in response to Input tracked via the Input window. This works for both keyboard and controller input. The tracked axis and keys can be configured in the module's inspector.


| **_Property:_** | **_Function:_** |
| --- | --- |
| **Horizontal Axis** | Type the desired manager name for the horizontal axis button. |
| **Vertical Axis** | Type the desired manager name for the vertical axis. |
| **Submit Button** | Type the desired manager name for the Submit button. |
| **Cancel Button** | Type the desired manager name for the Cancel button. |
| **Input Actions Per Second** | Number of keyboard/controller inputs allowed per second. |
| **Repeat Delay** | Delay in seconds before the input actions per second repeat rate takes effect. |
| **Force Module Active** | Enable this property to force this **Standalone Input Module** to be active. |

https://docs.unity3d.com/Packages/com.unity.ugui@2.0/manual/script-StandaloneInputModule.html

#### Input System UI Input Module

The **InputSystemUIInputModule** component acts as a drop-in replacement for the **StandaloneInputModule** component that the Unity UI package. InputSystemUIInputModule provides the same functionality as StandaloneInputModule, but it uses the Input System instead of the legacy Input Manager to drive UI input.

If you have a **StandaloneInputModule** component on a GameObject, and the Input System is installed, Unity shows a button in the Inspector offering to automatically replace it with a **InputSystemUIInputModule** for you. The **InputSystemUIInputModule** is pre-configured to use **default Input Actions** to drive the UI, but you can override that configuration to suit your needs.

https://docs.unity3d.com/Packages/com.unity.inputsystem@1.4/api/UnityEngine.InputSystem.UI.InputSystemUIInputModule.html

### Raycasters

**Raycasters** are used for figuring out **what the pointer is over**. It is common for Input Modules to **use the Raycasters configured in the Scene to calculate what the pointing device is over**.

The **Event System** needs a method for **detecting where current input events need to be sent to**, and this is provided by the **Raycasters**. Given a screen space position they will collect all potential targets, figure out if they are under the given position, and then **return the object that is closest to the screen**. 

#### When a Raycaster is Required:

1.  **UI Elements**:
    -   If your object is part of a **Canvas** (e.g., a button or panel), you need a **Graphic Raycaster** on the Canvas. This allows the Event System to detect pointer events, like clicks or hovers, on UI elements.
2.  **3D Objects**:
    -   If your object is a 3D GameObject in the scene (e.g., your chess pieces), you need a **Physics Raycaster** (or **Physics 2D Raycaster** for 2D physics) on the camera. This enables the Event System to detect pointer events on objects with colliders.


There are 3 provided Raycasters that exist by default:

- **Graphic Raycaster** - Used for **UI elements(uGUI)**.
- **Physics 2D Raycaster** - Used for **2D physics elements**.
- **Physics Raycaster** - Used for **3D physics elements**.

When a **Raycaster** is present and enabled in the scene it will be used by the **Event System** whenever a query is issued from an Input Module.

If multiple Raycasters are used then they will all have casting happen against them and the results will be sorted based on distance to the elements.


> **Note**: For 3D objects, the GameObject must have a **Collider** (e.g., `BoxCollider`, `SphereCollider`) for the Physics Raycaster to detect it.


#### Graphic Raycaster
The Graphic Raycaster is used to **raycast against a Canvas**. The Raycaster looks at all Graphics on the canvas and determines if any of them have been hit.

The Graphic Raycaster can be configured to ignore backfacing Graphics as well as be blocked by 2D or 3D objects that exist in front of it. A manual priority can also be applied if you want processing of this element to be forced to the front or back of the Raycasting.

> When a UI is created, a Graphic Raycaster is **automatically included within the Canvas**.

>  Used in **uGUI**

| **_Property:_** | **_Function:_** |
| --- | --- |
| **Ignore Reversed Graphics** | Should graphics facing away from the raycaster be considered? |
| **Blocked Objects** | Type of objects that will block graphic raycasts. |
| **Blocking Mask** | Type of objects that will block graphic raycasts. |

```cs
public override void Raycast(PointerEventData eventData, List<RaycastResult> resultAppendList)
```

Eg:
```cs
using System.Collections;
using System.Collections.Generic;
using UnityEngine; using UnityEngine.UI;
using UnityEngine.EventSystems;

public class UI_ColorPicker : MonoBehaviour
{
    public GameObject target;
    private Material targetMaterial;
    private GraphicRaycaster rc;
    private PointerEventData pt;
    private EventSystem eventSystem;

    void Start()
    {
        //Obtain the target object's material
        if(target != null)
        {
            targetMaterial = target.GetComponent<Renderer>().material;
        }
        //Obtain the Canvas' Raycaster and EventSystem Components
        rc = GetComponent<GraphicRaycaster>();
        eventSystem = GetComponent<EventSystem>();
    }

    void Update()
    {
        pt = new PointerEventData(eventSystem);
        pt.position = Input.mousePosition;
        List<RaycastResult> results = new List<RaycastResult>();
        rc.Raycast(pt, results);

        foreach(RaycastResult swatch in results)
        {
            if(swatch.gameObject.GetComponent<Image>().color != null)
            {
                changeColor(swatch.gameObject.GetComponent<Image>().color);
            }
        }
    }

    void changeColor(Color c)
    {
        targetMaterial.color = c;
    }
}

```

#### Physics Raycaster

The Raycaster raycasts against 3D objects in the scene. This allows messages to be sent to 3D physics objects that implement event interfaces.

| **_Property:_** | **_Function:_** |
| --- | --- |
| **Depth** | Get the depth of the configured camera. |
| **Event Camera** | Get the camera that is used for this module. |
| **Event Mask** | Logical and of Camera mask and eventMask. |
| **Final Event Mask** | Logical and of Camera mask and eventMask. |


```cs
public override void Raycast(PointerEventData eventData, List<RaycastResult> resultAppendList)
```

#### Physics 2D Raycaster
The 2D Raycaster raycasts against 2D objects in the scene. This allows messages to be sent to 2D physics objects that implement event interfaces. The **Camera GameObject needs to be used** and will be added to the GameObject if the **Physics 3D Raycaster is not added to the Camera GameObject**.

| **_Property:_** | **_Function:_** |
| --- | --- |
| **Event Camera** | The camera that will generate rays for this raycaster. |
| **Priority** | Priority of the caster relative to other casters. |
| **Sort Order Priority** | Priority of the raycaster based upon sort order. |
| **Render Order Priority** | Priority of the raycaster based upon render order. |

```cs
public override void Raycast(PointerEventData eventData, List<RaycastResult> resultAppendList)
```

### Event System Component
> An **EventSystem component** is automatically created **alongside your UI** and **contains several Input Modules**. 

This subsystem is responsible for controlling all the other elements that make up eventing. It coordinates which Input Module is currently active, which GameObject is currently considered **'selected'**, and a host of other high level Event System concepts.

Each **'Update'** the Event System receives the call, looks through its Input Modules and figures out which is the Input Module that should be used for this tick. It then delegates the processing to the modules.

Add **Event System** component to an UI gameobject.

![](./img/EventSystemManager.png)


> **Note**: For uGUI, add this component with standalone input module into Canvas

#### Properties

| **_Property:_** | **_Function:_** |
| --- | --- |
| **First Selected** | The GameObject that was selected first. |
| **Send Navigation Events** | Should the EventSystem allow navigation events (move / submit / cancel). |
| **Drag Threshold** | The soft area for dragging in pixels. |


### Events

#### Messaging System
The new UI system uses a messaging system designed to replace SendMessage. The system is pure C# and aims to address some of the issues present with SendMessage.

**Defining A Custom Message**

If you wish to define a custom message it is relatively simple. In the UnityEngine.EventSystems namespace there is a base interface called 'IEventSystemHandler'. Anything that extends from this can be considered as a target for receiving events via the messaging system.

```cs
public interface ICustomMessageTarget : IEventSystemHandler
{
    // functions that can be called via the messaging system
    void Message1();
    void Message2();
}
```

Once this interface is defined then it can be implemented by a MonoBehaviour. When implemented it defines the functions that will be executed if the given message is issued against this MonoBehaviours GameObject.

```cs
public class CustomMessageTarget : MonoBehaviour, ICustomMessageTarget
{
    public void Message1()
    {
        Debug.Log ("Message 1 received");
    }

    public void Message2()
    {
        Debug.Log ("Message 2 received");
    }
}
```

Now that a script exists that can receive the message we need to issue the message. Normally this would be in response to some loosely coupled event that occurs. For example, in the UI system we issue events for such things as PointerEnter and PointerExit, as well as a variety of other things that can happen in response to user input into the application.

To send a message a static helper class exists to do this. As arguments it requires a target object for the message, some user specific data, and a functor that maps to the specific function in the message interface you wish to target.

```cs
ExecuteEvents.Execute<ICustomMessageTarget>(target, null, (x,y)=>x.Message1());
```

This code will execute the function Message1 on any components on the GameObject target that implement the ICustomMessageTarget interface. The scripting documentation for the ExecuteEvents class covers other forms of the Execute functions, such as Executing in children or in parents.


#### Event Trigger

> Apart from the event in **`Unity​Engine.​UIElements`**, **`Unity​Engine.​UI`** & **`UnityEvent`**. The **Event Trigger** is used to **receives events** from the **Event System** and **calls registered functions** for each event.

The **Event Trigger** can be used to **specify functions you wish to be called** for each **Event System event**. You can **assign multiple functions to a single event** and whenever the **Event Trigger** receives that event it will call those functions.

![](./img/event_trigger.png)

![](./img/event_trigger_event.png)

![](./img/event_trigger_callback.png)

> **Note**: attaching an **Event Trigger component** to a **GameObject** (eg: **UI element in UItoolkit or UI component in uGUI**) will make that **object intercept all events**, and no event bubbling will occur from this object!


> **Note**: In Unity's Event System, an **Event Trigger** does not inherently require a **Raycaster** to function, but whether or not you need a **raycaster depends on the type of object you're interacting with**.

https://vasundhara.io/blogs/event-trigger-in-unity


#### Supported Events

The **Event System supports a number of events**, and they can be customized further in user custom user written Input Modules.

The events that are supported by the **Standalone Input Module** and **Touch Input Module** are provided by interface and can be implemented on a **`MonoBehaviour` by implementing the interface**. If you have a valid Event System configured the events will be called at the correct time.

These event interface can be used and implement in the script and use the event supported by event system without adding event trigger component.

-   `IPointerEnterHandler` - `OnPointerEnter` - Called when a pointer enters the object
-   `IPointerExitHandler` - `OnPointerExit` - Called when a pointer exits the object
-   `IPointerDownHandler` - `OnPointerDown` - Called when a pointer is pressed on the object
-   `IPointerUpHandler`- `OnPointerUp` - Called when a pointer is released (called on the GameObject that the pointer is clicking)
-   `IPointerClickHandler` - `OnPointerClick` - Called when a pointer is pressed and released on the same object
-  `IInitializePotentialDragHandle` - `OnInitializePotentialDrag` - Called when a drag target is found, can be used to initialize values
-   `IBeginDragHandler` - `OnBeginDrag` - Called on the drag object when dragging is about to begin
-   `IDragHandler` - `OnDrag` - Called on the drag object when a drag is happening
-   `IEndDragHandler` - `OnEndDrag` - Called on the drag object when a drag finishes
-   `IDropHandler` - `OnDrop` - Called on the object where a drag finishes
-   `IScrollHandler` - `OnScroll` - Called when a mouse wheel scrolls
-   `IUpdateSelectedHandler` - `OnUpdateSelected` - Called on the selected object each tick
-   `ISelectHandler` - `OnSelect` - Called when the object becomes the selected object
-   `IDeselectHandler` - `OnDeselect` - Called on the selected object becomes deselected
-   `IMoveHandler` - `OnMove` - Called when a move event occurs (left, right, up, down)
-   `ISubmitHandler` - `OnSubmit` - Called when the submit button is pressed
-   `ICancelHandler` - `OnCancel` - Called when the cancel button is pressed



> **Note**: Some interfaces need to be implemented in the script when using those events in the event system. However, the Event Trigger component in Unity is designed to provide a user-friendly way to handle various pointer and interaction events without needing to implement interfaces like **`IPointerEnterHandler`**, **`IPointerExitHandler`**, etc., in a script. Here's why Event Trigger works without implementing these interfaces.


### Physics Raycaster vs Event Trigger
#### **Physics Raycaster**

##### **Use Case:**

-   Detect interactions (e.g., hover, click) with 3D objects in the scene using a raycast from the camera.
-   Suitable for **dynamic objects** with colliders and physics-based interactions.

##### **Advantages:**

1.  **Centralized Logic**: All interactions can be managed in a single script, making it scalable for projects with many objects.
2.  **Dynamic Interaction**: Works well for objects that are instantiated, moved, or changed dynamically.
3.  **Flexible Control**: Offers complete programmatic control over hover, click, and other interactions.
4.  **Physics Integration**: Compatible with Unity's physics system, requiring colliders for interaction.

##### **Disadvantages:**

1.  **Requires Scripting**: You must write custom scripts to handle interactions.
2.  **Collider Dependency**: Each interactable object needs a collider, which can increase performance overhead if not optimized.
3.  **More Complex Setup**: Requires adding a Physics Raycaster to the camera and ensuring proper scene configuration.



#### **Event Trigger**

##### **Use Case:**

-   Detect pointer interactions (e.g., hover, click) using Unity's **Event System**.
-   Ideal for static or manually configured objects where interactions are simple.

##### **Advantages:**

1.  **Easy Setup**: Interaction logic is added via the Inspector without needing custom scripts for basic events.
2.  **Inspector-Based Control**: Drag-and-drop setup for adding and assigning pointer events (e.g., `PointerEnter`, `PointerClick`).
3.  **UI Integration**: Works seamlessly with Unity UI and Canvas elements.

##### **Disadvantages:**

1.  **Manual Assignment**: Each object requires its own Event Trigger component and event setup, making it less scalable.
2.  **Limited Flexibility**: Difficult to handle dynamic objects or customize interactions beyond predefined events.
3.  **Less Efficient for Large Scenes**: Becomes cumbersome and error-prone with many interactable objects.

| Feature | **Physics Raycaster** | **Event Trigger** |
| --- | --- | --- |
| **Setup** | Requires scripting and colliders | Add via Inspector, no scripting needed |
| **Scalability** | Suitable for many objects, centralized | Cumbersome for many objects |
| **Flexibility** | Highly flexible for dynamic objects | Limited to predefined events |
| **Dependency** | Needs Physics Raycaster + Colliders | Needs Unity Event System |
| **Ease of Use** | Requires coding | Simple drag-and-drop |
| **Best Use Case** | Dynamic 3D objects (e.g., chess pieces) | Static or UI elements |

#### **Recommendation**

-   Use **Physics Raycaster** if:
    
    -   You need centralized, scalable, and dynamic handling of interactions.
    -   You’re working with a 3D scene and are comfortable with scripting.
-   Use **Event Trigger** if:
    
    -   You prefer an Inspector-based workflow and are handling simple interactions on static objects or UI elements.
 

### ref
https://docs.unity3d.com/Packages/com.unity.ugui@2.0/manual/EventSystem.html

**learn event system** \
https://learn.unity.com/tutorial/working-with-the-event-system#

**Messaging System** \
https://docs.unity3d.com/Packages/com.unity.ugui@2.0/manual/MessagingSystem.html

**Input Modules** \
https://docs.unity3d.com/Packages/com.unity.ugui@2.0/manual/InputModules.html

**Standalone Input Module** \
https://docs.unity3d.com/Packages/com.unity.ugui@2.0/manual/script-StandaloneInputModule.html

**Touch Input Module** \
https://docs.unity3d.com/Packages/com.unity.ugui@2.0/manual/script-TouchInputModule.html

**Supported Events** \
https://docs.unity3d.com/Packages/com.unity.ugui@2.0/manual/SupportedEvents.html

**Raycasters** \
https://docs.unity3d.com/Packages/com.unity.ugui@2.0/manual/Raycasters.html

**RaycastResult Struct** \
https://docs.unity3d.com/Packages/com.unity.ugui@3.0/api/UnityEngine.EventSystems.RaycastResult.html#UnityEngine_EventSystems_RaycastResult_gameObject

**PointerEventData Class** \
https://docs.unity3d.com/Packages/com.unity.ugui@3.0/api/UnityEngine.EventSystems.PointerEventData.html

**Graphic Raycaster** \
https://docs.unity3d.com/Packages/com.unity.ugui@2.0/manual/script-GraphicRaycaster.html \
https://docs.unity3d.com/Packages/com.unity.ugui@2.0/api/UnityEngine.UI.GraphicRaycaster.html

**Physics Raycaster** \
https://docs.unity3d.com/Packages/com.unity.ugui@2.0/manual/script-PhysicsRaycaster.html \
https://docs.unity3d.com/Packages/com.unity.ugui@2.0/api/UnityEngine.EventSystems.PhysicsRaycaster.html

**Physics 2D Raycaster** \
https://docs.unity3d.com/Packages/com.unity.ugui@2.0/manual/script-Physics2DRaycaster.html \
https://docs.unity3d.com/Packages/com.unity.ugui@2.0/api/UnityEngine.EventSystems.Physics2DRaycaster.html

**Event Trigger** \
https://docs.unity3d.com/Packages/com.unity.ugui@2.0/manual/script-EventTrigger.html

**`UnityEngine.EventSystems`** \
https://docs.unity3d.com/Packages/com.unity.ugui@1.0/api/UnityEngine.EventSystems.html

**`UnityEngine.EventSystems.EventSystem`** \
https://docs.unity3d.com/Packages/com.unity.ugui@2.0/api/UnityEngine.EventSystems.EventSystem.html

**`UnityEditor.EventSystems`** \
https://docs.unity3d.com/Packages/com.unity.ugui@1.0/api/UnityEditor.EventSystems.html

https://docs.unity3d.com/Packages/com.unity.ugui@1.0/manual/SupportedEvents.html

https://docs.unity3d.com/Packages/com.unity.ugui@1.0/manual/Raycasters.html

**`UnityEngine.EventSystems.EventTrigger`** \
https://docs.unity3d.com/Packages/com.unity.ugui@2.0/api/UnityEngine.EventSystems.EventTrigger.html#constructors

**`UnityEngine.EventSystems.BaseEventData`** \
https://docs.unity3d.com/Packages/com.unity.ugui@2.0/api/UnityEngine.EventSystems.BaseEventData.html

**`UnityEngine.EventSystems.PointerEventData`** \
https://docs.unity3d.com/Packages/com.unity.ugui@2.0/api/UnityEngine.EventSystems.PointerEventData.html

**`UnityEngine.EventSystems.BaseInput`** \
https://docs.unity3d.com/Packages/com.unity.ugui@2.0/api/UnityEngine.EventSystems.BaseInput.html

**`UnityEngine.EventSystems.BaseRaycaster`** \
https://docs.unity3d.com/Packages/com.unity.ugui@2.0/api/UnityEngine.EventSystems.BaseRaycaster.html

**UI Reference** \
https://docs.unity3d.com/Packages/com.unity.ugui@2.0/manual/UIReference.html

**Event System Reference** \
https://docs.unity3d.com/Packages/com.unity.ugui@2.0/manual/EventSystemReference.html

**ULTIMATE Event System for Unity Beginners** \
https://www.youtube.com/watch?v=7_dyDmF0Ktw&t=1s
