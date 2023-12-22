## How to zoom a camera in Unity 


### zoom a camera by using field of view

The easier method to zoom is Just to create a basic zoom effect is reduce the camera’s **Field of View property**.


```cs
Camera.main.fieldOfView;
```
Eg:
```cs
Camera.main.fieldOfView = 10;
```

```cs

public class x2Zoom : MonoBehaviour
{
    public Camera cam;
    public float defaultFov = 90;
    void Update()
    {
        if (Input.GetMouseButton(1))
        {
            cam.fieldOfView = (defaultFov / 2);
        }
        else
        {
            cam.fieldOfView = (defaultFov);
        }
    }
}
```

#### Smooth camera zoom 


Using **`Mathf.MoveTowards`**, moves a value `current` towards `target`.

```cs
void ZoomCamera(float target)
{
    cam.fieldOfView = Mathf.MoveTowards(cam.fieldOfView, target, zoomSpeed * Time.deltaTime);
}

```

```cs
public class SmoothScopeZoom : MonoBehaviour
{
  public Camera cam;
  public float zoomMultiplier = 2;
  public float defaultFov = 90;
  public float zoomDuration = 2;
  void Update()
  {
    if (Input.GetMouseButton(1))
    {
      ZoomCamera(defaultFov / zoomMultiplier);
    }
    else if (cam.fieldOfView != defaultFov)
    {
      ZoomCamera(defaultFov);
    }
  }
  void ZoomCamera(float target)
  {
    float angle = Mathf.Abs((defaultFov / zoomMultiplier) - defaultFov);
    cam.fieldOfView = Mathf.MoveTowards(cam.fieldOfView, target, angle / zoomDuration * Time.deltaTime);
  }
}
```

Using **`Lerp`**

```cs
[Range(0f, 1f)]
public float zoomLerpFactor = 0.3f;


Vector3 goalPosition =   cameraTarget.position - (transform.rotation * Vector3.forward * distance);
transform.position = Vector3.Lerp(transform.position, goalPosition, zoomLerpFactor);

```


#### Zoom an object by moving it closer (the movement method)

```cs
public class CameraMovement : MonoBehaviour
{
    public float speed = 25;
    void Update()
    {
        MoveCamera(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
    }
    void MoveCamera(float x, float y)
    {
        Vector3 movementAmount = new Vector3(x, 0, y) * speed * Time.deltaTime;
        transform.Translate(movementAmount);
    }
}
```

```cs
public class MovementZoom : MonoBehaviour
{
    public float zoomLevel;
    public Transform parentObject;
    void Update()
    {
        transform.position = parentObject.position + (transform.forward * zoomLevel);
    }
}
```

#### Zoom a camera using the mouse scroll wheel

```cs
public float zoomLevel;
public float sensitivity=1;
void Update()
{
    zoomLevel += Input.mouseScrollDelta.y * sensitivity;
}
```

```cs
using UnityEngine;
public class MovementZoom : MonoBehaviour
{
    // Movement based Scroll Wheel Zoom.
    public Transform parentObject;
    public float zoomLevel;
    public float sensitivity=1;
    public float speed = 30;
    public float maxZoom=30;
    float zoomPosition;
    void Update()
    {
        zoomLevel += Input.mouseScrollDelta.y * sensitivity;
        zoomLevel = Mathf.Clamp(zoomLevel, 0, maxZoom);
        zoomPosition = Mathf.MoveTowards(zoomPosition, zoomLevel, speed * Time.deltaTime);
        transform.position = parentObject.position + (transform.forward * zoomPosition);
    }
}
```

#### Zoom the camera out to avoid collisions with objects

```cs
void ClipCheck()
    {
        Ray ray = new Ray(parentObject.position, transform.forward);
        if (Physics.SphereCast(ray, 3, out RaycastHit hit, maxZoom))
        {
            if (hit.distance < zoomLevel+3)
            {
                zoomLevel = hit.distance - 3;
            }
        }
    }

```

### ref

https://gamedevbeginner.com/how-to-zoom-a-camera-in-unity-3-methods-with-examples/#movement_zoom

https://gamedevbeginner.com/the-right-way-to-lerp-in-unity-with-examples/

https://docs.unity3d.com/ScriptReference/Mathf.MoveTowards.html

https://docs.unity3d.com/ScriptReference/Mathf.Lerp.html

https://www.youtube.com/watch?v=HxnpWhxjJwE

