## Navigation




### UnityEngine.AI Scripting API

- **`NavMesh`** class: https://docs.unity3d.com/2022.3/Documentation/ScriptReference/AI.NavMesh.html
- **`NavMeshAgent`** class: https://docs.unity3d.com/2022.3/Documentation/ScriptReference/AI.NavMeshAgent.html
- **`NavMeshBuilder`** class: https://docs.unity3d.com/2022.3/Documentation/ScriptReference/AI.NavMeshBuilder.html
- **`NavMeshData`** class: https://docs.unity3d.com/2022.3/Documentation/ScriptReference/AI.NavMeshData.html
- **`NavMeshObstacle`** class: https://docs.unity3d.com/2022.3/Documentation/ScriptReference/AI.NavMeshObstacle.html
- **`NavMeshPath`** class: https://docs.unity3d.com/2022.3/Documentation/ScriptReference/AI.NavMeshPath.html
- **`OffMeshLink`** class: https://docs.unity3d.com/2022.3/Documentation/ScriptReference/AI.OffMeshLink.html


#### `NavMeshAgent`
Telling a NavMeshAgent to Move to a Destination:
```cs
// MoveDestination.cs
using UnityEngine;

public class MoveDestination : MonoBehaviour 
{
   public Transform goal;
   void Start () 
   {
      NavMeshAgent agent = GetComponent<NavMeshAgent>();
      agent.destination = goal.position; 
    }
 }
```

Moving an Agent to a Position Clicked by the Mouse:
```cs


// MoveToClickPoint.cs
    using UnityEngine;
    using UnityEngine.AI;
    
    public class MoveToClickPoint : MonoBehaviour 
    {
        NavMeshAgent agent;
        
        void Start() 
        {
            agent = GetComponent<NavMeshAgent>();
        }
        
        void Update() 
        {
            if (Input.GetMouseButtonDown(0)) 
            {
                RaycastHit hit;
                
                if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, 100)) 
                {
                    agent.destination = hit.point;
                    // or use SetDestination() method
                    // agent.SetDestination(hit.point);
                }
            }
        }
    }

```

Making an Agent Patrol Between a Set of Points:
```cs
// Patrol.cs
    using UnityEngine;
    using UnityEngine.AI;
    using System.Collections;


    public class Patrol : MonoBehaviour {

        public Transform[] points;
        private int destPoint = 0;
        private NavMeshAgent agent;


        void Start () {
            agent = GetComponent<NavMeshAgent>();

            // Disabling auto-braking allows for continuous movement
            // between points (ie, the agent doesn't slow down as it
            // approaches a destination point).
            agent.autoBraking = false;

            GotoNextPoint();
        }


        void GotoNextPoint() {
            // Returns if no points have been set up
            if (points.Length == 0)
                return;

            // Set the agent to go to the currently selected destination.
            agent.destination = points[destPoint].position;

            // Choose the next point in the array as the destination,
            // cycling to the start if necessary.
            destPoint = (destPoint + 1) % points.Length;
        }


        void Update () {
            // Choose the next destination point when the agent gets
            // close to the current one.
            if (!agent.pathPending && agent.remainingDistance < 0.5f)
                GotoNextPoint();
        }
    }

```


**`NavMeshAgent`** class 


```cs
//Specifies which NavMesh areas are passable. 
public int areaMask;

//Gets or attempts to set the destination of the agent in world-space units.
public Vector3 destination;

//Should the agent brake automatically to avoid overshooting the destination point?
public bool autoBraking;

//Maximum movement speed when following a path.
public float speed;

//Access the current velocity of the NavMeshAgent component, or set a velocity to control the agent manually.
public Vector3 velocity;

//The distance between the agent's position and the destination on the current path. (Read Only)
public float remainingDistance;

//Stop within this distance from the target position.
public float stoppingDistance;

//Calculate a path to a specified point and store the resulting path.
public bool CalculatePath(Vector3 targetPosition, AI.NavMeshPath path);

//Clears the current path.
public void ResetPath();

//Sets the cost for traversing over areas of the area type.
public void SetAreaCost(int areaIndex, float areaCost);

//Sets or updates the destination thus triggering the calculation for a new path.
public bool SetDestination(Vector3 target);

//Trace a straight path towards a target postion in the NavMesh without moving the agent.
//This function follows the path of a "ray" between the agent's position and the specified target //position. If an obstruction is encountered along the line then a true value is returned and the //position and other details of the obstructing object are stored in the hit parameter. This can be //used to check if there is a clear shot or line of sight between a character and a target object.
public bool Raycast(Vector3 targetPosition, out AI.NavMeshHit hit);

```

| Properties | Description |
| --- | --- |
| acceleration | The maximum acceleration of an agent as it follows a path, given in units / sec^2. |
| agentTypeID | The type ID for the agent. |
| angularSpeed | Maximum turning speed in (deg/s) while following a path. |
| areaMask | Specifies which NavMesh areas are passable. Changing areaMask will make the path stale (see isPathStale). |
| autoBraking | Should the agent brake automatically to avoid overshooting the destination point? |
| autoRepath | Should the agent attempt to acquire a new path if the existing path becomes invalid? |
| autoTraverseOffMeshLink | Should the agent move across OffMeshLinks automatically? |
| avoidancePriority | The avoidance priority level. |
| baseOffset | The relative vertical displacement of the owning GameObject. |
| currentOffMeshLinkData | The current OffMeshLinkData. |
| desiredVelocity | The desired velocity of the agent including any potential contribution from avoidance. (Read Only) |
| destination | Gets or attempts to set the destination of the agent in world-space units. |
| hasPath | Does the agent currently have a path? (Read Only) |
| height | The height of the agent for purposes of passing under obstacles, etc. |
| isOnNavMesh | Is the agent currently bound to the navmesh? (Read Only) |
| isOnOffMeshLink | Is the agent currently positioned on an OffMeshLink? (Read Only) |
| isPathStale | Is the current path stale. (Read Only) |
| isStopped | Use this property to set, or get, whether the NavMesh agent stops or continues its movement along the current path. |
| navMeshOwner | Returns the owning object of the NavMesh the agent is currently placed on (Read Only). |
| nextOffMeshLinkData | The next OffMeshLinkData on the current path. |
| nextPosition | Gets or sets the simulation position of the navmesh agent. |
| obstacleAvoidanceType | The level of quality of avoidance. |
| path | Property to get and set the current path. |
| pathPending | Is a path in the process of being computed but not yet ready? (Read Only) |
| pathStatus | The status of the current path (complete, partial or invalid). |
| radius | The avoidance radius for the agent. |
| remainingDistance | The distance between the agent's position and the destination on the current path. (Read Only) |
| speed | Maximum movement speed when following a path. |
| steeringTarget | Get the current steering target along the path. (Read Only) |
| stoppingDistance | Stop within this distance from the target position. |
| updatePosition | Gets or sets whether the transform position is synchronized with the simulated agent position. The default value is true. |
| updateRotation | Should the agent update the transform orientation? |
| updateUpAxis | Allows you to specify whether the agent should be aligned to the up-axis of the NavMesh or link that it is placed on. |
| velocity | Access the current velocity of the NavMeshAgent component, or set a velocity to control the agent manually. |


| ActivateCurrentOffMeshLink | Enables or disables the current off-mesh link. |
| --- | --- |
| CalculatePath | Calculate a path to a specified point and store the resulting path. |
| CompleteOffMeshLink | Completes the movement on the current OffMeshLink. |
| FindClosestEdge | Locate the closest NavMesh edge. |
| GetAreaCost | Gets the cost for path calculation when crossing area of a particular type. |
| Move | Apply relative movement to current position. |
| Raycast | Trace a straight path towards a target postion in the NavMesh without moving the agent. |
| ResetPath | Clears the current path. |
| SamplePathPosition | Sample a position along the current path. |
| SetAreaCost | Sets the cost for traversing over areas of the area type. |
| SetDestination | Sets or updates the destination thus triggering the calculation for a new path. |
| SetPath | Assign a new path to this agent. |
| Warp | Warps agent to the provided position. |

