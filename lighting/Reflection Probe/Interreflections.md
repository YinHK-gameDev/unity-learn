## Interreflections
You may have seen a situation where two mirrors are placed fairly close together and facing each other. Both mirrors reflect not only the mirror opposite but also the reflections produced by that mirror. The result is an endless progression of reflections between the two; reflection between objects like this are known as **Interreflections**.

The number of times that a reflection can **"bounce"** back and forth between two objects is controlled in the 
**Lighting window**; go to **Environment > Environment Reflections** and edit the **Bounces** property. 
This is set globally for all probes, rather than individually for each probe. With a reflection bounce **count of 1**, 
reflective objects viewed by a probe are shown as black. With a **count of 2**, the first level of interreflection 
are visible, with a **count of 3**, the first two levels will be visible, and so on.
 
 
> **Note**: the reflection bounce count also equals the number of times the probe must be baked with a corresponding increase in the time required to complete the full bake. You should therefore set the count higher than one only when you know that reflective objects will be clearly visible in one or more probes.





https://docs.unity3d.com/Manual/AdvancedRefProbe.html


