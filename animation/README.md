### Animation 


### Animation System

Unity has a rich and sophisticated animation system (sometimes referred to as ‘Mecanim’). It provides:

- Easy workflow and setup of animations for all elements of Unity including objects, characters, and properties.
- Support for imported animation clips and animation created within Unity Humanoid animation retargeting -the ability to apply animations from one character model onto another.
- Simplified workflow for aligning animation clips.
- Convenient preview of animation clips, transitions and interactions between them. This allows animators to work more independently of programmers, prototype and preview their animations before gameplay code is hooked in.
- Management of complex interactions between animations with a visual programming tool.
- Animating different body parts with different logic.
- Layering and masking features



https://docs.unity3d.com/Manual/AnimationOverview.html

### Tutotial

https://learn.unity.com/tutorial/may-18-animation#

https://learn.unity.com/tutorial/create-your-first-3d-animations?uv=2020.3&projectId=61b9e300edbc2a24a5bbc17d#619cd5e3edbc2a057ec985c4

https://learn.unity.com/search?k=%5B%22q%3AAnimation%22%5D

https://www.youtube.com/watch?v=vApG8aYD5aI

https://www.youtube.com/watch?v=JVFg9g4f-ME

**To animate 2D:** \
https://www.youtube.com/watch?v=oebtkjwjkcs


### Create your animations
1.  In the scenes folder, locate and open ChallengeScene_Animation.
2.  Review the scene and consider the narrative you might be able to communicate through different animations.
3.  Identify several items that you can animate. You must create a minimum of five keyframed animations, but multiple animations can be on the same object, so long as you create an Animator Controller that will allow someone to see them all.
4.  Identify a character in the scene that you wish to animate. Source a minimum of three animations online or on the Unity Asset Store.
5.  Use either the AnimatorControllerTriggers script or the DanceParty script to control the animator with keystrokes.
6.  Create your keyframed animations and configure the Animator Controller as needed.
7.  Configure your imported animations for the humanoid animation system and add them to your selected character’s Animator Controller (they’re all using the SharedController Animator Controller from the previous tutorial).
8.  Once you’ve completed your animations, record a video showing them all off! 
9.  If you’d like to share your hard work with the community here on Learn, submit your video! 

### Trigger animation

In the Scripts folder, you’ll find a script called AnimatorControllerTriggers. This script was designed for you to edit so you can trigger animations to occur for your characters and objects based on keyboard input. 
To edit the script:
1.  Open AnimatorControllerTriggers in Visual Studio by double-clicking the script in the scripts folder.
2.  Scroll down to the Update method and find the section that directs you to duplicate the code block.
3.  Select the code block, being sure to highlight the closing curly brace ( } ), and copy it with Ctrl/Cmd+C
4.  Paste your new block several lines below the existing code block, but still inside the Update method (stay inside the second to last curly brace in the script).
5.  Replace the A in Keycode.A with whatever key you wish. You can see a full list of available keys here.
6.  In the anim.SetTrigger line, replace YOUR_TRIGGER_NAME_HERE_INSIDE_THE_QUOTES with the name of the parameter you wish to have called when the keyboard key is pressed.
7.  Save the script.
8.  Add the script to the object that the Animator Controller is attached to.



### Legacy Animation system
Unity’s Legacy Animation system is a simpler alternative to Unity’s animation system.


The **animation component** is used to **play back animations**. This is the Legacy Animation component, which was used on GameObjects
 for animation purposes prior to the introduction of Unity’s current animation system. This component is retained in Unity for backwards-compatibility only. For new projects, please use the **Animator component**.

You can assign animation clips to the animation component and control playback from your script. The animation system in Unity is weight-based and supports Animation Blending, Additive animations, Animation Mixing, Layers and full control over all aspects of playback.


https://docs.unity3d.com/Manual/Animations.html

### Free animation tools
- **Blender**
- **Adobe Mixamo**:   https://www.mixamo.com/#/

**用Mixamo自動幫模型綁骨架+動畫--詳細流程教學**
https://youtu.be/88qbApTkclM
