### Make enemy to follow player


**Example:**
```cs
public float speed;
private Rigidbody enemyRb;
private GameObject player;

void start() 
{
  enemy = GatComponent<Rigidbody>();
  player = GameObject.Find("player");
}

void Update() 
{
  //Using AddForce: AddForce((player,transform.position - transform.position).normalized * speed)
  enemyRb.AddForce((player.transform.position - transform.position).normalized * speed);
}
```

or

```cs
Transform.LookAt(target)
```

