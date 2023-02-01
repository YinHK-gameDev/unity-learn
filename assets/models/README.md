## Game asset models

### 3D Assets

We can use tools like **Probuilder** to create models in Unity. However, these work best for prototyping, rather than for the final product.

To add more polished 3D assets to your final product, create 3D Models, Materials and Textures in 3D modeling software and then import them into Unity, like blender, zbrush etc.

### Importing 3D Model Files
Unity uses the `.fbx` model format. You can also use other common native model formats (for example, `.max`, `.blend`, `.mb`, `.ma`), and Unity converts them into `.fbx` once they are imported.

https://docs.unity3d.com/Manual/ImportingModelFiles.html

https://docs.unity3d.com/Manual/HOWTO-ImportObjectsFrom3DApps.html

### Importing a model
Model files can contain a variety of data, such as meshes, animation rigs and clips, materials and textures.



### Import models from blender

Unity imports Blender (.blend) files through the FBX format, supporting the following:

- All nodes with position, rotation and scale; pivot points and names are also imported
- Meshes with vertices, polygons, triangles, UVs, and normals
- Bones
- Skinned Meshes
- Animations

#### Limitations
Textures and diffuse color are not assigned automatically. You can manually assign them by dragging the texture onto the mesh in the Scene Viewin Unity.

Blender does not export the visibility value inside animations in the FBX file.


https://all3dp.com/2/blender-to-unity-how-to-import-blender-models-in-unity/

https://gamedevacademy.org/how-to-import-blender-models-into-unity-your-one-stop-guide/
