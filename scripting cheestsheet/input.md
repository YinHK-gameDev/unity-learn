## Player input

> input must call the input’s methods in **update** function.


https://docs.unity3d.com/ScriptReference/Input.html


### `Input.GetAxis( string axisName )`
Returns the value of the virtual axis identified by axisName.

The value will be in the range **-1...1** for keyboard and joystick input devices.

The meaning of this value depends on the type of input control, for example with a joystick's horizontal axis a value of 1 means the stick is pushed all the way to the right and a value of -1 means it's all the way to the left; a value of 0 means the joystick is in its neutral position.

This is frame-rate independent; you do not need to be concerned about varying frame-rates when using this value.  
  
To set up your input or view the options for `axisName`, go to **Edit** > **Project Settings** > **Input Manager**. This brings up the Input Manager. Expand **Axis** to see the list of your current inputs. You can use one of these as the `axisName`. To rename the input or change the positive button etc., expand one of the options, and change the name in the **Name** field or **Positive Button** field. Also, change the **Type** to **Joystick Axis**. To add a new input, add 1 to the number in the **Size** field.


https://docs.unity3d.com/ScriptReference/Input.GetAxis.html



### `Input.GetKeyDown`

Returns true during the frame the user starts pressing down the key identified by name.

https://docs.unity3d.com/ScriptReference/Input.GetKeyDown.html


### keycode

https://docs.unity3d.com/ScriptReference/KeyCode.html




