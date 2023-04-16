### Toss objects randomly in the air

**Example:**

```cs
private Rigidbody targetRb;

private float minSpeed = 12; 
private float maxSpeed = 16;
private float maxTorque = 10;
private float xRange = 4;
private float ySpawnPos = -6;


void Start() {
  targetRb = GetComponent<Rigidbody>();
  targetRb.AddForce(Vector3.up * Random.Range(minSpeed, maxSpeed), ForceMode.Impulse);
  targetRb.AddTorque(Random.Range(-maxTorque, maxTorque), Random.Range(-maxTorque, maxTorque), 
                    Random.Range(-maxTorque, maxTorque), ForceMode.Impulse);
  transform.position = new Vector3(Random.Range(-xRange, xRange), ySpawnPos);
}

```


