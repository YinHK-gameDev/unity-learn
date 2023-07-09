## Ragdoll physics

Ragdoll physics are a **set of colliders**, **rigid bodies** and **joints**
that you can apply to a **humanoid character**, to simulate behaviour such as **impact collisions** and **character death**.

Unity provides a **"Ragdoll Wizard"** that allows you to configure ragdoll physics behaviours on your character.


### Create a ragdoll

Just drag the different limbs on the respective properties in the wizard. Then select create and Unity will automatically generate all **Colliders**, 
**Rigidbodies** and **Joints** that make up the **Ragdoll** for you.

When you’ve created your character and rigged it, save the asset normally in your **Project Folder**. When you switch to Unity, you’ll see the character asset file. Select that file and the **Import Settings** dialog will appear inside the
 inspector. Make sure that **Mesh Colliders** is **not enabled**.

#### Using Ragdoll Wizard
It’s not possible to make the actual source asset into a ragdoll. This would require modifying the source asset file, and is therefore impossible. You will make an instance of the character asset into a ragdoll, which can then be saved as a **Prefab**
 for **re-use**.

Create an instance of the character by dragging it from the **Project View** to the **Hierarchy View**. Expand its **Transform Hierarchy** by clicking the small arrow to the left of the instance’s name in the Hierarchy. Now you are ready to start assigning your ragdoll parts.

Open the Ragdoll Wizard by choosing **GameObject > 3D Object > Ragdoll…** from the menu bar. You will now see the Wizard itself.

Drag the different Transforms of your character instance to the appropriate property on the wizard

When you are done, click the **Create Button**. Now when you enter **Play Mode**, you will see your character go limp as a ragdoll.

The final step is to save the setup **ragdoll** as a **Prefab**. Choose **Assets > Create > Prefab** from the menu bar. You will see a New Prefab appear in the Project View. Rename it to **"Ragdoll Prefab"**. 
Drag the ragdoll character instance from the Hierarchy **on top** of the **"Ragdoll Prefab"**. You now have a completely set-up, re-usable **ragdoll character** to use as much as you like in your game.


### ref
https://docs.unity3d.com/Manual/ragdoll-physics-section.html

https://docs.unity3d.com/Manual/wizard-RagdollWizard.html

https://www.youtube.com/watch?v=DInV-jHm9rk

https://www.youtube.com/watch?v=KuMe6Iz8pFI

https://www.youtube.com/watch?v=Iyqo-hjLg20

https://www.youtube.com/watch?v=4_QCbilpOzQ

**Improving Joint and Ragdoll stability** \
https://docs.unity3d.com/Manual/RagdollStability.html

