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

### Scripting backends
Unity uses the open-source `.NET` platform to ensure that applications you make with Unity can run on a wide variety of different hardware configurations.

Unity has two scripting backends; **Mono**, and **IL2CPP** (Intermediate Language To C++), each of which uses a different compilation technique:

= Mono uses **just-in-time (JIT) compilation** and compiles code on demand at runtime.
- IL2CPP uses **ahead-of-time (AOT) compilation** and compiles your entire application before it runs.

The benefit of using a JIT-based scripting backend is that the compilation time is typically much faster than AOT.

By default, Unity uses the Mono backend on platforms that support Mono. When you build a player for your application, you can choose which scripting backend to use. To do this through the Editor, go to **`Edit`** > **`Project Settings`** > **`Player`**, open the Other Settings panel, then **click on the Scripting Backend dropdown** and select which backend you want.

