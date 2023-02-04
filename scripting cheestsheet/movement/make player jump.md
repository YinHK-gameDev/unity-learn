## Make player jump

**Method1:** 

```cs
private Rigidbody playerRb;

void Start() 
{
  playerRb = GetComponent<Rigidbody>();
  playerRb.AddForce(Vector3.up * 1000);
}
```


