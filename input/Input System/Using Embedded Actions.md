## Using Embedded Actions

You can use the InputAction class in your script to define actions in your script. This adds a layer of abstraction between your actual action code or methods, and the bindings to specific device controls.

This means that instead of directly reading device states, you do not specify explicitly which controls (such as a gamepad trigger or stick) should do what in your code. Instead you create Actions, bind them to controls, and respond to the states or values from your Actions in your code.

When you make a public InputAction field in a MonoBehaviour script, it displays in the inspector as a configurable field. The configurable field UI allows you to create a binding for the action. For example, here are two Actions defined using the InputAction class in a script:


```cs
using UnityEngine;
using UnityEngine.InputSystem;

public class ExampleScript : MonoBehaviour
{
    public InputAction move;
    public InputAction jump;
}
```

The InputAction class provides a way to bind interactions from a device’s controls to named actions in the inspector. When you bind actions to controls from a device in the inspector, you can then design your script to respond when the actions are performed without hard-coding references to specific devices in your script. This layer of abstraction provides you with the flexibility to modify or add multiple bindings without needing to change your code.

> To read values from your Actions, you **must first enable the action**, and then either repeatedly poll the action in your game loop, or add event handlers to the action. You **must also disable the action** when you no longer want the input to trigger event handlers.


```cs
using UnityEngine;
using UnityEngine.InputSystem;

// Using embedded actions with callbacks or reading values each frame.

public class ExampleScript : MonoBehaviour
{
    // these embedded actions are configurable in the inspector:
    public InputAction moveAction;
    public InputAction jumpAction;

    public void Awake()
    {
        // assign a callback for the "jump" action.
        jumpAction.performed += ctx => { OnJump(ctx); };
    }

    public void Update()
    {
        // read the value for the "move" action each frame.
        Vector2 moveAmount = moveAction.ReadValue<Vector2>();
    }

    public void OnJump(InputAction.CallbackContext context)
    {
        // jump code goes here.
    }

    // the actions must be enabled and disabled
    // when the GameObject is enabled or disabled

    public void OnEnable()
    {
        moveAction.Enable();
        jumpAction.Enable();
    }

    public void OnDisable()
    {
        moveAction.Disable();
        jumpAction.Disable();
    }
}
```


### ref 
https://docs.unity3d.com/Packages/com.unity.inputsystem@1.7/manual/Workflow-Embedded.html


