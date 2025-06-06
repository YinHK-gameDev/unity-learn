## Rigid body physics

To simulate physics-based behavior such as **movement, gravity, collision, and joints**, you need to add Rigid body. 

To configure **GameObject**s as rigid bodies in Unity’s PhysX system, you can assign them the **Rigidbody component**. The **Rigidbody component** is represented in the API by the **Rigidbody class**.

> Gameobject with motion **should add a rigid body**

https://docs.unity3d.com/Manual/RigidbodiesOverview.html

**Apply interpolation to a Rigidbody** \
Unity’s PhysX system provides a way to manage the appearance of jitter in the movement of your Rigidbody
GameObjects at run time.

Jitter can happen when the rate of physics simulation updates is slower than the application’s frame rate.

The Interpolate setting on a Rigidbody provides two options to **smooth the appearance of a Rigidbody’s motion** if it appears jittery at run time. These options are Interpolate and Extrapolate.

> interpolation setting is to **smooth the rigid body motion & avoid jitter**

**interpolation**:  Interpolate makes the Rigidbody appear to move slightly behind where it should be. This is because interpolation **delays the Rigidbody’s pose by one physics update**, so that it has two points to use for its calculation, and enough time to move the Rigidbody to the new pose. Interpolate is usually the best option for situations where the Rigidbody’s velocity varies, or if there are other physics elements that influence the Rigidbody’s movement

**Extrapolate**:  Extrapolate makes the Rigidbody appear to move slightly ahead of where it should be. This is because extrapolation uses the Rigidbody’s current velocity to predict the Rigidbody’s pose in the next physics update, so that it has two points to use for its calculation. Extrapolation is often less accurate. Extrapolate is usually only a good option for situations where accuracy is not important; for example, if the Rigidbody moves at a constant velocity, and there are no other physics elements that influence the Rigidbody’s movement.

https://docs.unity3d.com/Manual/rigidbody-interpolation.html

### Rigid body component
| Property | Function |
| --- | --- |
| Mass | Define the mass of the GameObject (in kilograms). **Mass is set to 1 by default**. As in real life, **mass does not affect how quickly an item falls under gravity**. To **simulate resistance forces** that slow down movement, use **Drag**. |
| Drag | Define the **decay rate of a Rigidbody’s linear velocity**, to **simulate drag, air resistance, or friction**. Low values **produce a slower decay rate**, so that the GameObject **moves faster** for **longer (this is useful for simulating heavy real-world objects)**. High values **produce a faster decay rate**, so that the GameObject **slows down over a short amount of time** (this is useful for **simulating lightweight real-world objects**). If **drag is zero**, **no friction** acting on the object. The object will **keep its inertia either moving or keep static**. **Drag** is a **coefficient that scales the damping force** based on the Rigidbody’s **velocity** and **mass**.|
| Angular Drag | Define the decay rate of a Rigidbody’s rotational velocity, to simulate drag, air resistance, or friction. Low values produce a slower decay rate, so that the GameObject moves faster for longer (this is useful for simulating heavy real-world objects). High values produce a faster decay rate, so that the GameObject slows down over a short amount of time (this is useful for simulating lightweight real-world objects). Note that you cannot make the GameObject stop rotating just by setting its Angular Drag to infinity. Angular Drag is set to 0.05 by default. |
| Use Gravity | Toggle the effects of gravity on the Rigidbody. If enabled, the physics system applies a force to move the GameObject in the direction of simulated gravity (by default, down the y axis). Use Gravity is enabled by default. Modifying the gravity can be set in **Project Setting > Physics**. |
| Is Kinematic | Toggle between physics-based and kinematic movement for the GameObject. When Is Kinematic is enabled, the physics system cannot apply forces to move or rotate the GameObject, instead, Unity can only move and rotate it via its Transform. See Introduction to Rigidbody physics: Rigidbody without physics-based movement for details. Is Kinematic is disabled by default. |
| Interpolate | The Interpolate setting on a Rigidbody provides two options to smooth the appearance of a Rigidbody’s motion if it appears jittery at run time. These options are Interpolate and Extrapolate.Both interpolation and extrapolation calculate the pose of the Rigidbody (that is, the position and rotation) between physics updates. Which one you should choose depends on which option produces the best visual outcome for your use case.For detailed information on the Interpolate property, see Apply interpolation to a Rigidbody. |
| - None | Apply no interpolation or extrapolation. This is the default option. |
| - Interpolate | Use the pose and velocity of the Rigidbody from the previous two physics updates to calculate and apply the pose of the Rigidbody in the current frame.Interpolate is more accurate than Extrapolate, but it has a time lag of one physics update. It’s usually best for situations where accuracy is important; for example, if the Rigidbody’s velocity varies, or if there are other physics elements that influence the Rigidbody’s movement. |
| - Extrapolate | Use the pose and velocity of the Rigidbody from the previous physics update, and predict the pose of the Rigidbody in the next physics update, to calculate and predict the pose in the current frame.Extrapolate makes the Rigidbody appear to move slightly ahead of where it should be, and can be slightly inaccurate. It’s usually best for situations where accuracy is not important; for example, if the Rigidbody moves at a constant velocity, and there are no other physics elements that influence the Rigidbody’s movement. |
| Collision Detection | Define how the physics system detects collisions between this Rigidbody’s collider and other colliders in the scene. Unity generates one collision per pair of colliders, and determines the method of collision detection based on this Collision Detection property.Collision Detection is set to **Discrete by default**. |
| - Discrete | The physics system uses **discrete collision detection** to calculate collisions for this Rigidbody’s collider. Select Discrete if this Rigidbody is **not involved in any fast-moving collisions**. Discrete collision detection is **not very computationally intensive**. |
| - Continuous | The physics system uses **sweep-based CCD** to calculate collisions between this **Rigidbody’s collider and any static colliders** (that is, colliders without an associated Rigidbody). Select Continuous if this Rigidbody is **involved in fast-moving collisions with static colliders**. **Sweep-based CCD** is **more computationally intensive** than **Discrete or Continuous** Speculative. |
| - Continuous Dynamic | The physics system uses **sweep-based CCD** to calculate collisions between this **Rigidbody’s collider and all other colliders**, except for those that are set to **Discrete collision detection**. Select **Continuous Dynamic** if this Rigidbody is involved in **fast-moving collisions with any colliders**. **Sweep-based CCD** is **more computationally intensive than Discrete or Continuous Speculative**. |
| - Continuous Speculative | The physics system uses **speculative continuous collision detection** to calculate collisions between this **Rigidbody’s collider and all other colliders**. Select Continuous Speculative if **collision accuracy is not important for this Rigidbody**. Speculative collision detection is **more computationally intensive than Discrete**, but **less computationally intensive than Continuous or Continuous Dynamic**. |
| Constraints | Place restrictions on the Rigidbody’s movement. |
| - Freeze Position | Stops the Rigidbody moving in the world X, Y and Z axes selectively. |
| - Freeze Rotation | Stops the Rigidbody rotating around the local X, Y and Z axes selectively. |

**Info section**:
| Property: | Function: |
| --- | --- |
| Speed | The speed at which the Rigidbody is moving, measured in meters per second (m/s). |
| Velocity | The velocity of the Rigidbody along each vector, measured in meters per second (m/s). |
| Angular Velocity | The velocity of the Rigidbody along each vector, measured in degrees per second. |
| Inertia Tensor | The inertia tensor of this Rigidbody. Like mass, an inertia tensor defines how much force or torque is required to make a Rigidbody move; however, while mass affects linear movement, inertia tensor affects rotational movement. The higher the Inertia Tensor value is, the more torque is required to make the Rigidbody rotate on its axis. |
| Inertia Tensor Rotation | The rotation of the inertia tensor. By default, Unity calculates inertia tensor rotation automatically, based on all of the colliders attached to the Rigidbody. |
| Local Center of Mass | The local location of the Rigidbody’s center of mass along each vector. You can change the center of mass via script (see ScriptRef:Rigidbody-centerOfMass.html, or Unity might change it based on collider placement. |
| World Center of Mass | The global location of the Rigidbody’s center of mass along each vector. You can change the center of mass via script (see ScriptRef:Rigidbody-centerOfMass.html, or Unity might change it based on collider placement. |
| Sleep State | The sleep state of the Rigidbody. Displays Awake if the Rigidbody is awake and included in physics calculations. Displays Asleep if the Rigidbody is asleep, and not included in physics calculations. |


### Constant Force component
Constant Force adds constant forces to a Rigidbody. This is useful for **GameObject movement that accelerates over time**.

| Property: | Function: |
| --- | --- |
| Force | Define the direction of the linear force. The XYZ vectors refer to the scene’s global axes. |
| Relative Force | Define the direction of the linear force. The XYZ vectors refer to the Rigidbody’s local axes. |
| Torque | Define the global axes that the Rigidbody rotates around. |
| Relative Torque | Define the local axes that the Rigidbody rotates around. |


### Apply constant force to a Rigidbody
To apply a **constant linear or rotational force** to a GameObject’s Rigidbody, add the **`Constant Force component`**.



To make a GameObject constantly accelerate forward (for example, to make it behave like a rocket), do the following:

1.  Add a **Constant Force component** to the GameObject.
2.  On the Constant Force component, set the **Relative Force** Z axis to a positive value.
3.  On the Rigidbody, disable **Use Gravity**. This ensures that there is no competing gravitational force acting upon the GameObject.
4.  On the Rigidbody component, set the **Drag** property so that the Rigidbody does not exceed your preferred maximum velocity (the higher the drag, the lower the maximum velocity will be). This might require some trial and error to get the effect you want.




#### Set maximum velocity limitations

When you apply a constant force, the speed of movement accelerates over time based on the value of the force. In real life, this acceleration continues indefinitely. By default in Unity’s physics simulation, linear acceleration continues indefinitely, and angular acceleration continues until the Rigidbody reaches a max velocity of **50 rad/s**.


> You can change these maximum velocities in code, via the properties **`Rigidbody.maxLinearVelocity`** and **`Rigidbody.maxAngularVelocity`**.


### Sleeping

When a **Rigidbody** is **moving slower than a defined minimum linear or rotational speed**, the physics engine assumes it has come to a **halt**. When this happens, the GameObject does not move again until it receives a collision or force, and so it is set to **"sleeping"  mode**. 


This optimisation means that **no processor time is spent updating the Rigidbody** until the next time it is **"awoken" (that is, set in motion again)**.

For most purposes, the sleeping and waking of a Rigidbody component happens transparently. However, a GameObject might fail to wake up if a Static Collider (that is, one without a Rigidbody) is moved into it or away from it by modifying the Transform position. This might result, say, in the Rigidbody GameObject hanging in the air when the floor has been moved out from beneath it. In cases like this, the GameObject can be woken explicitly using the WakeUp function. 


### centre of mass
The centre of mass is a position that is relative to an object. It is the mean location of mass distribution in space, or it is the average position of all the system parts. It’s a point where force is usually applied to produce linear acceleration rather than angular acceleration.

The centre of mass of a uniform disc shape, for example, would be at its centre. The object’s centre of mass does not always fall in the same place. The centre of mass of a ring, for example, is at its centre, where no material exists.

Two factors that determine the position of the centre of mass of a rigid body are:

- Body structure
- The mass distribution

These factors **determine whether the centre of mass is located inside or outside the body**. 

Inside the body, the body’s centre of mass is found in the physical structure (matter). But o

> **Note**: The centre of mass of an object or system is that point where any uniform force on the object acts.

###  Inertia Tensor

Inertia Tensor controls how hard it is to rotate a Rigidbody around its different axes (X, Y, Z). It’s like mass for rotation: \
Mass controls how hard it is to move an object in a straight line. \
Inertia Tensor controls how hard it is to spin or rotate an object.

- If the Inertia Tensor value is **large** on an axis → it's **hard to rotate** around that axis.
- If the Inertia Tensor value is **small** → it's **easy to rotate** around that axis.

1. x → rotation resistance around X axis
2. y → rotation resistance around Y axis
3. z → rotation resistance around Z axis

The inertia tensor is defined as a symmetric 3x3 matrix that describes the distribution of mass of an object in space.

Define the inertia tensor of this Rigidbody. The higher the Inertia Tensor value is, the more torque is required to make the Rigidbody rotate on its axis.

The inertia tensor of this body, defined as a diagonal matrix in a reference frame positioned at this body's center of mass and rotated by Rigidbody.inertiaTensorRotation.

Inertia tensor is a **rotational analog of mass**: the **larger** the inertia component about a particular axis is, the **more torque that is required** to achieve the same angular acceleration about that axis.

**Zero is not a valid inertia tensor component**. Therefore, the physics system interprets zeros as infinite values instead. So, for example, a body with (0, 1, 1) inertia tensor is impossible to rotate around X.

Units: **kg·m²** (moment of inertia for each axis) [].


### Scale of the object

In unity, mass doesn't affect fall speed- gravity and drag do. Also the scale of object can make object looks weird(if large scale make object slow speed for motion) while falling. If your object isn’t at real world scale. It will be wonky.

> Make sure your object scale in 1 as default

### ref
**Rigidbody Scripting API** \
https://docs.unity3d.com/ScriptReference/Rigidbody.html

**Falling too slow problem** \
https://www.reddit.com/r/Unity3D/comments/sijgzo/why_is_it_falling_so_slow/


**centre of mass**: \
https://unacademy.com/content/jee/study-material/physics/centre-of-mass-of-a-rigid-body/





