## Touch

Touch support is divided into:

- low-level support implemented in the **`Touchscreen`** class.
- high-level support implemented in the **`EnhancedTouch.Touch`** class.

> Touch input is supported on Android, iOS, Windows, and the Universal Windows Platform (UWP).

| Control | Type | Description |
| --- | --- | --- |
| `primaryTouch` | `TouchControl` | A touch Control that represents the primary touch of the screen. The primary touch drives the `Pointer` representation on the Device. |
| `touches` | `ReadOnlyArray<TouchControl>` | An array of touch Controls that represents all the touches on the Device. |


| Control | Type | Description |
| --- | --- | --- |
| `position` | `Vector2Control` | Absolute position on the touch surface. |
| `delta` | `Vector2Control` | The difference in `position` since the last frame. |
| `startPosition` | `Vector2Control` | The `position` where the finger first touched the surface. |
| `startTime` | `DoubleControl` | The time when the finger first touched the surface. |
|`press` | `ButtonControl` | Whether the finger is pressed down. |
|`pressure` | `AxisControl` | Normalized pressure with which the finger is currently pressed while in contact with the pointer surface. |
| `radius` | `Vector2Control` | The size of the area where the finger touches the surface. |
| `touchId` | `IntegerControl` | The ID of the touch. This allows you to distinguish individual touches. |
| `phase` | `TouchPhaseControl` | A Control that reports the current `TouchPhase` of the touch. |
| `tap` | `ButtonControl` | A button Control that reports whether the OS recognizes a tap gesture from this touch. |
| `tapCount` | `IntegerControl` | Reports the number of consecutive `tap` reports from the OS. You can use this to detect double- and multi-tap gestures. |

### Touch Simulation

Touch input can be simulated from **input** on other kinds of **Pointer devices** 
such as **Mouse** and **Pen devices**. \
To enable this, you can either add the 
**`TouchSimulation MonoBehaviour`** to a **`GameObject`** in your scene or 
simply call **`TouchSimulation.Enable`** somewhere in your **startup code**.


```cs
void OnEnable()
    {
        TouchSimulation.Enable();
    }
```

In the editor, you can also **enable touch simulation** by toggling **"Simulate Touch Input From Mouse or Pen"** on in the 
**"Options"** dropdown of the Input Debugger.

**TouchSimulation** will add a **Touchscreen device** and automatically mirror input on any **Pointer device** to the virtual 
touchscreen device.

### ref 
https://docs.unity3d.com/Packages/com.unity.inputsystem@1.12/manual/Touch.html#touchscreen-device


