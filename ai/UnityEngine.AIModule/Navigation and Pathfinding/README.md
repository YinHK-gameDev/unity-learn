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

https://www.youtube.com/watch?v=G9Otw12OUvE


