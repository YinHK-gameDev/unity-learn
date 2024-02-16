## Movement

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

        Vector2 move = gamepad.leftStick.ReadValue();
        {
            // 'Move' code here
            transform.Translate(new Vector3(move.x, 0, move.y));
        }
    }
}


// Read stick as a combined 2D vector.
Gamepad.current.leftStick.ReadValue();

// Read X and Y axis of stick individually.
Gamepad.current.leftStick.x.ReadValue();
Gamepad.current.leftStick.y.ReadValue();

// Read the stick as four individual directional buttons.
Gamepad.current.leftStick.up.ReadValue();
Gamepad.current.leftStick.down.ReadValue();
Gamepad.current.leftStick.left.ReadValue();
Gamepad.current.leftStick.right.ReadValue();
```

```cs
// This embedded action is configurable in the inspector:
public InputAction moveAction;

public void Update()
{
    // read the value for the "move" action each frame.
    Vector2 moveAmount = moveAction.ReadValue<Vector2>();
    transform.Translate(new Vector3(moveAmount.x, 0, moveAmount.y));
}

public void OnEnable()
{
    moveAction.Enable();
}

public void OnDisable()
{
    moveAction.Disable();
}
```

```cs

// assign the actions asset to this field in the inspector:
public InputActionAsset actions;

// private field to store move action reference
private InputAction moveAction;

void Awake()
{
    // find the "move" action, and keep the reference to it, for use in Update
    moveAction = actions.FindActionMap("gameplay").FindAction("move");

}

void Update()
{
   // our update loop polls the "move" action value each frame
   Vector2 moveVector = moveAction.ReadValue<Vector2>();
   transform.Translate(new Vector3(moveVector.x, 0, moveVector.y));
}

void OnEnable()
{
   actions.FindActionMap("gameplay").Enable();
}

void OnDisable()
{
    actions.FindActionMap("gameplay").Disable();
}

```

```cs
public void OnMove(InputAction.CallbackContext context)
{

	// read the value for the "move" action each event call
	print(context);
	moveAmount = context.ReadValue<Vector2>();

}

public void Update()
{
	transform.Translate(new Vector3(moveAmount.x, 0, moveAmount.y));
}
```




#### Most used method for reading value

**`UnityEngine.InputSystem.InputControl<TValue>.ReadValue()`**, any inherited class can use this method to read value:
```cs
public TValue ReadValue();
```

**`Unity​Engine.​Input​System.Input​Action.ReadValue<TValue>()`**, any inherited class can use this method to read value:

```cs
public TValue ReadValue<TValue>()
    where TValue : struct
```

**`Unity​Engine.​Input​System.Input​Action.​Callback​Context.ReadValue<TValue>()`**, pass Input​Action.​Callback​Context struct as a callback function can use this method to read value:
```cs
public TValue ReadValue<TValue>()
    where TValue : struct
```





