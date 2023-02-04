## Camera chasing a game object(script for camera)

```cs
public GameObject player;
private Vector3 offset = new vector3(0, 5, -7);

void Update()
{
  transform.position = player.transform.positiion + offset;
}

```
