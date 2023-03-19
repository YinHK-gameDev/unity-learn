## Mesh asset
A mesh asset represents a mesh in your Unity project.

Usually, Unity creates mesh assets **when it imports model**,

but you can also create mesh assets directly in Unity; for example, by creating a mesh with code and saving the results as an asset.

### Mesh Inspector

Select a **mesh asset** in the Project window to open the **Mesh Inspector**. 

This Inspector **displays information about the mesh**, such as the total number of vertices or the names of any blend shapes the mesh has. It also displays a visual preview of the mesh.

> The Mesh Inspector displays information about how the mesh asset stores
 its data, but not the values in the data itself. 

### Mesh preview
In the Mesh Inspector, you can preview the appearance of a mesh and explore the mesh data in a visual way.

You can use the following mouse and keyboard controls to navigate the mesh view:

- Rotate the view: left-click and drag.
- Rotate the light source: right-click and drag. A light source is present only in the “Shaded” and “Blendshapes” views.
- Pan the camera: middle-click and drag.
- Zoom the camera in and out: scroll the mouse wheel.
- Reset the zoom and pan settings: hover the mouse cursor inside the preview and press the **“F”** key. This does not reset the rotation.

> The **"UV Layout"** view displays the **UV map** of your mesh as a 2D image. Unity disables rotation in this view. To pan the camera, click and drag any of the left, right, or middle mouse buttons.


Each view displays the following data about the mesh underneath the preview of the mesh:

- The name of the mesh.
- The number of vertices in the mesh.
- The type and number of faces in the mesh. Most meshes use triangles to define faces.
- The number of blend shapes in the mesh, if any.
- The number of sub-meshes in the mesh, if there is more than one.
- The names of all UV maps in the mesh.
- For skinned meshes, the name of the skin weights property.


### View mode

- **Shaded**:  Provides a visualization of the mesh with a basic light. This is the default view.
- **UV Checker**: Applies a checkerboard texture to the mesh to visualize how the mesh’s UV map applies textures.
- **UV Layout**: Displays how the vertices of the mesh are organized in the unwrapped **UV map**. This view disables the Wireframe toggle.
- **Vertex Color**: Visualizes any vertex colors that the vertices in this mesh have. If no vertices have a vertex color, this menu item is disabled. 
- **Normals**: Visualizes the **relative directions of the normals** in the mesh with color.
- **Tangents**: Visualizes the **tangent data** in the mesh with **colo**r. 
- **Blendshapes**: Lets you preview blend shape deformations to the mesh. If the mesh has no blend shapes, this menu item is disabled.

### ref

https://docs.unity3d.com/Manual/class-Mesh.html



