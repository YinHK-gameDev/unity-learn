## Make player jump

**Method1:** \
using AddForce method
```cs
private Rigidbody playerRb;

void Start() 
{
  playerRb = GetComponent<Rigidbody>();
  playerRb.AddForce(Vector3.up * 1000);
}
```


**Method2:** \
using velocity method
```cs
private float jumpSpeed = 40f;

  if (Input.GetKeyDown("space") ) {  
          if(isGround( )) {
	          rigidbody2d.velocity = Vector2.up * jumpSpeed;
	          Debug.Log("Pressed primary button.");
          }
   }
```


