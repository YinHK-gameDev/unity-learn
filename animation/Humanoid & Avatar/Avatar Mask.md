## Avatar Mask

### What is an Avatar Mask?
- In Unity, an Avatar Mask is an asset that defines which bones or transforms are included/excluded when an animation layer plays.
- It’s the file you assign in Animator Layers to make partial-body animations work.
- The Mask property is to specify the mask used on animation layer. For example if you wanted to play a throwing animation on just the upper body of your model, while having your character also able to walk, run or stand still at the same time, you would use a mask on the layer which plays the throwing animation where the upper body sections are defined.


To create an empty Avatar Mask Asset, you can either:

- Choose **Create > Avatar Mask** from the **Assets** menu.
- Click the Model object you want to define the mask on in the **Project view**, and then right-click and choose **Create > Avatar Mask**.

### Create an Avatar Mask (Editor Workflow)
1. Right-click in Project **Window → Create → Avatar Mask**.
2. In the Inspector: 
   - **Humanoid rig** → You’ll see checkboxes for body parts (Head, Arms, Legs, etc.).
   - **Generic rig** → You can manually expand the Transform hierarchy and check/uncheck bones.
3. Assign this **Avatar Mask to an Animator Layer** **(Window → Animator → Layers → select the layer → add mask**). \
Example: Upper Body layer uses an Avatar Mask that includes only “Spine → Arms → Hands”.

#### Two ways to define which parts of your animation should be masked:
1. By selecting from a **Humanoid body** map.
2. By choosing which bones to include or exclude from a **Transform hierarchy**.

#### Transform hierarchy
If your animation **does not use a Humanoid Avatar**, or if you **want more detailed control over which individual bones are masked**, you can **select or deselect portions of the Model’s transform hierarchy**:

1. Assign a reference to the Avatar whose transform you would like to mask.
2. Click the Import Skeleton button. The hierarchy of the avatar appears in the inspector.
3. You can check each bone in the hierarchy to use as your mask

### Creating & Using Avatar Mask at Runtime (via Script)

```cs
using UnityEngine;

public class RuntimeMaskTest : MonoBehaviour
{
    public Animator animator;

    void Start()
    {
        // Create a new AvatarMask in memory
        AvatarMask mask = new AvatarMask();

        // Example: Enable root (index 0) and its children
        mask.AddTransformPath(animator.transform, true);

        // Disable a specific bone (e.g., left arm)
        Transform leftArm = animator.GetBoneTransform(HumanBodyBones.LeftUpperArm);
        if (leftArm != null)
            mask.AddTransformPath(leftArm, false);

        // Apply to an Animator Layer
        animator.SetLayerWeight(1, 1f); // Make sure layer 1 exists
        animator.layers[1].avatarMask = mask; // ❌ (AnimatorController is read-only)
    }
}

```
