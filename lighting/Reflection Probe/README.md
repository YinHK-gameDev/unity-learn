## Reflection Probes

Traditionally, games have used a technique called ***reflection mapping*** to simulate reflections from objects while keeping the processing overhead to an acceptable level. 

This technique assumes that all reflective objects in the scene can **see** (and therefore reflect) the exact same surroundings.

This works quite well for the game’s main character (a shiny car, say) if it is in open space but is unconvincing when the character passes into different surroundings; it looks strange if a car drives into a tunnel but the sky is still visibly reflected in its windows.




**Unity improves on basic reflection mapping** through the use of **Reflection Probes**, which **allow the visual environment to be sampled at strategic points** in the scene.

You should generally place them at every point where the appearance of a reflective object would change noticeably (**eg, tunnels, areas near buildings and places where the ground colour changes**). 





### ref
https://www.youtube.com/watch?v=lhELeLnynI8

https://docs.unity3d.com/Manual/ReflectionProbes.html

