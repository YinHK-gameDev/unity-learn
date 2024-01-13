## RaycastHit

|RaycastHit properties|Description|
| --- | --- |
| **`articulationBody`** | The ArticulationBody of the collider that was hit. If the collider is not attached to an articulation body then it is null. |
| **`barycentricCoordinae`** | The barycentric coordinate of the triangle we hit. |
| **`collider`** | The Collider that was hit. |
| **`colliderInstanceID`** | Instance ID of the Collider that was hit. |
| **`distance`** | The distance from the ray's origin to the impact point. |
| **`lightmapCoord`** | The uv lightmap coordinate at the impact point. |
| **`normal`** | The normal of the surface the ray hit. |
| **`point`** | The impact point in world space where the ray hit the collider. |
| **`rigidbody`** | The Rigidbody of the collider that was hit. If the collider is not attached to a rigidbody then it is null. |
| **`textureCoord`** | The uv texture coordinate at the collision location. |
| **`textureCoord2`** | The secondary uv texture coordinate at the impact point. |
| **`transform`** | The Transform of the rigidbody or collider that was hit. |
| **`triangleIndex`** | The index of the triangle that was hit. |


### `RaycastHit.collider`

```cs
using UnityEngine;

public class Example : MonoBehaviour
{
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider != null)
                {
                    hit.collider.enabled = false;
                }
            }
        }
    }
}
```


### `RaycastHit.colliderInstanceID`
```cs
using Unity.Collections;
using Unity.Jobs;
using UnityEngine;

public class BatchExample : MonoBehaviour
{
    public struct CollisionJob : IJob
    {
        public int colliderID;
        public NativeArray<RaycastHit> results;

        public void Execute()
        {
            // This is where we check what we collided with and do any appropriate actions
            // If you tried accessing RaycastHit.collider you would get an error
            if (colliderID == results[0].colliderInstanceID)
                Debug.Log("Detected the a hit with the requested collider");
        }
    }
    void Start()
    {
        // We create the raycast command buffer and an array to store the RaycastHits
        NativeArray<RaycastCommand> commands = new NativeArray<RaycastCommand>(1, Allocator.TempJob);
        NativeArray<RaycastHit> results = new NativeArray<RaycastHit>(1, Allocator.TempJob);

        var boxCollider = new GameObject().AddComponent<BoxCollider>();

        // Create a new command for the buffer, pointing at the collider we created
        commands[0] = new RaycastCommand(Vector3.up * 2, Vector3.down);

        // Schedule the commands in the buffer and store results in the 'results' array
        var batchHandle = RaycastCommand.ScheduleBatch(commands, results, 1, 1);

        // This job is for doing something on the other thread when the collider of interest was hit
        var job = new CollisionJob();
        job.colliderID = boxCollider.GetInstanceID();
        job.results = results;

        //Schedule the job to start after batchHandle has finished
        var jobHandle = job.Schedule(batchHandle);
        jobHandle.Complete();

        commands.Dispose();
        results.Dispose();
    }
}

```

### `RaycastHit.distance`


```cs
using UnityEngine;

public class Example : MonoBehaviour
{
    // Movable, levitating object.

    // This works by measuring the distance to ground with a
    // raycast then applying a force that decreases as the object
    // reaches the desired levitation height.

    // Vary the parameters below to
    // get different control effects. For example, reducing the
    // hover damping will tend to make the object bounce if it
    // passes over an object underneath.

    // Forward movement force.
    float moveForce = 1.0f;

    // Torque for left/right rotation.
    float rotateTorque = 1.0f;

    // Desired hovering height.
    float hoverHeight = 4.0f;

    // The force applied per unit of distance below the desired height.
    float hoverForce = 5.0f;

    // The amount that the lifting force is reduced per unit of upward speed.
    // This damping tends to stop the object from bouncing after passing over
    // something.
    float hoverDamp = 0.5f;

    // Rigidbody component.
    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();

        // Fairly high drag makes the object easier to control.
        rb.drag = 0.5f;
        rb.angularDrag = 0.5f;
    }

    void FixedUpdate()
    {
        // Push/turn the object based on arrow key input.
        rb.AddForce(Input.GetAxis("Vertical") * moveForce * transform.forward);
        rb.AddTorque(Input.GetAxis("Horizontal") * rotateTorque * Vector3.up);

        RaycastHit hit;
        Ray downRay = new Ray(transform.position, -Vector3.up);

        // Cast a ray straight downwards.
        if (Physics.Raycast(downRay, out hit))
        {
            // The "error" in height is the difference between the desired height
            // and the height measured by the raycast distance.
            float hoverError = hoverHeight - hit.distance;

            // Only apply a lifting force if the object is too low (ie, let
            // gravity pull it downward if it is too high).
            if (hoverError > 0)
            {
                // Subtract the damping from the lifting force and apply it to
                // the rigidbody.
                float upwardSpeed = rb.velocity.y;
                float lift = hoverError * hoverForce - upwardSpeed * hoverDamp;
                rb.AddForce(lift * Vector3.up);
            }
        }
    }
}

```

### `RaycastHit.normal`

```cs
using UnityEngine;

public class Example : MonoBehaviour
{
    // Calculate the reflection of a "laser beam" off a clicked object.

    // The object from which the beam is fired. The incoming beam will
    // not be visible if the camera is used for this!
    Transform gunObj;

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit))
            {
                // Find the line from the gun to the point that was clicked.
                Vector3 incomingVec = hit.point - gunObj.position;

                // Use the point's normal to calculate the reflection vector.
                Vector3 reflectVec = Vector3.Reflect(incomingVec, hit.normal);

                // Draw lines to show the incoming "beam" and the reflection.
                Debug.DrawLine(gunObj.position, hit.point, Color.red);
                Debug.DrawRay(hit.point, reflectVec, Color.green);
            }
        }
    }
}
```

### `RaycastHit.point`


```cs
using UnityEngine;

public class Example : MonoBehaviour
{
    // Apply a force to a rigidbody in the Scene at the point
    // where it is clicked.

    // The force with which the target is "poked" when hit.
    float pokeForce;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            var ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.rigidbody != null)
                {
                    hit.rigidbody.AddForceAtPosition(ray.direction * pokeForce, hit.point);
                }
            }
        }
    }
}

```

### `RaycastHit.rigidbody`
```cs
using UnityEngine;

public class Example : MonoBehaviour
{
    // Apply a force to a clicked rigidbody object.

    // The force applied to an object when hit.
    float hitForce;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.rigidbody != null)
                {
                    hit.rigidbody.AddForce(ray.direction * hitForce);
                }
            }
        }
    }
}

```




### ref 
https://docs.unity3d.com/ScriptReference/RaycastHit-normal.html


