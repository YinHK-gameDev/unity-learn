## Jump

**Referencing the Actions Asset through a C# wrapper:**
```cs

// PlayerInputActions is the C# class that Unity auto-generated.
// It encapsulates the data from the .inputactions asset we created
// and automatically looks up all the maps and actions for us.
PlayerInputActions input;

Rigidbody rb;

void Start()
{
   rb = GetComponent<Rigidbody>();
   // instantiate the actions wrapper class
   input = new PlayerInputActions();

   input.Player.Enable();
   // Access specific Action map "Player" & the "move" action, we add a callback method for when it is performed
   input.Player.jump.performed += OnJump;
}

private void OnJump(InputAction.CallbackContext context)
{
   rb.AddForce(Vector3.up * 5f, ForceMode.Impulse);
}

```



### ref 
https://matteolopiccolo.medium.com/unity-new-input-system-jump-part-viii-49f876f70e5f
