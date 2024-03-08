## Boxcast
Casts the box along a ray and returns detailed information on what was hit.

### `Physics.BoxCast`
```cs
public static bool BoxCast(Vector3 center, Vector3 halfExtents, Vector3 direction, Quaternion orientation = Quaternion.identity, float maxDistance = Mathf.Infinity, int layerMask = DefaultRaycastLayers, QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal);
```

| Parameters | Descriptions |
| --- | --- |
| center | Center of the box. |
| halfExtents | Half the size of the box in each dimension. |
| direction | The direction in which to cast the box. |
| orientation | Rotation of the box. |
| maxDistance | The max length of the cast. |
| layerMask | A Layer mask that is used to selectively ignore colliders when casting a capsule. |
| queryTriggerInteraction | Specifies whether this query should hit Triggers. |


Eg:
```cs
//Attach this script to a GameObject. Make sure it has a Collider component by clicking the Add Component button. Then click Physics>Box Collider to attach a Box Collider component.
//This script creates a BoxCast in front of the GameObject and outputs a message if another Collider is hit with the Collider’s name.
//It also draws where the ray and BoxCast extends to. Just press the Gizmos button to see it in Play Mode.
//Make sure to have another GameObject with a Collider component for the BoxCast to collide with.

using UnityEngine;

public class Example : MonoBehaviour
{
    float m_MaxDistance;
    float m_Speed;
    bool m_HitDetect;

    Collider m_Collider;
    RaycastHit m_Hit;

    void Start()
    {
        //Choose the distance the Box can reach to
        m_MaxDistance = 300.0f;
        m_Speed = 20.0f;
        m_Collider = GetComponent<Collider>();
    }

    void Update()
    {
        //Simple movement in x and z axes
        float xAxis = Input.GetAxis("Horizontal") * m_Speed;
        float zAxis = Input.GetAxis("Vertical") * m_Speed;
        transform.Translate(new Vector3(xAxis, 0, zAxis));
    }

    void FixedUpdate()
    {
        //Test to see if there is a hit using a BoxCast
        //Calculate using the center of the GameObject's Collider(could also just use the GameObject's position), half the GameObject's size, the direction, the GameObject's rotation, and the maximum distance as variables.
        //Also fetch the hit data
        m_HitDetect = Physics.BoxCast(m_Collider.bounds.center, transform.localScale, transform.forward, out m_Hit, transform.rotation, m_MaxDistance);
        if (m_HitDetect)
        {
            //Output the name of the Collider your Box hit
            Debug.Log("Hit : " + m_Hit.collider.name);
        }
    }

    //Draw the BoxCast as a gizmo to show where it currently is testing. Click the Gizmos button to see this
    void OnDrawGizmos()
    {
        Gizmos.color = Color.red;

        //Check if there has been a hit yet
        if (m_HitDetect)
        {
            //Draw a Ray forward from GameObject toward the hit
            Gizmos.DrawRay(transform.position, transform.forward * m_Hit.distance);
            //Draw a cube that extends to where the hit exists
            Gizmos.DrawWireCube(transform.position + transform.forward * m_Hit.distance, transform.localScale);
        }
        //If there hasn't been a hit yet, draw the ray at the maximum distance
        else
        {
            //Draw a Ray forward from GameObject toward the maximum distance
            Gizmos.DrawRay(transform.position, transform.forward * m_MaxDistance);
            //Draw a cube at the maximum distance
            Gizmos.DrawWireCube(transform.position + transform.forward * m_MaxDistance, transform.localScale);
        }
    }
}

```

### `Physics2D.BoxCast`

```cs
public static RaycastHit2D BoxCast(Vector2 origin, Vector2 size, float angle, Vector2 direction, float distance = Mathf.Infinity, int layerMask = Physics2D.AllLayers, float minDepth = -Mathf.Infinity, float maxDepth = Mathf.Infinity);
```

| Parameters | Descriptions |
| --- | --- |
| origin | The point in 2D space where the box originates. |
| size | The size of the box. |
| angle | The angle of the box (in degrees). |
| direction | A vector representing the direction of the box. |
| distance | The maximum distance over which to cast the box. |
| layerMask | Filter to detect Colliders only on certain layers. |
| minDepth | Only include objects with a Z coordinate (depth) greater than or equal to this value. |
| maxDepth | Only include objects with a Z coordinate (depth) less than or equal to this value. |


### ref
https://docs.unity3d.com/2020.1/Documentation/ScriptReference/Physics.BoxCast.html

https://docs.unity3d.com/2020.1/Documentation/ScriptReference/Physics2D.BoxCast.html
