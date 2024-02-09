## Directly Reading Device States

This is the simplest and most direct workflow, but the least flexible. It’s useful if you want a quick implementation with one type of device. It might not be the best choice if you want to provide your users with multiple types of input or if you want to target multiple platforms.

Eg:
```cs
using UnityEngine;
using UnityEngine.InputSystem;
public class MyPlayerScript : MonoBehaviour
{
    void Update()
    {
        var gamepad = Gamepad.current;
        if (gamepad == null)
        {
            return; // No gamepad connected.
        }

        if (gamepad.rightTrigger.wasPressedThisFrame)
        {
            // 'Use' code here
        }

        Vector2 move = gamepad.leftStick.ReadValue();
        {
            // 'Move' code here
        }
    }
}
```

If you choose to use this technique:

- You won’t benefit from Unity’s management of actions and interactions.
- It is harder to make your game or app work with multiple types of input device.
- Your input bindings are hard-coded in your script, so any changes to bindings require changes to the code.
- It is harder to allow the user to remap their own controls to different actions at run time.





### ref 
https://docs.unity3d.com/Packages/com.unity.inputsystem@1.7/manual/Workflow-Direct.html


