## Multi-scene physics
You can use multiple physics Scenes to manage or work around complex physics contexts. In particular, you can create and set up independent Scenes with physics properties that are different from those of the main scene.


### Example for using 
- You can instantiate multiple physics Scenes based on the main Scene in order to predict GameObject collisions and trajectories.
- You can isolate a very detailed character in its own physics Scene to more easily filter its collisions with elements of other physics Scenes.
- You can create pre-populated physics Scenes to be able to entirely destroy and reload them in order to improve determinism in your physics environment.

### Creating and using independent physics Scenes
You can use Multi-Scene editing to create multiple Scenes in general (although you can also instantiate them by script). However, you have to use the Unity scripting API to use independent physics Scenes in runtime.

More precisely, to get the expected physics results, you must **write a script that takes care at least of the following tasks for each separate physics Scene:**

1.  Load the Scene so that it’s **independent from the main Scene**.
2.  Get the **Scene physics** to set up the **physics properties** that you want to make different from the main Scene.




### ref
https://docs.unity3d.com/Manual/physics-multi-scene.html

https://www.youtube.com/watch?v=GLu1T5Y2SSc

https://www.youtube.com/watch?v=DcGiUcfLbes&t=1s


