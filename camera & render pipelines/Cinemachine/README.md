## Cinemachine

Cinemachine is a suite of modules for operating the Unity camera. Cinemachine solves the **complex mathematics and logic of tracking targets, composing, blending, and cutting between shots**.

Cinemachine enables you to create complex 3D camera setups, allowing movement and cuts between multiple cameras.

It allows you to iterate and prototype new ideas on the fly while saving settings in play mode. From first-person shooter to follow cam, from 2D to 3D, from real-time play to cutscene

> Use the Unity Package Manager (in the top menu: **Window > Package Manager**) to select Cinemachine for installation.



### Virtual Cameras

Cinemachine does not create new cameras. Instead, it directs a single Unity camera for multiple shots. You compose these shots with **Virtual Cameras**. Virtual Cameras move and rotate the Unity camera and control its settings.

The Virtual Cameras are separate GameObjects from the Unity Camera, and behave independently. They are not nested within each other.

The main tasks that the Virtual Camera does for you:

-   Positions the Unity camera in the Scene.
-   Aims the Unity camera at something.
-   Adds procedural noise to the Unity camera. Noise simulates things like handheld effects or vehicle shakes.

Cinemachine encourages you to create many Virtual Cameras. The Virtual Camera is designed to consume little processing power. If your Scene is performance-sensitive, deactivate all but the essential Virtual Cameras at any given moment for best performance.

It is recommended that you use a single Virtual Camera for a single shot. Take advantage of this to create dramatic or subtle cuts or blends. Examples:

-   For a cutscene where two characters exchange dialog, use three Virtual Cameras: one camera for a mid-shot of both characters, and separate Virtual Cameras for a close-up of each character. Use Timeline to synchronize audio with the Virtual Cameras.
    
-   Duplicate an existing Virtual Camera so that both Virtual Cameras are in the same position in the Scene. For the second Virtual Camera, change the FOV or composition. When a player enters a trigger volume, Cinemachine blends from the first to the second Virtual Camera to emphasize a change in action.
    

One Virtual Camera has control of the Unity camera at any point in time. This is the **live** Virtual Camera. The exception to this rule is when a blend occurs from one Virtual Camera to the next. During the blend, both Virtual Cameras are live.


### Usage and tutorial
https://delightcollab.com/programming-tpl-cinemachine-tutorial-2022/


### ref
https://unity.com/unity/features/editor/art-and-design/cinemachine

https://docs.unity3d.com/Packages/com.unity.cinemachine@2.4/manual/index.html

https://docs.unity3d.com/Packages/com.unity.cinemachine@2.4/manual/CinemachineUsing.html

