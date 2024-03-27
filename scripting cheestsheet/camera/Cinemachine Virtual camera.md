### Virtual Camera in Cinemachine


### Switching virtual camera

**Setting priority value in virtual camera** determine which virtual camera **to be used**. \
Therefore, to switch between these virtual cameras we can **adjust the priority value in these virtual cameras**. 

> Another method is to **active or deactive the virtual cameras**. 



#### Adjust priority value

Using **`Unity.Cinemachine.CinemachineVirtualCameraBase`** class, setting the **priority value**.

Eg:

```cs
using System.Collections;

using System.Collections.Generic;

using UnityEngine;

using Cinemachine;

public class CamSwitcher_SetPriority : MonoBehaviour

{

    public CinemachineVirtualCamera cam1, cam2;

    void Start()

    {

        cam1.Priority = 10;

        cam2.Priority = 0;

    }

    void Update()

    {

        if (Input.GetMouseButtonDown(0))

        {

            cam1.Priority = 10;

            cam2.Priority = 0;

        }

        else if (Input.GetMouseButtonDown(1))

        {

            cam1.Priority = 0;

            cam2.Priority = 10;

        }

    }

}

```

#### Active or deactive virtual cameras
You can either manually active/deactive the virtual camera in hierarchy or through script using **`setActive()`** method.


Eg:

```cs
using System.Collections;

using System.Collections.Generic;

using UnityEngine;

public class CamSwitcher_SetActive : MonoBehaviour

{

    public GameObject cam1, cam2;

    void Start()

    {

        cam1.SetActive(true);

        cam2.SetActive(false);

    }

    void Update()

    {

        if (Input.GetMouseButtonDown(0))

        {

            cam1.SetActive(true);

            cam2.SetActive(false);

        }

        else if (Input.GetMouseButtonDown(1))

        {

            cam1.SetActive(false);

            cam2.SetActive(true);

        }

    }

}
```




### ref

https://docs.unity3d.com/Packages/com.unity.cinemachine@3.0/api/index.html

**`Unity.Cinemachine`**: \
https://docs.unity3d.com/Packages/com.unity.cinemachine@3.0/api/Unity.Cinemachine.html

**`Unity.Cinemachine.CinemachineVirtualCameraBase`**
https://docs.unity3d.com/Packages/com.unity.cinemachine@3.0/api/Unity.Cinemachine.CinemachineVirtualCameraBase.html#methods

