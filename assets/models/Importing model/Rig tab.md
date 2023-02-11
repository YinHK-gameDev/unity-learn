## Rig

### Animation Type
Specfiy the type of animation:
- **None**: No animation present
- **Legacy**: Use the Legacy Animation System. Import and use animations as with Unity version 3.x and earlier.
- **Generic**: Use the Generic Animation System if your rig is non-humanoid (quadruped or any entity to be animated). Unity picks a root node but you can identify another bone to use as the Root node instead.
- **Humanoid**: Use the Humanoid Animation System if your rig is humanoid (it has two legs, two arms and a head). Unity usually detects the skeleton and maps it to the Avatar correctly. In some cases, you may need to set a change the Avatar Definition and Configure the mapping manually.
 

### Generic animation types
Your rig is non-humanoid (quadruped or any entity to be animated)

Generic Animations do not use Avatars like Humanoid animations
 do. Since the skeleton can be arbitrary, you must specify which bone is the Root node. The Root node allows Unity to establish consistency between Animation clips
 for a generic model, and blend properly between Animations that have not been authored “in place” (that is, where the whole model moves its world position while animating).

Specifying the root node helps Unity determine between movement of the bones relative to each other, and motion of the Root node in the world

#### Avatar Definition: 
Choose where to get the Avatar definition.

- Create from this model: Create an Avatar based on this model
- Copy from Other Avatar: Point to an Avatar set up on another model.

#### Root node
Select the bone to use as a root node for this Avatar.

#### Source
Copy another Avatar with an identical rig to import its animation clips.

> This setting is only available if you set the Avatar Definition to Copy from Other Avatar.

#### Skin Weights	
Set the maximum number of bones that can influence a single vertex.

- Standard (4 Bones): Use a maximum influence of four bones. This is the default, and is recommended for performance.
- Custom: Set your own maximum number of bones. When you select this option, the Max Bones/Vertex and Max Bone Weight properties appear.

#### Max Bones/Vertex
Set the maximum number of bones per vertex to influence a given vertex. You can set between 1 and 32 bones per vertex, but the higher the number of bones you use to influence a vertex, the greater the performance cost.

This setting is only available you set the Skin Weights property to Custom.

#### Max Bone Weight
Set the bottom threshold for considering bone weights. The weighting calculation ignores anything smaller than this value, and Unity scales up the bone weights higher than this value to a total of 1.0.

This setting is only available if the Skin Weights property is set to Custom.

#### Optimize Game Object
Remove and store the GameObject Transform hierarchy of the imported character in the Avatar and Animator component. If enabled, the SkinnedMeshRenderers of the character use the Unity animation system’s internal skeleton, which improves the performance of the animated characters.

Only available if the Avatar Definition is set to Create From This Model.

#### Extra Transforms to Expose
Specify which Transform paths you want Unity to ignore when Optimize Game Object is enabled. For more information, see Including extra Transforms.

This section only appears when Optimize Game Object is enabled.


### Humanoid animation types
Your rig is humanoid (it has two legs, two arms and a head)

Using **Unity’s Humanoid animation** features is to set up and configure an Avatar. Unity uses the Avatar to map the simplified humanoid bone structure to the actual bones present in the Model’s skeleton.

#### Configure…
Open the Avatar configuration.

> Only available if the Avatar Definition is set to Create From This Model.



https://docs.unity3d.com/Manual/FBXImporter-Rig.html
