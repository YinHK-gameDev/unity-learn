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

