## Navigation and Pathfinding
The **navigation system** allows you to create characters that can **intelligently move around the game world**, using **navigation meshes** that are created automatically from your Scene
geometry. 
 
Dynamic obstacles allow you to alter the navigation of the characters at runtime, while OffMesh links let you build specific actions like opening doors or jumping down from a ledge.
 
 
### Navigation system
The **Navigation System** allows you to create characters which can navigate the game world. It gives your characters the ability to understand that they need to take stairs to reach second floor, or to jump to get over a ditch. The **Unity NavMesh system** consists of the following pieces:
 
-   **NavMesh** (short for Navigation Mesh) is a data structure which describes the walkable surfaces of the game world and allows to find path from one walkable location to another in the game world. The data structure is built, or baked, automatically from your level geometry.
-   **NavMesh Agent** component help you to create characters which avoid each other while moving towards their goal. Agents reason about the game world using the NavMesh and they know how to avoid each other as well as moving obstacles.
-   **OffMesh Link** component allows you to incorporate navigation shortcuts which cannot be represented using a walkable surface. For example, jumping over a ditch or a fence, or opening a door before walking through it, can be all described as OffMesh links.
-   **NavMesh Obstacle** component allows you to describe moving obstacles the agents should avoid while navigating the world. A barrel or a crate controlled by the physics system is a good example of an obstacle. While the obstacle is moving the agents do their best to avoid it, but once the obstacle becomes stationary it will carve a hole in the navmesh so that the agents can change their paths to steer around it, or if the stationary obstacle is blocking the path way, the agents can find a different route.
 

### Building a NavMesh

In Unity, `NavMesh` generation is handled from the Navigation window (menu: Window > AI > Navigation).

Building a `NavMesh` for your scene can be done in 4 quick steps:

-   **Select** scene geometry that should affect the navigation – walkable surfaces and obstacles.
-   **Check Navigation Static** on to include selected objects in the NavMesh baking process.
-   **Adjust** the bake settings to match your agent size.
    -   _Agent Radius_ defines how close the agent center can get to a wall or a ledge.
    -   _Agent Height_ defines how low the spaces are that the agent can reach.
    -   _Max Slope_ defines how steep the ramps are that the agent walk up.
    -   _Step Height_ defines how high obstructions are that the agent can step on.

### NavMesh building components
**`NavMesh`** building components provide additional controls for generating and using NavMeshes in the Unity Editor and at runtime.

**`NavMesh`** building components are available through the AI Navigation package. To install this package, follow the instructions on adding a registry package by name and add the `com.unity.ai.navigation package`.



### Telling a NavMeshAgent to Move to a Destination
You can tell an agent to start calculating a path simply by setting the **`NavMeshAgent.destination`** property with the point you want the agent to move to. As soon as the calculation is finished, the agent will automatically move along the path until it reaches its destination. 
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

https://docs.unity3d.com/Manual/nav-MoveToDestination.html

### Moving an Agent to a Position Clicked by the Mouse
You can choose the destination point on the **`NavMesh`** by clicking the mouse on the object’s surface. The position of the click is determined by a raycast, rather like pointing a laser beam at the object to see where it hits(Rays from the Camera).


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
                }
            }
        }
    }
```

https://docs.unity3d.com/Manual/nav-MoveToClickPoint.html

### Making an Agent Patrol Between a Set of Points
Many games feature **NPCs** that patrol automatically **around the playing area**.

The patrol points are supplied to the script using a public array of Transforms. This array can be assigned from the inspector using GameObjects to mark the points’ positions. The **`GotoNextPoint`** function sets the destination point for the agent (which also starts it moving) and then selects the new destination that will be used on the next call. As it stands, the code cycles through the points in the sequence they occur in the array but you can easily modify this, say by using **`Random.Range`** to choose an array index at random.

In the Update function, the script checks how close the agent is to the destination using the **`remainingDistance`** property. When this distance is very small, a call to GotoNextPoint is made to start the next leg of the patrol.

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
// Patrol.js
    var points: Transform[];
    var destPoint: int = 0;
    var agent: NavMeshAgent;


    function Start() {
        agent = GetComponent.<NavMeshAgent>();

        // Disabling auto-braking allows for continuous movement
        // between points (ie, the agent doesn't slow down as it
        // approaches a destination point).
        agent.autoBraking = false;

        GotoNextPoint();
    }


    function GotoNextPoint() {
        // Returns if no points have been set up
        if (points.Length == 0)
            return;
            
        // Set the agent to go to the currently selected destination.
        agent.destination = points[destPoint].position;

        // Choose the next point in the array as the destination,
        // cycling to the start if necessary.
        destPoint = (destPoint + 1) % points.Length;
    }


    function Update() {
        // Choose the next destination point when the agent gets
        // close to the current one.
        if (!agent.pathPending && agent.remainingDistance < 0.5f)
            GotoNextPoint();
    }

```

https://docs.unity3d.com/Manual/nav-AgentPatrol.html


### Coupling Animation and Navigation
Setup navigating humanoid characters to move using the navigation system.

https://docs.unity3d.com/Manual/nav-CouplingAnimationAndNavigation.html



### ref 
https://docs.unity3d.com/Manual/Navigation.html

**Scripting API** \
https://docs.unity3d.com/ScriptReference/AI.NavMesh.html

**Navigation tutorial** \
https://learn.unity.com/search?k=%5B%22q%3ANavigation%22%5D

**Brackeys Unity NavMesh Tutorial** \
https://www.youtube.com/watch?v=CHV1ymlw-P8

https://www.youtube.com/watch?v=FkLJ45Pt-mY

https://www.youtube.com/watch?v=atCOd4o7tG4

https://www.youtube.com/watch?v=blPglabGueM

https://www.youtube.com/watch?v=blPglabGueM&t=11s

https://www.youtube.com/watch?v=G9Otw12OUvE


