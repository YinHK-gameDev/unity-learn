## Movemnet


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



