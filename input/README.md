## Input

### Input Manager
The Input Manager window allows you to define input axes and their associated actions for your Project. To access it, from Unity’s main menu, go to **Edit > Project Settings**, then select Input Manager from the navigation on the right. \
The Input Manager is part of the core Unity platform and is the **default**.

The Input Manager uses the following types of controls:

- **Key** refers to **any key on a physical keyboard**, such as W, Shift, or the space bar. The Physical keys option allows you to map key codes to the physical keyboard layout, rather than to the language-specific layout that may vary between users in different regions.
- **Button** refers to **any button on a physical controller** (for example, gamepads), such as the X button on a remote control.
- A **virtual axis** is **mapped to a control**, such as a **button or a key**. When the user activates the control, the axis receives a value in the range of **`[–1..1]`**. You can **use this value in your scripts**. Every Project you create has a number of input axes created by default. These axes enable you to use keyboard, mouse, and joystick input in your Project straight away.


### Virtual axes
Every Project you create has a number of input axes created by default. These axes enable you to use **keyboard, mouse, and joystick input** in your Project straight away.

To see more about these axes, open the **Input Manager** window, and click the arrow next to any axis name to expand its properties.

Each input axis has the following properties:

| Property | Function |
| --- | --- |
| Name | Axis name. You can use this to access the axis from scripts. |
| Descriptive Name, Descriptive Negative Name | These values are deprecated and do not work. Previously, they displayed for the user on the Rebind Controls screen at startup, but this screen has also been deprecated. |
| Negative Button, Positive Button | The controls to push the axis in the negative and positive direction respectively. These can be keys on a keyboard, or buttons on a joystick or mouse. |
| Alt Negative Button, Alt Positive Button | Alternative controls to push the axis in the negative and positive direction respectively. |
| Gravity | Speed in units per second that the axis falls toward neutral when no input is present. |
| Dead | How far the user needs to move an analog stick before your application registers the movement. At runtime, input from all analog devices that falls within this range will be considered null. |
| Sensitivity | Speed in units per second that the axis will move toward the target value. This is for digital devices only. |
| Snap | If enabled, the axis value will reset to zero when pressing a button that corresponds to the opposite direction. |
| Type | The type of input that controls the axis. Select from these values:- Key or Mouse button- Mouse Movement- Joystick Axis |
| Axis | The axis of a connected device that controls this axis. |
| JoyNum | The connected Joystic |

Axis values can be:

-   **Between –1 and 1 for joystick and keyboard input**. The neutral position for these axes is 0. Some types of controls, such as buttons on a keyboard, aren’t sensitive to input intensity, so they can’t produce values other than –1, 0, or 1.
-   Mouse delta (how much the mouse has moved during the last frame) for mouse input. The values for mouse input axes can be **larger than 1 or smaller than –1** when the user moves the mouse quickly.


> To set up your input or view the options for `axisName`, go to **Edit** > **Project Settings** > **Input Manager**. This brings up the Input Manager. Expand **Axis** to see the list of your current inputs. You can use one of these as the `axisName`. To rename the input or change the positive button etc., expand one of the options


### Adding, removing, and copying virtual axes

1. To **add a virtual axis**, increase the number in the **Size** field. This creates a new axis at the bottom of the list. The **new axis copies the properties of the previous axis in the list**.

2. To **remove a virtual axis**, you can either:

   -   Decrease the number in the **Size** field. This removes the last axis in the list.
   -   Right-click any axis, and select **Delete Array Element**.  
    **Note:** You can’t undo this action.

3. To **copy a virtual axis**, right-click it and select **Duplicate Array Element**.
4. To **reset a virtual axis to default**, click reset icon in the top right corner.

### Mapping virtual axes to controls

To map a key or button to an axis, enter its name in the **Positive Button** or **Negative Button** property in the Input Manager.

Key names follow these naming conventions:

 
| **Key family** | **Naming convention** |
| --- | --- |
| Letter keys | `a`, `b`, `c`… |
| Number keys | `1`, `2`, `3`… |
| Arrow keys | `up`, `down`, `left`, `right` |
| Numpad keys | `[1]`, `[2]`, `[3]`, `[+]`, `[equals]`… |
| Modifier keys | `right shift`, `left shift`, `right ctrl`, `left ctrl`, `right alt`, `left alt`, `right cmd`, `left cmd` |
| Special keys | `backspace`, `tab`, `return`, `escape`, `space`, `delete`, `enter`, `insert`, `home`, `end`, `page up`, `page down` |
| Function keys | `f1`, `f2`, `f3`… |

Mouse buttons are named `mouse 0, mouse 1, mouse 2,` and so on.

Joystick buttons follow these naming conventions:

 
| **Button origin** | **Naming convention** |
| --- | --- |
| A specific button on any joystick | `joystick button 0`, `joystick button 1`, `joystick button 2`… |
| A specific button on a specific joystick | `joystick 1 button 0`, `joystick 1 button 1`, `joystick 2 button 0`… |

### Set up virtual button for game controller in Input Manager Axes
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




https://docs.unity3d.com/Manual/class-InputManager.html

### Input class 
use this scripting api to access user input \
https://docs.unity3d.com/ScriptReference/Input.html

### ref 
https://www.youtube.com/watch?v=p-3S73MaDP8


