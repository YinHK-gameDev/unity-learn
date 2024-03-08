## Movement

### Move game object(translate)
**`transform.Translate(Vector3 translation)`**

![](./translate().png)


### Moving a game object:(using AddForce)

```cs
//using rigidbody and physic
playerRb = GetComponent<Rigidbody>();

//input
float horizontalInput = Input.GetAxis(“Horizontal”);
float verticalInput = Input.GetAxis(“Vertical”);

//move
playerRb.AddForce(Vector3.forward * speed * verticalInput);
playerRb.AddForce(Vector3.right * speed * horizontalInput);
```

#### Jumping & Dashing using `AddForce`

```cs
if (Input.GetButtonDown("Jump") && _isGrounded)
{
    _body.AddForce(Vector3.up * Mathf.Sqrt(JumpHeight * -2f * Physics.gravity.y), ForceMode.VelocityChange);
}
if (Input.GetButtonDown("Dash"))
{
      Vector3 dashVelocity = Vector3.Scale(transform.forward, DashDistance * new Vector3((Mathf.Log(1f / (Time.deltaTime *   _body.drag + 1)) / -Time.deltaTime), 0, (Mathf.Log(1f / (Time.deltaTime * _body.drag + 1)) / -Time.deltaTime)));
      _body.AddForce(dashVelocity, ForceMode.VelocityChange);
}
```


Eg:
```cs
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigidbodyCharacter : MonoBehaviour
{

    public float Speed = 5f;
    public float JumpHeight = 2f;
    public float GroundDistance = 0.2f;
    public float DashDistance = 5f;
    public LayerMask Ground;

    private Rigidbody _body;
    private Vector3 _inputs = Vector3.zero;
    private bool _isGrounded = true;
    private Transform _groundChecker;

    void Start()
    {
        _body = GetComponent<Rigidbody>();
        _groundChecker = transform.GetChild(0);
    }

    void Update()
    {
        _isGrounded = Physics.CheckSphere(_groundChecker.position, GroundDistance, Ground, QueryTriggerInteraction.Ignore);


        _inputs = Vector3.zero;
        _inputs.x = Input.GetAxis("Horizontal");
        _inputs.z = Input.GetAxis("Vertical");
        if (_inputs != Vector3.zero)
            transform.forward = _inputs;

        if (Input.GetButtonDown("Jump") && _isGrounded)
        {
            _body.AddForce(Vector3.up * Mathf.Sqrt(JumpHeight * -2f * Physics.gravity.y), ForceMode.VelocityChange);
        }
        if (Input.GetButtonDown("Dash"))
        {
            Vector3 dashVelocity = Vector3.Scale(transform.forward, DashDistance * new Vector3((Mathf.Log(1f / (Time.deltaTime * _body.drag + 1)) / -Time.deltaTime), 0, (Mathf.Log(1f / (Time.deltaTime * _body.drag + 1)) / -Time.deltaTime)));
            _body.AddForce(dashVelocity, ForceMode.VelocityChange);
        }
    }


    void FixedUpdate()
    {
        _body.MovePosition(_body.position + _inputs * Speed * Time.fixedDeltaTime);
    }
}
```

```cs
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example : MonoBehaviour
{
    private CharacterController controller;
    private Vector3 playerVelocity;
    private bool groundedPlayer;
    private float playerSpeed = 2.0f;
    private float jumpHeight = 1.0f;
    private float gravityValue = -9.81f;

    private void Start()
    {
        controller = gameObject.AddComponent<CharacterController>();
    }

    void Update()
    {
        groundedPlayer = controller.isGrounded;
        if (groundedPlayer && playerVelocity.y < 0)
        {
            playerVelocity.y = 0f;
        }

        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        controller.Move(move * Time.deltaTime * playerSpeed);

        if (move != Vector3.zero)
        {
            gameObject.transform.forward = move;
        }

        // Changes the height position of the player..
        if (Input.GetButtonDown("Jump") && groundedPlayer)
        {
            playerVelocity.y += Mathf.Sqrt(jumpHeight * -3.0f * gravityValue);
        }

        playerVelocity.y += gravityValue * Time.deltaTime;
        controller.Move(playerVelocity * Time.deltaTime);
    }
}
```
```cs
using UnityEngine;
using System.Collections;

[RequireComponent(typeof(CharacterController))]
public class ExampleClass : MonoBehaviour
{
    public float speed = 3.0F;
    public float rotateSpeed = 3.0F;

    void Update()
    {
        CharacterController controller = GetComponent<CharacterController>();

        // Rotate around y - axis
        transform.Rotate(0, Input.GetAxis("Horizontal") * rotateSpeed, 0);

        // Move forward / backward
        Vector3 forward = transform.TransformDirection(Vector3.forward);
        float curSpeed = speed * Input.GetAxis("Vertical");
        controller.SimpleMove(forward * curSpeed);
    }
}
```

### Using InputSystem player Input component


```cs
public void Move(InputAction.CallbackContext value)
{
        moveVal = value.ReadValue<Vector2>();
        transform.Translate(new Vector3(moveVal.x, moveVal.y, 0));
}
```

### Moving object smoothly(**`Vector.Lerp`**)

```
public static Vector3 Lerp(Vector3 a, Vector3 b, float t);
```

```
transform.position = Vector3 Lerp(...);
```

```cs
public class ExampleClass : MonoBehaviour
{
    // Transforms to act as start and end markers for the journey.
    public Transform startMarker;
    public Transform endMarker;

    // Movement speed in units per second.
    public float speed = 1.0F;

    // Time when the movement started.
    private float startTime;

    // Total distance between the markers.
    private float journeyLength;

    void Start()
    {
        // Keep a note of the time the movement started.
        startTime = Time.time;

        // Calculate the journey length.
        journeyLength = Vector3.Distance(startMarker.position, endMarker.position);
    }

    // Move to the target end position.
    void Update()
    {
        // Distance moved equals elapsed time times speed..
        float distCovered = (Time.time - startTime) * speed;

        // Fraction of journey completed equals current distance divided by total distance.
        float fractionOfJourney = distCovered / journeyLength;

        // Set our position as a fraction of the distance between the markers.
        transform.position = Vector3.Lerp(startMarker.position, endMarker.position, fractionOfJourney);
    }
}
```


### Basic movement from user input

- Declare a new **`private`** float speed variable
- If using physics, declare a new **Rigidbody playerRb variable** for it and initialize it in `Start()`
- If using arrow keys, declare new **vertical Input** and/or **horizontal Input variables**.
- If basing your movement off a key press, create the if-statement to test for the KeyCode.
- Use either the **transform.Translate method** or **transform.position** property or **AddForce method**(if using physics) to move your character.



### Character Controller component approach for movement
A CharacterController allows you to **easily do movement constrained by collisions without having to deal with a rigidbody**. A CharacterController is **not affected by force**s and will **only move when you call the Move function**. It will then carry out the movement but be constrained by collisions.

The Character Controller is a component you can add to your player. Its function is to move the player **according to the environment (the colliders)**. \
It **doesn’t respond nor uses physics** in any way.


The Character Controller includes 2 methods used to move the character: **`SimpleMove`** and **`Move`**.

For **`SimpleMove`**, the downside is that the Y axis velocity is ignored by this method. **`SimpleMove`** becomes very quickly limiting by the fact that you have no effect on the Y axis velocity.

By using **Move**:
```cs
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public float Speed = 5f;
    public float JumpHeight = 2f;
    public float Gravity = -9.81f;
    public float GroundDistance = 0.2f;
    public float DashDistance = 5f;
    public LayerMask Ground;
    public Vector3 Drag;

    private CharacterController _controller;
    private Vector3 _velocity;
    private bool _isGrounded = true;
    private Transform _groundChecker;


    void Start()
    {
        _controller = GetComponent<CharacterController>();
        _groundChecker = transform.GetChild(0);
    }

    void Update()
    {
        _isGrounded = Physics.CheckSphere(_groundChecker.position, GroundDistance, Ground, QueryTriggerInteraction.Ignore);
        if (_isGrounded && _velocity.y < 0)
            _velocity.y = 0f;

        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        _controller.Move(move * Time.deltaTime * Speed);
        if (move != Vector3.zero)
            transform.forward = move;

        if (Input.GetButtonDown("Jump") && _isGrounded)
            _velocity.y += Mathf.Sqrt(JumpHeight * -2f * Gravity);
        if (Input.GetButtonDown("Dash"))
        {
            Debug.Log("Dash");
            _velocity += Vector3.Scale(transform.forward, DashDistance * new Vector3((Mathf.Log(1f / (Time.deltaTime * Drag.x + 1)) / -Time.deltaTime), 0, (Mathf.Log(1f / (Time.deltaTime * Drag.z + 1)) / -Time.deltaTime)));
        }


        _velocity.y += Gravity * Time.deltaTime;

        _velocity.x /= 1 + Drag.x * Time.deltaTime;
        _velocity.y /= 1 + Drag.y * Time.deltaTime;
        _velocity.z /= 1 + Drag.z * Time.deltaTime;

        _controller.Move(_velocity * Time.deltaTime);
    }

}

```



```cs
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example : MonoBehaviour
{
    private CharacterController controller;
    private Vector3 playerVelocity;
    private bool groundedPlayer;
    private float playerSpeed = 2.0f;
    private float jumpHeight = 1.0f;
    private float gravityValue = -9.81f;

    private void Start()
    {
        controller = gameObject.AddComponent<CharacterController>();
    }

    void Update()
    {
        groundedPlayer = controller.isGrounded;
        if (groundedPlayer && playerVelocity.y < 0)
        {
            playerVelocity.y = 0f;
        }

        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        controller.Move(move * Time.deltaTime * playerSpeed);

        if (move != Vector3.zero)
        {
            gameObject.transform.forward = move;
        }

        // Changes the height position of the player..
        if (Input.GetButtonDown("Jump") && groundedPlayer)
        {
            playerVelocity.y += Mathf.Sqrt(jumpHeight * -3.0f * gravityValue);
        }

        playerVelocity.y += gravityValue * Time.deltaTime;
        controller.Move(playerVelocity * Time.deltaTime);
    }
}

```


> For the gravity, you can use use the global gravity with **`Physics.gravity.y`** or private variable of gravity set by yourself

https://docs.unity3d.com/ScriptReference/CharacterController.html


### Character Controller vs Rigidbody approach

**Rigidbody code less**, a **lot more functions to interact with physic** whereas the Character Controller doesn’t.
Character Controller approach **doesn't need to take care about any physics**.

https://medium.com/ironequal/unity-character-controller-vs-rigidbody-a1e243591483



### ref

https://medium.com/geekculture/simple-player-movement-in-unity-a467577e37a6

https://www.tutorialspoint.com/unity/unity_basic_movement_scripting.htm

https://www.noob-programmer.com/unity3d/basic-movement-in-unity3d/





