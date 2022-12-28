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
