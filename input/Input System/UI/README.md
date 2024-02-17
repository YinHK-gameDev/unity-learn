## UI with Input System


### Default UI Action Map

![](../img/UI_ActionMap.png)


### On-screen Controls
You can use **on-screen Controls** to **simulate Input Devices with UI widgets** that the user interacts with on the screen. The most prominent example is the use of **stick** and **button widgets** on **touchscreens to emulate a joystick or gamepad**.

> There are currently two Control types implemented out of the box: **buttons** and **sticks**.

> You can implement custom Controls by extending the base **`OnScreenControl`** class (see documentation on **writing custom on screen Controls** to learn more).


> **Note**: **On-screen Controls** don't have a predefined visual representation. It's up to you to set up the visual aspect of a Control (for example, by adding a sprite or UI component to the GameObject). On-screen Controls take care of the interaction logic and of setting up and generating input from interactions.


To **query the Control** (and, implicitly, the Device) that an on-screen Control feeds into, you can use the **`OnScreenControl.control`** property.

> Note: This design allows you to use on-screen Controls to create input for arbitrary Input Devices, in addition to joysticks and gamepads.

#### On-screen buttons

![](../img/OnScreenButton.png)

To create an on-screen button:

1. Add a **UI Button** object.
2. Add the **`OnScreenButton` component** to it
3. Set the **Control Path** to refer to a **ButtonControl** type. The type of device referenced by the control path determines the type of virtual device created by the component.

> The `OnScreenButton` component requires the **target Control to be a Button Control**. `OnScreenButton` sets the **target Control value to 1** when it **receives a pointer-down**(**`IPointerDownHandler.OnPointerDown`**) event, or **0** when it **receives a pointer-up** (**`IPointerUpHandler.OnPointerUp`**) event.



#### On-screen sticks

![](../img/OnScreenStick.png)

To create an on-screen stick:

1. Create a **UI Image** object.
2. Add the **`OnScreenStick` component** to it.
3. Set the **Control Path** to refer to a **`Vector2Control`**. The type of device referenced by the control path determines the type of virtual device created by the component.

> The `OnScreenStick` component requires the **target Control to be a Vector2 Control**. `OnScreenStick` starts the movement of the stick Control when it **receives a pointer-down** (**`IPointerDownHandler.OnPointerDown`**) event, and stops it when it **receives a pointer-up** (**`IPointerUpHandler.OnPointerUp`**) event.

In-between, the stick moves according to the pointer being dragged (`IDragHandler.OnDrag`) within a box centered on the pointer-down screen point, and with an edge length defined in the component's Movement Range property. A movement range of 50, for example, means that the stick's on-screen area is 25 pixels up, down, left, and right of the pointer-down point on screen.

#### Writing custom on-screen Controls
You can add support for new types of Input Controls by **extending `OnScreenControl`**. An easy example to follow is **`OnScreenButton`**.

Eg:
```cs
 [AddComponentMenu("Input/On-Screen Button")]
    public class OnScreenButton : OnScreenControl, IPointerDownHandler, IPointerUpHandler
    {
        public void OnPointerUp(PointerEventData data)
        {
            SendValueToControl(0.0f);
        }

        public void OnPointerDown(PointerEventData data)
        {
            SendValueToControl(1.0f);
        }

        [InputControl(layout = "Button")]
        [SerializeField]
        private string m_ControlPath;

        protected override string controlPathInternal
        {
            get => m_ControlPath;
            set => m_ControlPath = value;
        }
    }
```

### ref 
https://docs.unity3d.com/Packages/com.unity.inputsystem@1.8/manual/UISupport.html

Working with UI and New Input System in Unity \
https://www.youtube.com/watch?v=KH0KrAFNR_M

**`UnityEngine.InputSystem.OnScreen`** \
https://docs.unity3d.com/Packages/com.unity.inputsystem@1.7/api/UnityEngine.InputSystem.OnScreen.html


