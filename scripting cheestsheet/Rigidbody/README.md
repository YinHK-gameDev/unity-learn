## Rigidbody
> Adding a **Rigidbody component** to an object will **put its motion under the control of Unity's physics engine**. 

Even without adding any code, a Rigidbody object will be **pulled downward by gravity** and will react to collisions with incoming objects if the right Collider component is also present.

The Rigidbody also has a scripting API that lets you apply forces to the object and control it in a physically realistic way.

### Comon use 

#### `Rigidbody.linearVelocity`
The velocity vector of the rigidbody. It represents the rate of change of Rigidbody position.

#### `Rigidbody.position`
`Rigidbody.position` allows you to get and set the position of a Rigidbody using the physics engine.

#### `Rigidbody.rotation`
The rotation of the Rigidbody.

Use `Rigidbody.rotation` to get and set the rotation of a Rigidbody using the physics engine.

#### `Rigidbody.isKinematic`
Controls whether physics affects the rigidbody. \
If `isKinematic` is **enabled**, **Forces, collisions or joints will not affect the rigidbody anymore**.

#### `AddForce`
Adds a force to the Rigidbody.

Just a force pushing an object.

- Applies a force to the center of mass of the Rigidbody.
- Only causes linear motion (i.e. translation, no spin).

**Great for:**
- Moving an object forward.
- Simulating pushing something straight.

```cs
public void AddForce(Vector3 force, ForceMode mode = ForceMode.Force);
```

### `AddForceAtPosition`
**Applies force at position**. As a result this will apply a **torque** and **force** on the object.

Applies a force at a **specific point in world space**, **not just the center of mass**. \
**Can cause both**: 
- ✅ Linear motion (translation)
- ✅ Angular motion (rotation/torque) if the point is off-center

📌 **Useful for**: 
- Simulating a **torque effect** (e.g. a door swinging when pushed off-center)
- **Making a vehicle tilt** or **spin** when force is unevenly applied

#### Quick Comparison
| **Feature**	| `AddForce` |	`AddForceAtPosition` |
| -	| - |	- |
| **Applies force to…**	| Center of mass |	Specific world position |
| **Can cause rotation?** |	❌ No	 | ✅ Yes (if offset from center) |
| **Physics use case examples** |	Rocket thrust, constant push |	Poking, hitting, torque effects |


#### `AddTorque`
Adds a torque to the rigidbody.

Force can be applied only to an active rigidbody. If a GameObject is inactive, AddTorque has no effect.

 use the AddTorque function to add a **rotational force** onto the object.
 Torque is rotational force. Think of an imaginary axle that spins the object.

```cs
public void AddTorque(Vector3 torque, ForceMode mode = ForceMode.Force);
```

### Properties

<table class="list"><tbody><tr><td class="lbl"><a href="https://docs.unity3d.com/2023.3/Documentation/ScriptReference/Rigidbody.htmlRigidbody-angularDamping.html">angularDamping</a></td><td class="desc">The angular damping of the object.</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/2023.3/Documentation/ScriptReference/Rigidbody.htmlRigidbody-angularVelocity.html">angularVelocity</a></td><td class="desc">The angular velocity vector of the rigidbody measured in radians per second.</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/2023.3/Documentation/ScriptReference/Rigidbody.htmlRigidbody-automaticCenterOfMass.html">automaticCenterOfMass</a></td><td class="desc">Whether or not to calculate the center of mass automatically.</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/2023.3/Documentation/ScriptReference/Rigidbody.htmlRigidbody-automaticInertiaTensor.html">automaticInertiaTensor</a></td><td class="desc">Whether or not to calculate the inertia tensor automatically.</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/2023.3/Documentation/ScriptReference/Rigidbody.htmlRigidbody-centerOfMass.html">centerOfMass</a></td><td class="desc">The center of mass relative to the transform's origin.</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/2023.3/Documentation/ScriptReference/Rigidbody.htmlRigidbody-collisionDetectionMode.html">collisionDetectionMode</a></td><td class="desc">The Rigidbody's collision detection mode.</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/2023.3/Documentation/ScriptReference/Rigidbody.htmlRigidbody-constraints.html">constraints</a></td><td class="desc">Controls which degrees of freedom are allowed for the simulation of this Rigidbody.</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/2023.3/Documentation/ScriptReference/Rigidbody.htmlRigidbody-detectCollisions.html">detectCollisions</a></td><td class="desc">Should collision detection be enabled? (By default always enabled).</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/2023.3/Documentation/ScriptReference/Rigidbody.htmlRigidbody-excludeLayers.html">excludeLayers</a></td><td class="desc">The additional layers that all Colliders attached to this Rigidbody should exclude when deciding if the Collider can come into contact with another Collider.</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/2023.3/Documentation/ScriptReference/Rigidbody.htmlRigidbody-freezeRotation.html">freezeRotation</a></td><td class="desc">Controls whether physics will change the rotation of the object.</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/2023.3/Documentation/ScriptReference/Rigidbody.htmlRigidbody-includeLayers.html">includeLayers</a></td><td class="desc">The additional layers that all Colliders attached to this Rigidbody should include when deciding if the Collider can come into contact with another Collider.</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/2023.3/Documentation/ScriptReference/Rigidbody.htmlRigidbody-inertiaTensor.html">inertiaTensor</a></td><td class="desc">The inertia tensor of this body, defined as a diagonal matrix in a reference frame positioned at this body's center of mass and rotated by Rigidbody.inertiaTensorRotation.</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/2023.3/Documentation/ScriptReference/Rigidbody.htmlRigidbody-inertiaTensorRotation.html">inertiaTensorRotation</a></td><td class="desc">The rotation of the inertia tensor.</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/2023.3/Documentation/ScriptReference/Rigidbody.htmlRigidbody-interpolation.html">interpolation</a></td><td class="desc">Interpolation provides a way to manage the appearance of jitter in the movement of your Rigidbody GameObjects at run time.</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/2023.3/Documentation/ScriptReference/Rigidbody.htmlRigidbody-isKinematic.html">isKinematic</a></td><td class="desc">Controls whether physics affects the rigidbody.</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/2023.3/Documentation/ScriptReference/Rigidbody.htmlRigidbody-linearDamping.html">linearDamping</a></td><td class="desc">The linear damping of the object.</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/2023.3/Documentation/ScriptReference/Rigidbody.htmlRigidbody-linearVelocity.html">linearVelocity</a></td><td class="desc">The linear velocity vector of the rigidbody. It represents the rate of change of Rigidbody position.</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/2023.3/Documentation/ScriptReference/Rigidbody.htmlRigidbody-mass.html">mass</a></td><td class="desc">The mass of the rigidbody.</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/2023.3/Documentation/ScriptReference/Rigidbody.htmlRigidbody-maxAngularVelocity.html">maxAngularVelocity</a></td><td class="desc">The maximum angular velocity of the rigidbody measured in radians per second. (Default 7) range { 0, infinity }.</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/2023.3/Documentation/ScriptReference/Rigidbody.htmlRigidbody-maxDepenetrationVelocity.html">maxDepenetrationVelocity</a></td><td class="desc">Maximum velocity of a rigidbody when moving out of penetrating state.</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/2023.3/Documentation/ScriptReference/Rigidbody.htmlRigidbody-maxLinearVelocity.html">maxLinearVelocity</a></td><td class="desc">The maximum linear velocity of the rigidbody measured in meters per second.</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/2023.3/Documentation/ScriptReference/Rigidbody.htmlRigidbody-position.html">position</a></td><td class="desc">The position of the rigidbody.</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/2023.3/Documentation/ScriptReference/Rigidbody.htmlRigidbody-rotation.html">rotation</a></td><td class="desc">The rotation of the Rigidbody.</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/2023.3/Documentation/ScriptReference/Rigidbody.htmlRigidbody-sleepThreshold.html">sleepThreshold</a></td><td class="desc">The mass-normalized energy threshold, below which objects start going to sleep.</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/2023.3/Documentation/ScriptReference/Rigidbody.htmlRigidbody-solverIterations.html">solverIterations</a></td><td class="desc">The solverIterations determines how accurately Rigidbody joints and collision contacts are resolved. Overrides Physics.defaultSolverIterations. Must be positive.</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/2023.3/Documentation/ScriptReference/Rigidbody.htmlRigidbody-solverVelocityIterations.html">solverVelocityIterations</a></td><td class="desc">The solverVelocityIterations affects how how accurately Rigidbody joints and collision contacts are resolved. Overrides Physics.defaultSolverVelocityIterations. Must be positive.</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/2023.3/Documentation/ScriptReference/Rigidbody.htmlRigidbody-useGravity.html">useGravity</a></td><td class="desc">Controls whether gravity affects this rigidbody.</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/2023.3/Documentation/ScriptReference/Rigidbody.htmlRigidbody-worldCenterOfMass.html">worldCenterOfMass</a></td><td class="desc">The center of mass of the rigidbody in world space (Read Only).</td></tr></tbody></table>

### Public Methods

<table class="list"><tbody><tr><td class="lbl"><a href="https://docs.unity3d.com/2023.3/Documentation/ScriptReference/Rigidbody.htmlRigidbody.AddExplosionForce.html">AddExplosionForce</a></td><td class="desc">Applies a force to a rigidbody that simulates explosion effects.</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/2023.3/Documentation/ScriptReference/Rigidbody.htmlRigidbody.AddForce.html">AddForce</a></td><td class="desc">Adds a force to the Rigidbody.</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/2023.3/Documentation/ScriptReference/Rigidbody.htmlRigidbody.AddForceAtPosition.html">AddForceAtPosition</a></td><td class="desc">Applies force at position. As a result this will apply a torque and force on the object.</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/2023.3/Documentation/ScriptReference/Rigidbody.htmlRigidbody.AddRelativeForce.html">AddRelativeForce</a></td><td class="desc">Adds a force to the rigidbody relative to its coordinate system.</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/2023.3/Documentation/ScriptReference/Rigidbody.htmlRigidbody.AddRelativeTorque.html">AddRelativeTorque</a></td><td class="desc">Adds a torque to the rigidbody relative to its coordinate system.</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/2023.3/Documentation/ScriptReference/Rigidbody.htmlRigidbody.AddTorque.html">AddTorque</a></td><td class="desc">Adds a torque to the rigidbody.</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/2023.3/Documentation/ScriptReference/Rigidbody.htmlRigidbody.ClosestPointOnBounds.html">ClosestPointOnBounds</a></td><td class="desc">The closest point to the bounding box of the attached colliders.</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/2023.3/Documentation/ScriptReference/Rigidbody.htmlRigidbody.GetAccumulatedForce.html">GetAccumulatedForce</a></td><td class="desc">Returns the force that the Rigidbody has accumulated before the simulation step.</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/2023.3/Documentation/ScriptReference/Rigidbody.htmlRigidbody.GetAccumulatedTorque.html">GetAccumulatedTorque</a></td><td class="desc">Returns the torque that the Rigidbody has accumulated before the simulation step.</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/2023.3/Documentation/ScriptReference/Rigidbody.htmlRigidbody.GetPointVelocity.html">GetPointVelocity</a></td><td class="desc">The velocity of the rigidbody at the point worldPoint in global space.</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/2023.3/Documentation/ScriptReference/Rigidbody.htmlRigidbody.GetRelativePointVelocity.html">GetRelativePointVelocity</a></td><td class="desc">The velocity relative to the rigidbody at the point relativePoint.</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/2023.3/Documentation/ScriptReference/Rigidbody.htmlRigidbody.IsSleeping.html">IsSleeping</a></td><td class="desc">Is the rigidbody sleeping?</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/2023.3/Documentation/ScriptReference/Rigidbody.htmlRigidbody.Move.html">Move</a></td><td class="desc">Moves the Rigidbody to position and rotates the Rigidbody to rotation.</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/2023.3/Documentation/ScriptReference/Rigidbody.htmlRigidbody.MovePosition.html">MovePosition</a></td><td class="desc">Moves the kinematic Rigidbody towards position.</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/2023.3/Documentation/ScriptReference/Rigidbody.htmlRigidbody.MoveRotation.html">MoveRotation</a></td><td class="desc">Rotates the rigidbody to rotation.</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/2023.3/Documentation/ScriptReference/Rigidbody.htmlRigidbody.PublishTransform.html">PublishTransform</a></td><td class="desc">Applies the position and rotation of the Rigidbody to the corresponding Transform component.</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/2023.3/Documentation/ScriptReference/Rigidbody.htmlRigidbody.ResetCenterOfMass.html">ResetCenterOfMass</a></td><td class="desc">Reset the center of mass of the rigidbody.</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/2023.3/Documentation/ScriptReference/Rigidbody.htmlRigidbody.ResetInertiaTensor.html">ResetInertiaTensor</a></td><td class="desc">Reset the inertia tensor value and rotation.</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/2023.3/Documentation/ScriptReference/Rigidbody.htmlRigidbody.SetDensity.html">SetDensity</a></td><td class="desc">Sets the mass based on the attached colliders assuming a constant density.</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/2023.3/Documentation/ScriptReference/Rigidbody.htmlRigidbody.Sleep.html">Sleep</a></td><td class="desc">Forces a rigidbody to sleep at least one frame.</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/2023.3/Documentation/ScriptReference/Rigidbody.htmlRigidbody.SweepTest.html">SweepTest</a></td><td class="desc">Tests if a rigidbody would collide with anything, if it was moved through the Scene.</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/2023.3/Documentation/ScriptReference/Rigidbody.htmlRigidbody.SweepTestAll.html">SweepTestAll</a></td><td class="desc">Like Rigidbody.SweepTest, but returns all hits.</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/2023.3/Documentation/ScriptReference/Rigidbody.htmlRigidbody.WakeUp.html">WakeUp</a></td><td class="desc">Forces a rigidbody to wake up.</td></tr></tbody></table>

### `ForceMode` enum

| Properties | Description |
| --- | --- |
| **`Force`** | Add a **continuous force to the rigidbody**, **using its mass**. Apply the force in each **FixedUpdate over a duration of time**.  **`ForceMode.Force`** - Applies a **gradual force on the Object**, taking mass into account. This is a literal pushing motion where the bigger the mass of the Object, the slower it will speed up.|
| **`Acceleration`** | Add a **continuous acceleration to the rigidbody**, **ignoring its mass**. Apply the acceleration in each FixedUpdate over a duration of time. **`ForceMode.Acceleration`** - Same as `ForceMode.Force` except that it doesn’t take mass into account. No matter how big the mass of the object, it will accelerate at a constant rate. |
| **`Impulse`** | Add an **instant force impulse to the rigidbody**, **using its mass**. Apply the impulse force instantly with a single function call. **`ForceMode.Impulse`** - Applies an instant force on the Object, taking mass into account. This pushes the Object **using the entire force in a single frame**. Again, the bigger the mass of the Object, the less effect this will have. Great for recoil or jump functions.|
| **`VelocityChange`** | Add an **instant velocity change to the rigidbody**, **ignoring its mass**. Apply the velocity change instantly with a single function call. **`ForceMode.VelocityChange`** - Same as `ForceMode.Impulse` and again, doesn’t take mass into account. It will literally add the force to the Object’s velocity in a single frame.|

### ref
https://docs.unity3d.com/2020.1/Documentation/ScriptReference/Rigidbody.html

Using AddForce/AddTorque \
https://www.youtube.com/watch?v=Gin9nVJ2nYc

AddTorque \
https://www.youtube.com/watch?v=De0PoxaKlww

https://www.youtube.com/watch?v=T99yH_gw3p8

ForceMode \
https://discussions.unity.com/t/difference-and-uses-of-rigidbody-force-modes/116629

