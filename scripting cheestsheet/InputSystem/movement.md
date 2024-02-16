## Movemnet

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

        Vector2 move = gamepad.current.leftStick.ReadValue();
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



