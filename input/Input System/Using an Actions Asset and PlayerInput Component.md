## Using an Actions Asset and PlayerInput Component

The highest level of abstraction provided by the Input System is when you use the **Actions Asset** and 
the **Player Input component** together.

The **Player Input component** takes a **reference to an Actions Asset**, and 
**provides a way to make connections between the Actions defined in that asset**, and **C# methods in your own MonoBehaviour scripts**, 
so that your desired C# methods are called when the user performs an input action.



![](./img/PlayerInputWithGameplayEvents.png)

In the above example image, you can see the PlayerInput component set up to map the "move", "jump" actions to OnMove and OnJump methods in a script, via Unity Events.

This is an example of the script which would provide an implementation of these methods

```cs
using UnityEngine;
using UnityEngine.InputSystem;

// This script is designed to have the OnMove and
// OnJump methods called by a PlayerInput component

public class ExampleScript : MonoBehaviour
{
    Vector2 moveAmount;

    public void OnMove(InputAction.CallbackContext context)
    {
        // read the value for the "move" action each event call
        moveAmount = context.ReadValue<Vector2>();
    }

    public void OnJump(InputAction.CallbackContext context)
    {
        // your jump code goes here.
    }

    public void Update()
    {
        // to use the Vector2 value from the "move" action each
        // frame, use the "moveAmount" variable here.
    }

}

```


### ref
https://docs.unity3d.com/Packages/com.unity.inputsystem@1.7/manual/Workflow-PlayerInput.html \
https://docs.unity3d.com/Packages/com.unity.inputsystem@1.7/manual/PlayerInput.html



