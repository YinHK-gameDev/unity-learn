
## Handle Game Controller input


### Example: Set up joystick button A for the Jump action

1.  Go to **Edit** > **Project Settings**.
2.  Select the **Input Manager** category.
3.  Open the **Jump** action.
4.  Set **Positive Button** to **joystick button 14**.

This code example demonstrates the corresponding input handling:

```cs
using UnityEngine;

public class Jumping : MonoBehaviour
{
    Rigidbody2D rb;
    float jumpForce = 100f;

    void Start()
    {
        rb = GetComponent&lt;Rigidbody2D&gt;();
    }

    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            rb.AddForce(new Vector2(0f, jumpForce));
        }
    }
}
```

### Example: Set up joystick button X for the Fire action

1.  Go to **Edit** > **Project Settings**.
2.  Select the **Input Manager** category.
3.  Open the **Fire1** action.
4.  Set **Positive Button** to **joystick button 15**.

This code example demonstrates the corresponding input handling:

```cs
using UnityEngine;
 
public class Shooting : MonoBehaviour
{
    float bulletSpeed = 500f;
    public Transform gun;
    public Rigidbody2D bullet;
 
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            var bulletInstance = Instantiate(bullet, gun.position, gun.rotation);
            bulletInstance.AddForce(gun.up * bulletSpeed);
        }
    }
}
```

### Set up virtual button for game controller in Input Manager Axes
-   Go to **Edit** > **Project Settings**.
-   Select the **Input Manager** category. For the Axes
-   Open the virtual button name or create new virtual button name.
-   Set **Positive Button** to **the following game controller keycode**.


#### Game Controller input mapping

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




### ref 
https://docs.unity3d.com/Manual/ios-handle-game-controller-input.html

Detect Game Controllers \
https://docs.unity3d.com/Manual/ios-detect-game-controllers.html
