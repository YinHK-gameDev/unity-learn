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

        Vector2 move = gamepad.leftStick.ReadValue();
        {
            // 'Move' code here
        }
    }
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



