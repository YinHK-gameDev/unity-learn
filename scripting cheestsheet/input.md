## Player input

> **Note**: input must call the input’s methods in **`update`** function.


https://docs.unity3d.com/ScriptReference/Input.html


### `Input.GetAxis( string axisName )`
**Returns the value** of the **virtual axis** identified by **axisName**.

The value will be in the range **`-1...1`** for keyboard and joystick input devices. Return value between **`-1...1`**.

The meaning of this value depends on the type of input control, for example with a joystick's horizontal axis a value of 1 means the stick is pushed all the way to the right and a value of -1 means it's all the way to the left; a value of 0 means the joystick is in its neutral position.

If the axis is mapped to the mouse, the value is different and** will not be in the range of -1...1**. Instead it'll be the current **mouse delta** multiplied by the **axis sensitivity**. Typically a **positive value means the mouse is moving right/down** and a **negative value means the mouse is moving left/up**.


This is frame-rate independent; you do not need to be concerned about varying frame-rates when using this value.  
  
To **set up your input** or **view the options** for **`axisName`**, go to **Edit** > **Project Settings** > **Input Manager**. This brings up the Input Manager. Expand **Axis** to see the list of your current inputs. You can use one of these as the `axisName`. To rename the input or change the positive button etc., expand one of the options, and change the name in the **Name** field or **Positive Button** field. Also, change the **Type** to **Joystick Axis**. To add a new input, add 1 to the number in the **Size** field.

- `Input.GetAxis("Vertical")` get the vertical axis. By default map to the arrow key up and down
- `Input.GetAxis("Horizontal")` get the horizontal axis. By default map to the arrow keyleft and right

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


- `Input.GetAxis("Mouse X")` get the horizontal movement of mouse
- `Input.GetAxis("Mouse Y")` get the vertical movement of mouse

https://docs.unity3d.com/ScriptReference/Input.GetAxis.html


### `Input.GetButtonDown`
Refers to any button on a physical controller

Returns true during the frame the user pressed down the **virtual button** identified by **`buttonName`**.

```
public static bool GetButtonDown(string buttonName);
```

Call this function from the **`Update`** function, since the state **gets reset each frame**. It **will not return true until the user has released the key and pressed it again**.

To edit, set up, or remove buttons and their names (such as "Fire1"): 1. Go to **Edit > Project Settings > Input Manager** to bring up the Input Manager. 2. Expand Axis by clicking the arrow next to it. This shows the list of the current buttons you have. You can use one of these as the parameter "buttonName". 3. Expand one of the items in the list to access and change aspects such as the button's name and the key, joystick or mouse movement that triggers it. 

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

#### Example: Set up joystick button A for the Jump action

1.  Go to **Edit** > **Project Settings**.
2.  Select the **Input Manager** category.
3.  Open the **Jump** action.
4.  Set **Positive Button** to **joystick button 14**.

```cs
using UnityEngine;

public class Jumping : MonoBehaviour
{
    Rigidbody2D rb;
    float jumpForce = 100f;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            rb.AddForce(new Vector2(0f, jumpForce));
        }
    }
}
```

#### Example: Set up joystick button X for the Fire action

1.  Go to **Edit** > **Project Settings**.
2.  Select the **Input Manager** category.
3.  Open the **Fire1** action.
4.  Set **Positive Button** to **joystick button 15**.

```cs
using UnityEngine;
 
public class Shooting : MonoBehaviour
{
    float bulletSpeed = 500f;
    public Transform gun;
    public Rigidbody2D bullet;
 
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            var bulletInstance = Instantiate(bullet, gun.position, gun.rotation);
            bulletInstance.AddForce(gun.up * bulletSpeed);
        }
    }
}
```

https://docs.unity3d.com/ScriptReference/Input.GetButtonDown.html \
https://docs.unity3d.com/Manual/ios-handle-game-controller-input.html

### Game Controller input mapping

You can map controller input in the Unity Input settings using the following:

  
| **Name** | **KeyCode** | **Axis** |
| --- | --- | --- |
| `A` | joystick button 14 | joystick axis 14 |
| `B` | joystick button 13 | joystick axis 13 |
| `X` | joystick button 15 | joystick axis 15 |
| `Y` | joystick button 12 | joystick axis 12 |
| `Left Stick` | N/A | Axis 1 (X) - Horizontal, Axis 2 (Y) - Vertical |
| `Right Stick` | N/A | Axis 3 - Horizontal, Axis 4 - Vertical |
| `D-pad Up` | joystick button 4 | Basic profile only: Axis 2 (Y) |
| `D-pad Right` | joystick button 5 | Basic profile only: Axis 1 (X) |
| `D-pad Down` | joystick button 6 | Basic profile only: Axis 2 (Y) |
| `D-pad Left` | joystick button 7 | Basic profile only: Axis 1 (X) |
| `Pause` | joystick button 0 | N/A |
| `L1/R1` | joystick button 8 / joystick button 9 | joystick axis 8 / joystick axis 9 |
| `L2/R2` | joystick button 10 / joystick button 11 | joystick axis 10 / joystick axis 11 |

### `Input.GetKeyDown`

Returns true during the frame the user starts pressing down the key identified by name.

```
public static bool GetKeyDown(string name);
```

Returns true during the frame the user starts pressing down the key identified by the key KeyCode enum parameter.

```
public static bool GetKeyDown(KeyCode key);
```

Call this function from the Update function, since the state gets reset each frame. It will not return true until the user has released the key and pressed it again.


https://docs.unity3d.com/ScriptReference/Input.GetKeyDown.html


### keycode

https://docs.unity3d.com/ScriptReference/KeyCode.html


### `Input.GetMouseButtonDown`
Returns true during the frame the user pressed the given mouse button.

```
public static bool GetMouseButtonDown(int button);
```
Call this function from the Update function, since the state gets reset each frame. It will not return true until the user has released the mouse button and pressed it again. button values are 0 for left button, 1 for right button, 2 for the middle button.

```cs
using UnityEngine;
using System.Collections;

// Detects clicks from the mouse and prints a message
// depending on the click detected.

public class ExampleClass : MonoBehaviour
{
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
            Debug.Log("Pressed left-click.");

        if (Input.GetMouseButtonDown(1))
            Debug.Log("Pressed right-click.");

        if (Input.GetMouseButtonDown(2))
            Debug.Log("Pressed middle-click.");
    }
}
```


https://docs.unity3d.com/ScriptReference/Input.GetMouseButtonDown.html


### `Input.mouseScrollDelta`
The current mouse **scroll delta**. (**Read Only**)

```
public static Vector2 mouseScrollDelta;
```

`Input.mouseScrollDelta` is stored in a Vector2.y property. (The Vector2.x value is ignored.) `Input.mouseScrollDelta` can be positive (up) or negative (down). The value is zero when the mouse scroll is not rotated.

https://docs.unity3d.com/ScriptReference/Input-mouseScrollDelta.html

### `Input.mousePosition`
The current **mouse position in pixel coordinates**. (**Read Only**).

```
public static Vector3 mousePosition;
```

> **`Input.mousePosition`** is a Vector3 for compatibility with functions that have Vector3 arguments. The z component of the Vector3 is always 0. The bottom-left of the screen or window is at (0, 0). The top-right of the screen or window is at (Screen.width, Screen.height).

https://docs.unity3d.com/ScriptReference/Input-mousePosition.html

### `Input.GetTouch`
**`Input.GetTouch`** returns Touch for a selected screen touch (for example, from a finger or stylus). Touch describes the screen touch. The index argument selects the screen touch.


iOS and Android devices are capable of tracking multiple fingers touching the screen simultaneously. You can access data on the status of each finger touching screen during the last frame by using the `Input.touches` property array.

Call **`Input.GetTouch`** to obtain a Touch struct.

**`Input.GetTouch`** **returns Touch for a selected screen touch** (for example, from a finger or stylus). Touch describes the screen touch. The index argument selects the screen touch.

**`Input.touchCount`** provides the **current number of screen touches**. If `Input.touchCount` is greater than zero, the GetTouch index sets which screen touch to check. Touch returns a struct with the screen touch details. Each extra screen touch uses an increasing `Input.touchCount`.

GetTouch returns a Touch struct. **Use zero to obtain the first screen touch**. As an example, Touch includes position in pixels.

```cs
public static Touch GetTouch(int index);
```

https://docs.unity3d.com/ScriptReference/Input.GetTouch.html

#### `Input.Touch` struct
Structure describing the status of a finger touching the screen.


https://docs.unity3d.com/ScriptReference/Touch.html


### "Up", "Down" vs without "Down" or "Up"
`GetXXXDown` vs `GetXXX` vs `GetXXXUp` difference:

- `GetXXX`  will return value if user **"hold down"** input, only stop returning value when user release.
- `GetXXXDown` only return value if user **hit/press down**, even user hold down it won't return value anymore. Unless user release it and **hit/press down** again. **will not return anything until the user has released and pressed it again**
- `GetXXXUp` only return value if user **release**. 


|**Static Properties**|**Description**|
| --- | --- |
| `acceleration` | Last measured linear acceleration of a device in three-dimensional space. (Read Only) |
| `accelerationEventCount` | Number of acceleration measurements which occurred during last frame. |
| `accelerationEvents` | Returns list of acceleration measurements which occurred during the last frame. (Read Only) (Allocates temporary variables). |
| `anyKey` | Is any key or mouse button currently held down? (Read Only) |
| `anyKeyDown` | Returns true the first frame the user hits any key or mouse button. (Read Only) |
| `backButtonLeavesApp` | Should Back button quit the application?Only usable on Android, Windows Phone or Windows Tablets. |
| `compass` | Property for accessing compass (handheld devices only). (Read Only) |
| `compensateSensors` | This property controls if input sensors should be compensated for screen orientation. |
| `compositionCursorPos` | The current text input position used by IMEs to open windows. |
| `compositionString` | The current IME composition string being typed by the user. |
| `deviceOrientation` | Device physical orientation as reported by OS. (Read Only) |
| `gyro` | Returns default gyroscope. |
| `imeCompositionMode` | Controls enabling and disabling of IME input composition. |
| `imeIsSelected` | Does the user have an IME keyboard input source selected? |
| `inputString` | Returns the keyboard input entered this frame. (Read Only) |
| `location` | Property for accessing device location (handheld devices only). (Read Only) |
| `mousePosition` | The current mouse position in pixel coordinates. (Read Only). |
| `mousePresent` | Indicates if a mouse device is detected. |
| `mouseScrollDelta` | The current mouse scroll delta. (Read Only) |
| `multiTouchEnabled` | Property indicating whether the system handles multiple touches. |
| `penEventCount` | Returns the number of queued pen events that can be accessed by calling [[GetPenEvent()]]. |
| `simulateMouseWithTouches` | Enables/Disables mouse simulation with touches. By default this option is enabled. |
| `stylusTouchSupported` | Returns true when Stylus Touch is supported by a device or platform. |
| `touchCount` | Number of touches. Guaranteed not to change throughout the frame. (Read Only) |
| `touches` | Returns list of objects representing status of all touches during last frame. (Read Only) (Allocates temporary variables). |
| `touchPressureSupported` | Bool value which let's users check if touch pressure is supported. |
| `touchSupported` | Returns whether the device on which application is currently running supports touch input. |


|**Static Methods**|**Description**|
| --- | --- |
| `ClearLastPenContactEvent` | Clears the last stored pen event. Calling this function may impact event handling for UIToolKit elements. |
| `GetAccelerationEvent` | Returns specific acceleration measurement which occurred during last frame. (Does not allocate temporary variables). |
| `GetAxis` | Returns the value of the virtual axis identified by axisName. |
| `GetAxisRaw` | Returns the value of the virtual axis identified by axisName with no smoothing filtering applied. |
| `GetButton` | Returns true while the virtual button identified by buttonName is held down. |
| `GetButtonDown` | Returns true during the frame the user pressed down the virtual button identified by buttonName. |
| `GetButtonUp` | Returns true the first frame the user releases the virtual button identified by buttonName. |
| `GetJoystickNames` | Retrieves a list of input device names corresponding to the index of an Axis configured within Input Manager. |
| `GetKey` | Returns true while the user holds down the key identified by name. |
| `GetKeyDown` | Returns true during the frame the user starts pressing down the key identified by name. |
| `GetKeyUp` | Returns true during the frame the user releases the key identified by name. |
| `GetLastPenContactEvent` | Returns the PenData for the last stored pen up or down event. |
| `GetMouseButton` | Returns whether the given mouse button is held down. |
| `GetMouseButtonDown` | Returns true during the frame the user pressed the given mouse button. |
| `GetMouseButtonUp` | Returns true during the frame the user releases the given mouse button. |
| `GetPenEvent` | Returns the PenData for the pen event at the given index in the pen event queue. |
| `GetTouch` | Call Input.GetTouch to obtain a Touch struct. |
| `IsJoystickPreconfigured` | Determine whether a particular joystick model has been preconfigured by Unity. (Linux-only). |
| `ResetInputAxes` | Resets all input. After ResetInputAxes all axes return to 0 and all buttons return to 0 for one frame. |
| `ResetPenEvents` | Clears the pen event queue. |


