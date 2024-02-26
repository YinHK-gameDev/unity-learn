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
