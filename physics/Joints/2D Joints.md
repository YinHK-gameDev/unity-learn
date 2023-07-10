## 2D joints
1. **Distance Joint 2D** 
   - attaches two game objects controlled by rigidbody physics together and keeps them a certain distance apart.

   https://docs.unity3d.com/Manual/class-DistanceJoint2D.html

   https://www.youtube.com/watch?v=wpd2W3bIwx4
   
3. **Fixed Joint 2D**
   - keeps two objects in a position relative to each other, so the objects are always offset at a given position and angle. For example, objects that need to react as if they are rigidly connected: They can’t move away from each other, they can’t move closer together, and they can’t rotate with respect to each other. You can also use this joint to create a less rigid connection that flexes.
  
   https://docs.unity3d.com/Manual/class-FixedJoint2D.html

   https://www.youtube.com/watch?v=AEoWuRn3YfY

5. **Friction Joint 2D** 
   - reduces both the linear and angular velocities between two game objects controlled by rigidbody physics to zero (ie: it slows them down and stops them). For example; a platform that rotates but resists that movement.
  
   https://docs.unity3d.com/Manual/class-FrictionJoint2D.html

   https://www.youtube.com/watch?v=1-h43fzNB7U

7. **Hinge Joint 2D** 
   - allows a game object controlled by rigidbody physics to be **attached to a point in space** around which it **can rotate**. For example; the pivot on a pair of scissors.
  
   https://docs.unity3d.com/Manual/class-HingeJoint2D.html

   https://www.youtube.com/watch?v=l6awvCT29yU

8. **Relative Joint 2D**
   - allows two game objects controlled by rigidbody physics to maintain a position based on each other’s location. Use this joint to keep two objects offset from each other. For example; a space-shooter game where the player has extra gun batteries that follow them.
  
   https://docs.unity3d.com/Manual/class-RelativeJoint2D.html

   https://www.youtube.com/watch?v=V6eGtas_EaY

10. **Slider Joint 2D** 
   - allows a game object controlled by rigidbody physics to slide along a line in space, like sliding doors, for example.
  
   https://docs.unity3d.com/Manual/class-SliderJoint2D.html

   https://www.youtube.com/watch?v=Micpv8SOXcg

11. **Spring Joint 2D** 
   - allows two game objects controlled by rigidbody physics to be attached together as if by a spring. Spring Joint 2D works in a similar way to distance joints. However, while distance joints enforce a fixed distance, spring joints apply tension to a connection, causing objects to bounce
  
   https://docs.unity3d.com/Manual/class-SpringJoint2D.html

   https://www.youtube.com/watch?v=zvHB1fsRadQ
   
11. **Target Joint 2D** 
   - connects to a specified target, rather than another rigid body object, as other joints do. It is a spring type joint, which you could use for picking up and moving an object acting under gravity, for example. The Target Joint 2D does not connect to another object with a rigid body; instead, it connects to a specific target. This is a spring type joint and can be used for picking up and moving objects acting under gravity, like our moving platform.
  
    https://docs.unity3d.com/Manual/class-TargetJoint2D.html

    https://www.youtube.com/watch?v=NyhWNWqFEVw

19. **Wheel Joint 2D** 
    - simulates wheels and suspension.

    https://docs.unity3d.com/Manual/class-WheelJoint2D.html

    https://www.youtube.com/watch?v=Fcjxe_KhgI4

    
### ref

https://docs.unity3d.com/Manual/Joints2D.html

https://gamedevelopment.tutsplus.com/tutorials/unity-2d-joints-distance-hinge-target-and-fixed-joint--cms-27452

https://www.kodeco.com/1766-physics-joints-in-unity-2d

https://www.youtube.com/watch?v=MElbAwhMvTc&t=71s

https://www.youtube.com/watch?v=KFzg8DLgxic

https://www.youtube.com/watch?v=Z6hXMqXZKFc
