## collision

> If one Rigidbody collides with another, the **physics engine only calculates a collision if both GameObjects have a Collider attached**. If one GameObject **has a Rigidbody but no Collider, it passes through other GameObjects**, and Unity does not include it in collision calculations.

### collision vs trigger
OnTrigger is a **pass through collision**, where **objects don’t bounce off each other**, but **events can be triggered** when contact is made. While collision like two objects collide in real world, they may bounce off. For example bullets and enemy use OnTrigger so the bullet doesn’t bounce off the enemy and fly off.


### Temporarily ignore collision

There are several ways to do this, using a coroutine:

**Disabling the collider**
```cs
GetComponent<Collider>().enabled = false ;
StartCoroutine( EnableCollision( 3 ) ) ;

// ...

private IEnumerator EnableCollision( float delay )
{
    yield return new WaitForSeconds( delay ) ;
    GetComponent<Collider>().enabled = true ;
}

```

**Turning the collider into a trigger**
```cs
GetComponent<Collider>().isTrigger = true ;
StartCoroutine( EnableCollision( 3 ) ) ;

// ...

private IEnumerator EnableCollision( float delay )
{
    yield return new WaitForSeconds( delay ) ;
    GetComponent<Collider>().isTrigger = false;
}
```


**Changing the layer**

By scripting using Layermask:
```cs
gameObject.layer = LayerMask.NameToLayer("PhantomBall") ;
StartCoroutine( EnableCollision( 3 ) ) ;

// ...

private IEnumerator EnableCollision( float delay )
{
    yield return new WaitForSeconds( delay ) ;
    gameObject.layer = LayerMask.NameToLayer("Ball") ;
}
```

Create different layer manually:
> 📌 Set the two game objects into **different layers** → **project setting** → **physics** → **Layer collision matrix** untick two layer for collision.


**Using Physics class**
```cs
Physics.IgnoreCollision( GetComponent<Collider>(), wallCollider, true ) ;
StartCoroutine( EnableCollision( 3 ) ) ;

// ...

private IEnumerator EnableCollision( float delay )
{
    yield return new WaitForSeconds( delay ) ;
    Physics.IgnoreCollision( GetComponent<Collider>(), wallCollider, false ) ;
}
```

### Collision detection
Collision detection is the physics engine
’s process for detecting when a physics body (**Rigidbody** or **ArticulationBody**) comes into contact with a collider. Unity provides **different collision detection algorithms** for different situations, so that you can choose the most efficient approach for each individual physics body (**Rigidbody** or **Articulation Body**) in your scene.

**Collision Detection** defines which **algorithm** the physics body (Rigidbody or ArticulationBody) uses to **detect collisions**. Different algorithms offer **different levels of accuracy**, but more accurate algorithms require more **computational resource**s.

There are three algorithms available, represented by four collision detection modes:

| Collision detection mode | Algorithm | Useful for | Not useful for |
| --- | --- | --- | --- |
| **Discrete** | Discrete | - Slow-moving collisions. | - Fast-moving collisions. |
| **Continuous Speculative** | Speculative CCD | - Fast-moving collisions. | - Some fast-moving collisions that require an especially high degree of accuracy. |
| **Continuous** | Sweep CCD | - Fast-moving linear collisions that require a high degree of accuracy.- Physics bodies that only collide with static colliders. | - Collisions that happen as a result of the physics body rotating.- Physics bodies that collide with moving colliders. |
| **Continuous Dynamic** | Sweep CCD | - Fast-moving linear collisions that require a high degree of accuracy.- Physics bodies that collide with moving colliders. | - Collisions that happen as a result of the physics body rotating. |


The following decision flow might provide a **starting point for selecting a collision detection typ**e. It starts with the **least computationally intensive mode**, and progresses to the **most computationally intensive mode**.

1. Try Discrete first.
2. If you notice missed collisions in **Discrete mode**, try **Continuous Speculative**.
3. If you notice missed collisions or false collisions in **Continuous Speculative mode**, try **Continuous for collisions with static colliders**, or **Continuous Dynamic for collisions with dynamic Rigidbody colliders**.

In some cases, you might find that the physics performance relies on a combination of the collision detection mode and the physics timestep frequency. Experiment with both and profile the results to find the right solution for your project.


#### Select a collision detection mode

To select an algorithm, set the physics body’s Collision Detection property in one of the following ways:
- In the Editor: On the **Rigidbod**y or **Articulation Body component** Inspector, change the **Collision Detection property**.
- In code: Use the API properties **`Rigidbody.collisionDetectionMode`** and **`ArticulationBody.collisionDetectionMode`**.

### ref
https://docs.unity3d.com/Manual/collision-section.html


