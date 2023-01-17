## Constraints

A Constraint component links the position, rotation, or scale of a GameObject
 to another GameObject. A constrained GameObject moves, rotates, or scales like the GameObject it is linked to.

Unity supports the following types of Constraint components:

- **Aim**: Rotate the constrained GameObject to face the linked GameObject.
- **Look At**: Rotate the constrained GameObject to the linked GameObject (simplified Aim Constraint).
- **Parent**: Move and rotate the constrained GameObject with the linked GameObject.
- **Position**: Move the constrained GameObject like the linked GameObject.
- **Rotation**: Rotate the constrained GameObject like the linked GameObject.
- **Scale**: Scale the constrained GameObject like the linked GameObject.

### Setting Constraint properties
#### Weight
Use Weight to vary the influence of a Constraint. A weight of 1 causes the Constraint to update a GameObject at the same rate as its source GameObjects. A weight of 0 removes the effect of the Constraint completely. Each source GameObject also has an individual weight.

#### At Rest
In Constraint Settings, use the **At Rest** properties to specify the X, Y, and Z values to use when Weight is 0 or when the corresponding property in Freeze Axes is not checked.

#### Offset
Use the **Offset** properties in Constraint Settings to specify the X, Y, and Z values to use when constraining the GameObject.

####  Freeze Position Axes
Use the Freeze Axes settings to toggle which axes the Constraint can actually modify.


https://docs.unity3d.com/Manual/Constraints.html


