### A moving platform in 2D scene

```cs
Vector2 rightMovement =  new Vector2( transform.position.x  + Speed * Time.deltaTime, transform.position.y );

Vector2  leftMovement =  new Vector2( transform.position.x  - Speed * Time.deltaTime, transform.position.y );

if(transform.position.x > 9.60f ){
        moveRight = false;
        Debug.Log(moveRight);
}
if(transform.position.x < -9.60f ){
        moveRight = true;
        Debug.Log(moveRight);
}
if (moveRight){
        transform.position = rightMovement;
}else  
   transform.position = leftMovement;
```

### Player stand on a moving platform
> using **`transform.parent`** method

```cs
void OnCollisionEnter2D(Collision2D col){    
     if (col.gameObject.name == "...."){  
           this.transform.parent = col.transform;
		 }
}
void OnCollisionExit2D(Collision2D col){
           this.transform.parent = null;
}
```

> For player's transform, this method sets player as a child of platform, player will move 
together with platform.

https://docs.unity3d.com/ScriptReference/Transform-parent.html


### Creating a falling platform

By using 


> 📌 **`Rigidbody.isKinematic`**



**or** 

> 📌 **`Rigidbody.useGravity`** and **`Invoke()`** function in **`OnCollisionEnter()`.**



