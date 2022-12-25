### collision


### collision vs trigger
OnTrigger is a pass through collision, where objects don’t bounce off each other, but events can be triggered when contact is made. While collision like two objects collide in real world, they may bounce off. For example bullets and enemy use OnTrigger so the bullet doesn’t bounce off the enemy and fly off.


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



