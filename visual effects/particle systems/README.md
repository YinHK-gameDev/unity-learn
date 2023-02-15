## Particle systems
A particle system **simulates and renders many small images or Meshes**, called particles, to produce a visual effect.

Each particle in a system represents an individual graphical element in the effect. The system simulates every particle collectively to create the impression of the complete effect.


Particle systems are useful when you want to create dynamic objects like fire, smoke, or liquids because it is difficult to depict this kind of object with a Mesh(3D) or Sprite(2D). Meshes and Sprites are better at depicting solid objects such as a house or a car.


To provide flexibility when you author a particle system
, Unity offers two solutions to choose from. If your Project targets platforms that support Compute Shaders, Unity allows you to use both at the same time. The two particle system solutions are:

- **The Built-in Particle System**: \
  A solution that gives you full read/write access to the system, and the particles it contains, from C# scripts. You can use the Particle System API to create custom behaviors for your particle system.
- **The Visual Effect Graph**: \
  A solution that can run on the GPU to simulate millions of particles and create large-scale visual effects. The Visual Effect Graph also includes a visual graph editor to help you author highly customizable visual effects.

| Feature | Built-in Particle System | Visual Effect Graph |
| --- | --- | --- |
| Render Pipeline compatibility | Built-in Render Pipeline, Universal Render Pipeline, High Definition Render Pipeline | Universal Render Pipeline, High Definition Render Pipeline |
| Feasible number of particles | Thousands | Millions |
| Particle system authoring | Simple modular authoring process that uses the Particle System component in the Inspector. Each module represents a predefined behavior for the particle. | Highly customizable authoring process that uses a graph view. |
| Physics | Particles can interact with Unity’s underlying physics system. | Particles can interact with specific elements that you define in the Visual Effect Graph. For example, particles can interact with the depth buffer. |
| Script interaction | You can use C# scripts to fully customize the Particle System at runtime. You can read from and write to each particle in a system, and respond to collision events. The Particle System component also provides playback control API. This means that you can use scripts to play and pause the effect, and simulate the effect with custom step sizes. | You can expose graph properties and access them through C# scripts to customize instances of the effect. You can also use the Event Interface to send custom events with attached data that the graph can process. The Visual Effect component also provides playback control API. This means that you can use scripts to play and pause the effect, and simulate the effect with custom step sizes. |
| Frame buffers | No | In the High Definition Render Pipeline, provides access to the color and depth buffer. For example, you can sample the color buffer and use the result to set particle color, or you can use the depth buffer to simulate collisions. |




