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




https://docs.unity3d.com/Manual/FBXImporter-Rig.html
