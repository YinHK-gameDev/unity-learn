## Player input

> **Note**: input must call the input’s methods in **update** function.


https://docs.unity3d.com/ScriptReference/Input.html


### `Input.GetAxis( string axisName )`
Returns the value of the **virtual axis** identified by axisName.

The value will be in the range **-1...1** for keyboard and joystick input devices.

The meaning of this value depends on the type of input control, for example with a joystick's horizontal axis a value of 1 means the stick is pushed all the way to the right and a value of -1 means it's all the way to the left; a value of 0 means the joystick is in its neutral position.

This is frame-rate independent; you do not need to be concerned about varying frame-rates when using this value.  
  
To set up your input or view the options for `axisName`, go to **Edit** > **Project Settings** > **Input Manager**. This brings up the Input Manager. Expand **Axis** to see the list of your current inputs. You can use one of these as the `axisName`. To rename the input or change the positive button etc., expand one of the options, and change the name in the **Name** field or **Positive Button** field. Also, change the **Type** to **Joystick Axis**. To add a new input, add 1 to the number in the **Size** field.


```cs
using UnityEngine;
using System.Collections;

// A very simplistic car driving on the x-z plane.

public class ExampleClass : MonoBehaviour
{
    public float speed = 10.0f;
    public float rotationSpeed = 100.0f;

    void Update()
    {
        // Get the horizontal and vertical axis.
        // By default they are mapped to the arrow keys.
        // The value is in the range -1 to 1
        float translation = Input.GetAxis("Vertical") * speed;
        float rotation = Input.GetAxis("Horizontal") * rotationSpeed;

        // Make it move 10 meters per second instead of 10 meters per frame...
        translation *= Time.deltaTime;
        rotation *= Time.deltaTime;

        // Move translation along the object's z-axis
        transform.Translate(0, 0, translation);

        // Rotate around our y-axis
        transform.Rotate(0, rotation, 0);
    }
}
```


https://docs.unity3d.com/ScriptReference/Input.GetAxis.html


### `Input.GetButtonDown`

Returns true during the frame the user pressed down the **virtual button** identified by `buttonName`.

Call this function from the Update function, since the state gets reset each frame. It will not return true until the user has released the key and pressed it again.

Use this only when implementing action **like events** eg: shooting a weapon.
Use `Input.GetAxis` for any kind of movement behaviour.


```cs
using UnityEngine;
using System.Collections;

public class ExampleClass : MonoBehaviour
{
    public GameObject projectile;
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
            Instantiate(projectile, transform.position, transform.rotation);
    }
}
```



https://docs.unity3d.com/ScriptReference/Input.GetButtonDown.html



### `Input.GetKeyDown`

Returns true during the frame the user starts pressing down the key identified by name.

https://docs.unity3d.com/ScriptReference/Input.GetKeyDown.html


### keycode

https://docs.unity3d.com/ScriptReference/KeyCode.html


### `Input.GetMouseButtonDown`
Returns true during the frame the user pressed the given mouse button.

https://docs.unity3d.com/ScriptReference/Input.GetMouseButtonDown.html


### `Input.mouseScrollDelta`
The current mouse scroll delta. (Read Only)

`Input.mouseScrollDelta` is stored in a Vector2.y property. (The Vector2.x value is ignored.) `Input.mouseScrollDelta` can be positive (up) or negative (down). The value is zero when the mouse scroll is not rotated.

https://docs.unity3d.com/ScriptReference/Input-mouseScrollDelta.html


### `Input.GetTouch`
Input.GetTouch returns Touch for a selected screen touch (for example, from a finger or stylus). Touch describes the screen touch. The index argument selects the screen touch.

https://docs.unity3d.com/ScriptReference/Input.GetTouch.html


|**Static Properties**|**Description**|
| --- | --- |
| acceleration | Last measured linear acceleration of a device in three-dimensional space. (Read Only) |
| accelerationEventCount | Number of acceleration measurements which occurred during last frame. |
| accelerationEvents | Returns list of acceleration measurements which occurred during the last frame. (Read Only) (Allocates temporary variables). |
| anyKey | Is any key or mouse button currently held down? (Read Only) |
| anyKeyDown | Returns true the first frame the user hits any key or mouse button. (Read Only) |
| backButtonLeavesApp | Should Back button quit the application?Only usable on Android, Windows Phone or Windows Tablets. |
| compass | Property for accessing compass (handheld devices only). (Read Only) |
| compensateSensors | This property controls if input sensors should be compensated for screen orientation. |
| compositionCursorPos | The current text input position used by IMEs to open windows. |
| compositionString | The current IME composition string being typed by the user. |
| deviceOrientation | Device physical orientation as reported by OS. (Read Only) |
| gyro | Returns default gyroscope. |
| imeCompositionMode | Controls enabling and disabling of IME input composition. |
| imeIsSelected | Does the user have an IME keyboard input source selected? |
| inputString | Returns the keyboard input entered this frame. (Read Only) |
| location | Property for accessing device location (handheld devices only). (Read Only) |
| mousePosition | The current mouse position in pixel coordinates. (Read Only). |
| mousePresent | Indicates if a mouse device is detected. |
| mouseScrollDelta | The current mouse scroll delta. (Read Only) |
| multiTouchEnabled | Property indicating whether the system handles multiple touches. |
| penEventCount | Returns the number of queued pen events that can be accessed by calling [[GetPenEvent()]]. |
| simulateMouseWithTouches | Enables/Disables mouse simulation with touches. By default this option is enabled. |
| stylusTouchSupported | Returns true when Stylus Touch is supported by a device or platform. |
| touchCount | Number of touches. Guaranteed not to change throughout the frame. (Read Only) |
| touches | Returns list of objects representing status of all touches during last frame. (Read Only) (Allocates temporary variables). |
| touchPressureSupported | Bool value which let's users check if touch pressure is supported. |
| touchSupported | Returns whether the device on which application is currently running supports touch input. |


|**Static Methods**|**Description**|
| --- | --- |
| ClearLastPenContactEvent | Clears the last stored pen event. Calling this function may impact event handling for UIToolKit elements. |
| GetAccelerationEvent | Returns specific acceleration measurement which occurred during last frame. (Does not allocate temporary variables). |
| GetAxis | Returns the value of the virtual axis identified by axisName. |
| GetAxisRaw | Returns the value of the virtual axis identified by axisName with no smoothing filtering applied. |
| GetButton | Returns true while the virtual button identified by buttonName is held down. |
| GetButtonDown | Returns true during the frame the user pressed down the virtual button identified by buttonName. |
| GetButtonUp | Returns true the first frame the user releases the virtual button identified by buttonName. |
| GetJoystickNames | Retrieves a list of input device names corresponding to the index of an Axis configured within Input Manager. |
| GetKey | Returns true while the user holds down the key identified by name. |
| GetKeyDown | Returns true during the frame the user starts pressing down the key identified by name. |
| GetKeyUp | Returns true during the frame the user releases the key identified by name. |
| GetLastPenContactEvent | Returns the PenData for the last stored pen up or down event. |
| GetMouseButton | Returns whether the given mouse button is held down. |
| GetMouseButtonDown | Returns true during the frame the user pressed the given mouse button. |
| GetMouseButtonUp | Returns true during the frame the user releases the given mouse button. |
| GetPenEvent | Returns the PenData for the pen event at the given index in the pen event queue. |
| GetTouch | Call Input.GetTouch to obtain a Touch struct. |
| IsJoystickPreconfigured | Determine whether a particular joystick model has been preconfigured by Unity. (Linux-only). |
| ResetInputAxes | Resets all input. After ResetInputAxes all axes return to 0 and all buttons return to 0 for one frame. |
| ResetPenEvents | Clears the pen event queue. |


