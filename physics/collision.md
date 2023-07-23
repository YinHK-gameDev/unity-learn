## collision

> If one Rigidbody collides with another, the **physics engine only calculates a collision if both GameObjects have a Collider attached**. If one GameObject **has a Rigidbody but no Collider, it passes through other GameObjects**, and Unity does not include it in collision calculations.

### collision vs trigger
OnTrigger is a **pass through collision**, where **objects don’t bounce off each other**, but events can be triggered when contact is made. While collision like two objects collide in real world, they may bounce off. For example bullets and enemy use OnTrigger so the bullet doesn’t bounce off the enemy and fly off.


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



