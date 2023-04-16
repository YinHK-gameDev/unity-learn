## Toss objects randomly in the air

```cs
private Rigidbody targetRb;

void Start() {
  targetRb = GetComponent<Rigidbody>();
  targetRb.AddForce(Vector3.up * Random.Range(12, 16), ForceMode.Impulse);
  targetRb.AddTorque(Random.Range(-10, 10), Random.Range(-10, 10), 
                    Random.Range(-10, 10), ForceMode.Impulse);
  transform.position = new Vector3(Random.Range(-4, 4), -6);
}

```


