## Rays from the Camera

The Ray corresponds to a point in the view, 
so the Camera class provides the **`ScreenPointToRay`** and **`ViewportPointToRay`** functions. 

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

### `Camera.ScreenPointToRay`

Returns a ray going from camera through a screen point.

Resulting ray is in world space, starting on the near plane of the camera and going through position's (x,y) pixel coordinates on the screen (position.z is ignored).

Screenspace is defined in pixels. The bottom-left of the screen is (0,0); the right-top is **`(pixelWidth-1, pixelHeight -1)`**.

```cs
public Ray ScreenPointToRay(Vector3 pos);
```
or
```cs
public Ray ScreenPointToRay(Vector3 pos, Camera.MonoOrStereoscopicEye eye);
```

- **pos**: \
A 3D point, with the x and y coordinates containing a 2D screenspace point in pixels. The lower left pixel of the screen is (0,0). The upper right pixel of the screen is (screen width in pixels - 1, screen height in pixels - 1). Unity ignores the z coordinate.

- **eye**: \
Optional argument that can be used to specify which eye transform to use. Default is **Mono**.





### ref
https://www.scratchapixel.com/lessons/3d-basic-rendering/ray-tracing-generating-camera-rays/definition-ray.html

https://docs.unity3d.com/Manual/CameraRays.html

https://docs.unity3d.com/ScriptReference/Camera.ScreenPointToRay.html

https://docs.unity3d.com/ScriptReference/Camera.ViewportPointToRay.html
