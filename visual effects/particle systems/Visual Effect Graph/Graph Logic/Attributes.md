## Attributes
An Attribute is **a piece of data attached to elements in a System**. \
For example, the color of a particle, a particle's position, or the amount of particles that a spawn System creates are all Attributes.

**Systems can read from, or write to**, Attributes in order to perform custom behavior and differentiate between elements.

A **System only stores Attributes when it needs them**. This means that the System **does not store any unnecessary data** and thus saves memory.

### Writing Attributes

To write to an Attribute, use a Block. Blocks are the only graph elements that can write Attributes to the System.

The Visual Effect Graph only stores an Attribute that you write to in simulation data if a later Context reads the Attribute. This means that:

-   When you write to an Attribute in Initialize or Update Contexts, the Visual Effect Graph only stores the Attribute in simulation data if a later Update or Output Context reads from the Attribute.
-   When you write to an Attribute in Output Contexts, the Visual Effect Graph does not store the Attribute in simulation data and only uses the Attribute for rendering.

### Reading Attributes

To read from an Attribute, use an Operator or Block:

-   Use a **Get Attribute** Operator.
-   Use different composition modes in a **Set Attribute** Block that depends on the previous value of the Attribute.


### ref

https://docs.unity3d.com/Packages/com.unity.visualeffectgraph@17.0/manual/Attributes.html


