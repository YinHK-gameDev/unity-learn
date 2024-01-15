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



