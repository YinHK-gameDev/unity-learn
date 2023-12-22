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











### ref

https://gamedevbeginner.com/how-to-zoom-a-camera-in-unity-3-methods-with-examples/#movement_zoom

