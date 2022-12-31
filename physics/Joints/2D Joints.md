## 2D joints
1. **Distance Joint 2D** 
   - attaches two game objects controlled by rigidbody physics together and keeps them a certain distance apart.

2. **Fixed Joint 2D**
   - keeps two objects in a position relative to each other, so the objects are always offset at a given position and angle. For example, objects that need to react as if they are rigidly connected: They can’t move away from each other, they can’t move closer together, and they can’t rotate with respect to each other. You can also use this joint to create a less rigid connection that flexes.

3. **Friction Joint 2D** 
   - reduces both the linear and angular velocities between two game objects controlled by rigidbody physics to zero (ie: it slows them down and stops them). For example; a platform that rotates but resists that movement.

4. **Hinge Joint 2D** 
   - allows a game object controlled by rigidbody physics to be attached to a point in space around which it can rotate. For example; the pivot on a pair of scissors.

5. **Relative Joint 2D**
   - allows two game objects controlled by rigidbody physics to maintain a position based on each other’s location. Use this joint to keep two objects offset from each other. For example; a space-shooter game where the player has extra gun batteries that follow them.

6. **Slider Joint 2D** 
   - allows a game object controlled by rigidbody physics to slide along a line in space, like sliding doors, for example.

7. **Spring Joint 2D** 
   - allows two game objects controlled by rigidbody physics to be attached together as if by a spring.

8. **Target Joint 2D** 
   - connects to a specified target, rather than another rigid body object, as other joints do. It is a spring type joint, which you could use for picking up and moving an object acting under gravity, for example.

9. **Wheel Joint 2D** 
   - simulates wheels and suspension.


https://gamedevelopment.tutsplus.com/tutorials/unity-2d-joints-distance-hinge-target-and-fixed-joint--cms-27452
