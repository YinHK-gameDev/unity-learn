## postion, rotation, scaling & view

### For position
Use the dropdown menu to switch between Pivot and Center.

**Pivot positions** the Gizmo at the actual **pivot point of the GameObject**, as defined by the Transform component. \
**Center positions** the Gizmo at a **center position** based on the **selected GameObjects**.

### For rotation
Use the dropdown menu to switch between Local and Global.

- **Local** keeps the Gizmo’s rotation relative to the GameObject’s.
- **Global** clamps the Gizmo to world space orientation.


### Pivot vs. Center of a game object:

**Pivot**: indicates
- the **reference point for positioning, rotating and scaling a game object**.  The Pivot Point determines the location of the Gizmo

**Center**: indicates
- the **average center / middle point of a game object’s geometry** or it’s hierarchy.

We can transform a game object with respect to its pivot or with respect to its center
Pivot / Center toggle button:
- switches the gizmo between pivot or center of the game object

> **Note**: By default any game object's pivot and center will be at the current position of the game object.
On parenting a parent game object’s pivot will be at the current position of the game object, & it's center will be shifted to average center / middle point of its hierarchy.

### Difference between world coordinates and local coordinates

-   **World coordinates**: These are absolute coordinates of where the game object is located (with respect to the world frame, which is considered to be absolute in the game)
-   **Local coordinates**: These are the coordinates of where the game object is with **respect to its parent**





