## Built-in Particle System

Built-in Particle System allows you to create effects for every platform that Unity supports. The Built-in Particle System simulates particle behavior on the **CPU** which allows for the following main benefits:

- You can use C# scripts to interact with a system and the individual particles within it.
- Particle systems can use **Unity’s underlying physics system** and thus interact with **Colliders** in your Scene.
 
 The Built-in Particle System uses a component, so placing a Particle System in a Scene is a matter of adding a pre-made GameObject (menu: **GameObject > Effects > Particle System**) or adding the component to an existing GameObject (menu: **Component > Effects > Particle System**).
 
### Particle effect panel
**Playback Speed**: \
Allows you to speed up or slow down the particle simulation, so you can quickly see how it looks at an advanced state.

**Playback Time**: \
Indicates the time elapsed since the system was started; this may be faster or slower than real time depending on the playback speed.

**Particle Count**: \
indicates how many particles are currently in the system. The playback time can be moved backwards and forwards by clicking on the Playback Time label and dragging the mouse left and right.


**Simulate Layers**: \
Allows you to preview Particle Systems that are not selected. By default, only selected Particle Systems play in the Scene View. However, when you set Simulate Layers to anything other than Nothing, effects that match the Layer Mask play automatically, without you needing to select them. This is particularly useful for previewing environmental effects.
 

**Resimulate**: \
When this property is enabled, the Particle System immediately applies property changes to particles it has already generated. When disabled, the Particle System leaves existing particles as they are, and only applies property changes to new particles.


**Show Bounds**: \
When this property is enabled, Unity displays the bounding volume around the selected Particle Systems. These bounds determine whether a Particle System is currently on screen or not.


**Show Only Selected**: \
When this property is enabled, Unity hides all non-selected Particle Systems, allowing you to focus on producing a single effect.



### Varying properties over time

Many of the numeric properties of particles or even the whole Particle System can vary over time. Unity provides several different methods of specifying how this variation happens:

- **Constant**: \
 The property’s value is fixed throughout its lifetime.
- **Curve**: \
 The value is specified by a curve/graph.
- **Random Between Two Constants**: \
 Two constant values define the upper and lower bounds for the value; the actual value varies randomly over time between those bounds.
- **Random Between Two Curves**: \
 Two curves define the upper and lower bounds of the value at a given point in its lifetime; the current value varies randomly between those bounds.
 
 
### Particle System modules

Because the component is quite complicated, the Inspector is divided into a number of collapsible sub-sections or modules that each contain a group of related properties.


### Properties
The Particle System component has many properties, and for convenience, the Inspector organises them into collapsible sections called “modules”. 

![](./PartSysMainInsp.png)

To expand and collapse modules, click the bar that shows their name. Use the checkbox on the left to enable or disable the functionality of the properties in that module. For example, if you don’t want to vary the sizes of particles over their lifetime, uncheck the Size over Lifetime module.

The Open Editor button displays the options in a separate Editor window, which allows you to edit multiple systems at once.

https://docs.unity3d.com/Manual/ParticleSystemModules.html


### Particle System Force Field
The Particle System Force Field component **applies forces to particle**s in Particle Systems. To attach this component to a Particle System, enable the External Forces Module in the Particle System, and assign either a Layer Mask, or the specific Force Field component.

https://docs.unity3d.com/Manual/class-ParticleSystemForceField.html


### Scripting API
https://docs.unity3d.com/ScriptReference/ParticleSystem.html
