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
> using `transform.parent` method

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

> player 要transform時, 會set player為platform 的child, player會隨着platform 移動


[Transform.parent](https://docs.unity3d.com/ScriptReference/Transform-parent.html)
