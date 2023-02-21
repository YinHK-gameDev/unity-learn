## Rays from the Camera

The Ray corresponds to a point in the view, 
so the Camera class provides the `ScreenPointToRay` and `ViewportPointToRay` functions. 

Any point in the camera’s view corresponds to a line in world space.

The difference between the two is that `ScreenPointToRay` expects the point to be provided as a pixel coordinate, while `ViewportPointToRay` takes normalized coordinates in the range `0..1` (where 0 represents the bottom or left and 1 represents the top or right of the view). Each of these functions returns a Ray which consists of a point of origin and a vector which shows the direction of the line from that origin. 
 
 > The Ray originates from the near clipping plane rather than the Camera’s `transform.position` point.


### Moving the Camera Along a Ray

It is sometimes useful to get a ray corresponding to a screen position and then move the camera along that ray. For example, you may want to allow the user to select an object with the mouse and then zoom in on it while keeping it “pinned” to the same screen position under the mouse (this might be useful when the camera is looking at a tactical map, for example). The code to do this is fairly straightforward:

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

