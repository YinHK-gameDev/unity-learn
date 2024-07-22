## Gizmos

Gizmos are used to give visual debugging or setup aids in the Scene view.

All gizmo drawing has to be done in either **`MonoBehaviour.OnDrawGizmos`** or **`MonoBehaviour.OnDrawGizmosSelected`** functions of the script


| Static Properties | Description |
| --- | --- |
| color | Sets the Color of the gizmos that are drawn next. |
| exposure | Set a texture that contains the exposure correction for LightProbe gizmos. The value is sampled from the red channel in the middle of the texture. |
| matrix | Sets the Matrix4x4 that the Unity Editor uses to draw Gizmos. |
| probeSize | Set a scale for Light Probe gizmos. This scale will be used to render the spherical harmonic preview spheres. |


| Static Methods | Description |
| --- | --- |
| DrawCube | Draw a solid box at center with size. |
| DrawFrustum | Draw a camera frustum using the currently set Gizmos.matrix for its location and rotation. |
| DrawGUITexture | Draw a texture in the Scene. |
| DrawIcon | Draw an icon at a position in the Scene view. |
| DrawLine | Draws a line starting at from towards to. |
| DrawLineList | Draws multiple lines between pairs of points. |
| DrawLineStrip | Draws a line between each point in the supplied span. |
| DrawMesh | Draws a mesh. |
| DrawRay | Draws a ray starting at from to from + direction. |
| DrawSphere | Draws a solid sphere with center and radius. |
| DrawWireCube | Draw a wireframe box with center and size. |
| DrawWireMesh | Draws a wireframe mesh. |
| DrawWireSphere | Draws a wireframe sphere with center and radius. |



### ref 
https://docs.unity3d.com/ScriptReference/Gizmos.html


