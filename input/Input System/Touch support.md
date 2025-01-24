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


### TouchScreen bindings

In Unity's **Input System**, the terms **Touch #0**, **Touch #1**, ..., **Touch #9** refer to individual touch inputs detected on a **touchscreen** device. Each "Touch #" represents a unique touch point, with **Touch #0** being the first detected touch, **Touch #1** being the second detected touch, and so on. These numbers are indexed in the order that the touches are recognized.

1.  **Touch #0**:
    
    -   The first finger to touch the screen.
    -   For example, if you place one finger on the screen, it is tracked as **Touch #0**.
2.  **Touch #1**:
    
    -   The second finger to touch the screen.
    -   If you place another finger while **Touch #0** is still active, it will be tracked as **Touch #1**.
3.  **Touch #2** to **Touch #9**:
    
    -   Subsequent touches are tracked in the order they occur.
    -   Modern mobile devices support up to 10 simultaneous touches (though some devices may support fewer).
4.  **Touch Released**:
    
    -   If a finger (e.g., **Touch #0**) is lifted off the screen, its index becomes available for reuse.
    -   If another finger touches the screen, it will take the lowest available index.

**Multi touch Purpose**:

-   Used for multi-touch scenarios, such as pinch-to-zoom, two-finger rotation, or multi-finger gestures.
-   Each touch index provides its own independent data (e.g., position, delta, phase).


**Primary Touch**

1.  **Definition**:
    
    -   The **primary touch** is a special concept used in Unity's **Input System** to represent the most "important" touch at any given time.
    -   It generally corresponds to **Touch #0**, the first touch detected on the screen.
2.  **Purpose**:
    
    -   The **primary touch** simplifies handling single-touch interactions.
    -   It is a convenient abstraction for use cases where only one touch input is needed (e.g., tapping, dragging).




-   **Single Touch**: If one finger is used, only **Touch #0** will be active.
-   **Two-Finger Gestures (e.g., Pinch-to-Zoom)**: Both **Touch #0** and **Touch #1** are tracked simultaneously.
-   **Multi-Touch Games**: Games that require multi-finger input (e.g., piano apps) may use **Touch #0** through **Touch #9**, depending on the number of simultaneous touches.


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


