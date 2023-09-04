## Renderer Component




### Line Renderer component
The Line Renderer component takes an array of two or more points in 3D space, and draws a straight line between each one. You can use a Line Renderer to draw anything from a simple straight line to a complex spiral.

To create a Line Renderer:

1.  In the Unity menu bar, go to **GameObject** > **Effects** > **Line**.
2.  Select the Line Renderer GameObject.
3.  Add points to the Line Renderer’s Positions array, either by directly setting array values in the Inspector
 window or by using the Create Points Scene Editing Mode.
4.  Use the Inspector window to configure the color, width, and other display settings of the line.

https://docs.unity3d.com/Manual/class-LineRenderer.html

### Trail Renderer component
The Trail Renderer component renders a trail of polygons behind a moving GameObject
, over time. This can be used to give an emphasized feeling of motion to a moving object, or to highlight the path or position of moving objects.

To create a Trail Renderer:

1.  In the Unity menu bar, go to **GameObject** > **Effects** > **Trail**.
2.  Select the Trail Renderer GameObject, and parent it to the GameObject that you want it to generate a trail for.
3.  Use the Inspector window to configure the color, width, and other display settings of the trail.
4.  Preview the trail in Edit Mode by moving the GameObject and observing the effect in the Scene view.

 https://docs.unity3d.com/Manual/class-TrailRenderer.html


### Billboard Renderer component
The Billboard Renderer renders Billboard Assets. Billboards are a level-of-detail (LOD) method for drawing complicated 3D Meshes in a simpler way when they are far away from the Camera
. When a Mesh is far away from the Camera, its size on screen means there is no need to draw it in full detail. Instead, you can replace the complex 3D Mesh with a 2D billboard representation.
 
https://docs.unity3d.com/Manual/class-BillboardRenderer.html




