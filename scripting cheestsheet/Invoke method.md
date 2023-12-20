### `Invoke()`


```cs
public void Invoke(string methodName, float time);
```

**Invokes the method methodName in time seconds**.

If time is set to 0 and Invoke is called before the first frame update, the method is invoked at the next Update cycle before MonoBehaviour.Update. In this case, it's better to call the function directly.

Note: Setting time to negative values is identical to setting it to 0.

In other cases, the order of execution of the method depends on the timing of the invocation.

If you need to pass parameters to your method, consider using Coroutine instead. Coroutines also provide better performance.

```cs

using UnityEngine;
using System.Collections.Generic;

public class ExampleScript : MonoBehaviour
{
    // Launches a projectile in 2 seconds

    Rigidbody projectile;

    void Start()
    {
        Invoke("LaunchProjectile", 2.0f);
    }

    void LaunchProjectile()
    {
        Rigidbody instance = Instantiate(projectile);
        instance.velocity = Random.insideUnitSphere * 5.0f;
    }
}
```

https://docs.unity3d.com/ScriptReference/MonoBehaviour.Invoke.html



### `Invokerepeating()`
Invokes the method methodName in time seconds, then repeatedly every repeatRate seconds.
> Note : This does not work if you set the time scale to 0.


```cs
public void InvokeRepeating(string methodName, float time, float repeatRate);
```

```cs 
using UnityEngine;
using System.Collections.Generic;

// Starting in 2 seconds.
// a projectile will be launched every 0.3 seconds

public class ExampleScript : MonoBehaviour
{
    public Rigidbody projectile;

    void Start()
    {
        InvokeRepeating("LaunchProjectile", 2.0f, 0.3f);
    }

    void LaunchProjectile()
    {
        Rigidbody instance = Instantiate(projectile);

        instance.velocity = Random.insideUnitSphere * 5;
    }
}
```



https://docs.unity3d.com/ScriptReference/MonoBehaviour.InvokeRepeating.html










