## Physic Material

When two colliders are in contact, the physics system uses the **surface properties of each collider 
to calculate the total friction and bounce** between the two surfaces.

In Unity, you use the **Physic Material** asset to control these parameters. 
The Physic Material asset is represented in the API by the **`PhysicMaterial`** class.
 
The Physic Material adjusts friction and bouncing effects of colliding GameObjectsThe fundamental object 
in Unity scenes, which can represent characters, props, scenery, cameras, waypoints, 
and more. A GameObject’s functionality is defined by the Components attached to it.

### Create and apply a custom Physic Material

You can create as many **custom Physic Material assets** as you need, and **apply them to colliders** in your scene.

Several colliders can have the same Physic Material asset assigned to them, and you can set a project-wide default to apply new default settings to all colliders in the project.


#### Create a custom Physic Material asset

To create a Physic Material asset, go to **Assets** > **Create** > **Physic Material**. By default, Unity places new Physic Material assets in your `Assets` directory.

> You can create as many custom Physic Material assets as you need. **Physic Material** assets have the file extension **`.physicMaterial`**.

![](./img/Physics_material1.png)

![](./img/Physics_material2.png)


| Property | Description |
| --- | --- |
| **Dynamic Friction** | Define **how much friction the collider’s surface has against another collider when the colliders are moving or sliding against each other**. This value is **between 0 and 1**. A **value of 0 means no friction** (like ice), while a **value of 1 means very high friction** (like rubber). **By default, Dynamic Friction is set to 0.6**.  Unity uses the friction value of both **touching colliders to calculate the friction between the**m, based on the Friction Combine property.|
| **Static Friction** | Define **how much friction the collider’s surface has against another collider when the colliders are not moving**. This value is **between 0 and 1**. A **value of 0 means no friction** (like ice), while **a value of 1 means very high friction** (like rubber). By default, S**tatic Friction is set to 0.6**.  Unity uses the friction value of both **touching colliders to calculate the friction between them**, based on the **Friction Combine property**. |
| **Bounciness** | Define **how bouncy the surface is**, and **how much other colliders can bounce off it**. A **value of 0 means the surface is not at all bouncy** (like soft clay), and other colliders **lose kinetic energy upon hitting it**. A **value of 1 means the surface is very bouncy** (like rubber), and **other colliders bounce without any loss of kinetic energy**. By default, **Bounciness is set to 0**.  Unity uses the **friction value of both touching colliders to calculate the friction between them**, based on the **Friction Combine property**. Note that the physics system’s bounce approximations might still add small amounts of energy to the simulation. |
| **Friction Combine** | Define **how the physics system calculates friction between two colliders**, **based on each collider’s friction**. This selection applies to both **Dynamic Friction** and **Static Friction**. By default, Friction Combine is set to **Averag**e.|
| **Bounce Combine** | Define **how the physics system calculates bounce between two colliders**, based on **each collider’s Bounciness value**. By default, Bounce Combine is set to **Averag**e.|

The Physic Material asset provides two properties: \
**Friction Combine** (**`PhysicMaterial.frictionCombine`**) and **Bounce Combine** (**`PhysicMaterial.bounceCombine`**). 
These properties each provide four options to control how the physics system calculates the total friction and bounce between two colliders:


| Priority | Property | Description |
| --- | --- | --- |
| 1 | Maximum | Use the largest of the two values. |
| 2 | Multiply | Use the sum of one value multiplied by the other. |
| 3 | Minimum | Use the smallest of the two values. |
| 4 | Average | Use the mean average of the two values; that is, the sum of both values, divided by two. |

> **Friction Combine** applies to both **Dynamic Friction** and **Static Friction**.


#### Apply a custom Physic Material asset to a collider

To apply a Physic Material asset to a collider:

1.  Navigate to the target **collider’s** **Material** property.
2.  In the **Material** property field, select the picker icon.
3.  Select the **Physic Material asset** you want to use.

> Alternatively, you can **click and drag the Physic Material asset file directly** from the Project window onto the target collider’s Material field.


> Each collider can only have **one assigned Physic Material asset at a time**. You can assign the **same Physic Material asset to multiple collider**s.


#### Set a custom Physic Material asset as the project default

You can use a custom Physic Material asset to replace the project-wide **default settings**. Unity applies the project-wide default settings to any collider that does not have an assigned Physic Material asset.

To **change the default Physic Material values**: 
1. Create a Physic Material asset and configure it to the default settings you want for the project. 2. Go to the Physics Settings (**Edit** > **Project Settings** > **Physics**).
3. In the **Default Material** property field, select the **picker** icon.
4. Select the **Physic Material** you want to use.







### ref 
https://docs.unity3d.com/Manual/collider-surfaces-combine.html \
https://docs.unity3d.com/Manual/create-apply-physics-material.html \
https://docs.unity3d.com/Manual/class-PhysicMaterial.html \
https://docs.unity3d.com/Manual/collider-surfaces-combine.html
