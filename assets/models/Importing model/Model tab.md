## Model tab

### Scene

| Property | Function |
| --- | --- |
| Scale Factor | Set this value to apply a global scale on the imported Model whenever the original file scale (from the Model file) does not fit the intended scale in your Project. Unity’s physics system expects 1 meter in the game world to be 1 unit in the imported file. |
| Convert Units | Enable this option to convert the Model scaling defined in the Model file to Unity’s scale. |
| Bake Axis Conversion | Enable this property to bake the results of axis conversion directly into your application’s asset data (for example, vertex or animation data) when you import a Model that uses a different axis system than Unity. Disable this property to compensate the Transform component of the root GameObject at runtime to simulate axis conversion. |
| Import BlendShapes | Enable this property to allow Unity to import blend shapes with your Mesh. See Importing blend shapes below for details.Note: Importing blend shape normals requires smoothing groups in the FBX file. |
| Import Visibility | Import the FBX settings that define whether or not MeshRenderer components are enabled (visible). See Importing Visibility below for details. |
| Import Cameras | Import cameras from your .FBX file. See Importing Cameras below for details. |
| Import Lights | Import lights from your .FBX file. See Importing Lights below for details. |
| Preserve Hierarchy | Always create an explicit prefab root, even if this model only has a single root. Normally, the FBX Importer strips any empty root nodes from the model as an optimization strategy. However, if you have multiple FBX files with portions of the same hierarchy you can use this option to preserve the original hierarchy.For example, file1.fbx contains a rig and a Mesh and file2.fbx contains the same rig but only the animation for that rig. If you import file2.fbx without enabling this option, Unity strips the root node, the hierarchies don’t match, and the animation breaks. |
| Sort Hierarchy By Name | Enable this property to sort GameObjects by alphabetical order within the hierarchy. Disable this property to preserve the hierarchy order defined in the FBX file. |


https://docs.unity3d.com/Manual/FBXImporter-Model.html
