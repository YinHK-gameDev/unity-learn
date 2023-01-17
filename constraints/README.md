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
Use Weight to vary the influence of a Constraint. A weight of 1 causes the Constraint to update a GameObject at the same rate as its source GameObjects. A weight of 0 removes the effect of the Constraint completely. The strength of the Constraint. A weight of 1 causes the Constraint to move this GameObject at the same rate as its source GameObjects. A weight of 0 removes the effect of the Constraint completely. This weight affects all source GameObjects. Each GameObject in the Sources list also has a weight.

#### At Rest
In Constraint Settings, use the **At Rest** properties to specify the X, Y, and Z values to use when Weight is 0 or when the corresponding property in Freeze Axes is not checked.

#### Offset
Use the **Offset** properties in Constraint Settings to specify the X, Y, and Z values to use when constraining the GameObject.

####  Freeze Position Axes
Use the Freeze Axes settings to toggle which axes the Constraint can actually modify.

#### Active & Lock
You activate a Constraint to allow it to evaluate the position, rotation, or scale of the constrained GameObject. Unity does not evaluate inactive Constraints.

You lock a Constraint to allow it to move, rotate, or scale the GameObject. A locked Constraint takes control of the relevant parts of the Transform of the GameObject. You cannot manually move, rotate, or scale a GameObject with a locked Constraint. You also cannot edit the Constraint Settings.

- **Activate**: Saves the current offset from the source GameObjects, then activates and locks the constrained GameObject. Click activate to save this information. **Activate** saves the current offset from the source GameObjects

- **Zero**: Resets the position, rotation, or scale to match the source GameObjects, then activates and locks the constrained GameObject.







https://docs.unity3d.com/Manual/Constraints.html


