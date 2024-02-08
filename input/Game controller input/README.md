
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

### ref 
https://docs.unity3d.com/Manual/ios-handle-game-controller-input.html

Detect Game Controllers \
https://docs.unity3d.com/Manual/ios-detect-game-controllers.html
