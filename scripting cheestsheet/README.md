## Unity Scripting

 Unity allows you to create your own Components using scripts. These allow you to trigger game events, modify Component properties over time and respond to user input in any way you like.

You can attach a script by dragging the script asset to a GameObject in the hierarchy panel or to the inspector
 of the GameObject that is currently selected. 


```cs
// Use this for initialization
void Start () 
{
    Debug.Log("Hello world!");
}
```

> **`Debug.Log`** is a simple command that just prints a message to Unity’s console output. If you press Play now, you should see the message at the bottom of the main Unity editor window and in the Console window (menu: Window > General > Console
).


### Life cycle
![](./monobehaviour_flowchart.svg)




https://docs.unity3d.com/Manual/ExecutionOrder.html
