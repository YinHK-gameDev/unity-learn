## Rays from the Camera

 The Ray always corresponds to a point in the view, so the Camera class provides the **`ScreenPointToRay`** and **`ViewportPointToRay`** functions. The difference between the two is that ScreenPointToRay expects the point to be provided as a pixel
 coordinate, while ViewportPointToRay takes normalized coordinates in the range **0..1 **(where 0 represents the bottom or left and 1 represents the top or right of the view). Each of these functions returns a Ray which consists of a point of origin and a vector which shows the direction of the line from that origin. The Ray originates from the near clipping plane
 rather than the Camera’s transform.position point.
 
### Raycasting

The most common use of a Ray from the camera is to perform a raycast out into the scene
. A **raycast** sends an imaginary “laser beam” along the ray from its origin until it hits a collider
 in the scene. Information is then returned about the object and the point that was hit in a RaycastHit object. This is a very useful way to locate an object based on its onscreen image. For example, the object at the mouse position can be determined with the following code:

```cs

using UnityEngine;
using System.Collections;

public class ExampleScript : MonoBehaviour 
{
    public Camera camera;

    void Start()
    {
        RaycastHit hit;
        Ray ray = camera.ScreenPointToRay(Input.mousePosition);
        
        if (Physics.Raycast(ray, out hit)) 
        {
            Transform objectHit = hit.transform;
            
            // Do something with the object that was hit by the raycast.
        }
    }
}

```

### Moving the Camera Along a Ray
It is sometimes useful to get a ray corresponding to a screen position and then move the camera along that ray. For example, you may want to allow the user to select an object with the mouse and then zoom in on it while keeping it **"pinned"** to the same screen position under the mouse (this might be useful when the camera is looking at a tactical map, for example). The code to do this is fairly straightforward:

```cs
using UnityEngine;
using System.Collections;

public class ExampleScript : MonoBehaviour {
    public bool zooming;
    public float zoomSpeed;
    public Camera camera;

    void Update() {
        if (zooming) {
            Ray ray = camera.ScreenPointToRay(Input.mousePosition);
            float zoomDistance = zoomSpeed * Input.GetAxis("Vertical") * Time.deltaTime;
            camera.transform.Translate(ray.direction * zoomDistance, Space.World);
        }
    }
}
```




### ref 
https://docs.unity3d.com/Manual/CameraRays.html
