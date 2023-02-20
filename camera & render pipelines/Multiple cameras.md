## Multiple cameras
You can have as many cameras in a scene as you like and their views can be combined in different ways, as described below.

- Switching cameras:
  By default, a camera renders its view to cover the whole screen and so only one camera view can be seen at a time (**the visible camera is the one that has the highest value for its depth property**). By disabling one camera and enabling another from a script, you can “cut” from one camera to another to give different views of a scene. Eg:
```cs
using UnityEngine;
public class ExampleScript : MonoBehaviour {
    public Camera firstPersonCamera;
    public Camera overheadCamera;

    // Call this function to disable FPS camera,
    // and enable overhead camera.
    public void ShowOverheadView() {
        firstPersonCamera.enabled = false;
        overheadCamera.enabled = true;
    }
    
    // Call this function to enable FPS camera,
    // and disable overhead camera.
    public void ShowFirstPersonView() {
        firstPersonCamera.enabled = true;
        overheadCamera.enabled = false;
    }
}
  ```
- Rendering a small camera view inside a larger one
  Usually, you want at least one camera view covering the whole screen (the default setting) but it is often useful to show another view inside a small area of the screen. For example, you might show a rear view mirror in a driving game or show an overhead mini-map in the corner of the screen while the main view is first-person. You can set the size of a camera’s onscreen rectangle using its Viewport Rect property.

The coordinates of the viewport
 rectangle are “normalized” with respect to the screen. The bottom and left edges are at the 0.0 coordinate, while the top and right edges are at 1.0. A coordinate value of 0.5 is halfway across. In addition to the viewport size, you should also set the depth property of the camera with the smaller view to a higher value than the background camera. The exact value does not matter but the rule is that a camera with a higher depth value is rendered over one with a lower value.



### ref
https://blog.theknightsofunity.com/using-multiple-unity-cameras-why-this-may-be-important/
