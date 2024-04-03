## Contexts

Contexts are the **main element of the Visual Effect Graph's processing (vertical) workflow** and determine how particles spawn and simulate.

Contexts connect to one another sequentially to define the lifecycle of particles. After a graph creates new particles, the Initialize Context can connect to an Update Particle Context to simulate each particle. Also, the Initialize Context can instead connect directly to an Output Particle Context to render the particles without simulating any behavior.


Contexts connect to one another sequentially to define the lifecycle of particles. After a graph creates new particles, the **Initialize** Context can connect to an **Update Particle** Context to simulate each particle. Also, the **Initialize** Context can instead connect directly to an **Output Particle** Context to render the particles without simulating any behavior.

#### Creating and connecting Contexts
A Context is a type of graph element so to create one, see Adding graph elements.

### ref 
https://docs.unity3d.com/Packages/com.unity.visualeffectgraph@17.0/manual/Contexts.html

