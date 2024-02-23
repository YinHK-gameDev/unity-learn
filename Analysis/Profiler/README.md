## Profiler

The Unity Profiler is a tool you can **use to get performance information about your application**. You can connect it to devices on your network or devices connected to your machine to test how your application runs on your intended release platform. You can also run it in the Editor to get an overview of resource allocation while you’re developing your application.


To access the Profiler window go to menu: **Window > Analysis > Profiler**. 

When you use the Unity Profiler to profile your application, there are three main ways to record data:

-   Profile your application in a player on your target platform
-   Profile your application in Play mode in the Unity Editor
-   Profile the Unity Editor

The Profiler window is laid out as follows: 

- **Profiler modules**. This is a list of all the modules you can profile in your application. Use the drop-down menu at the top of this area to add and remove modules from the window.
- **Profiler control**s. Use these controls to set which device to profile from and what kind of profiling Unity should perform, navigate between frames, and start recording data.
- **Frame charts**. This area contains charts of each module the Profiler profiles. This area is blank when you open the Profiler for the first time, and fills with information when you start profiling your application.
- **Module details panel**. The information in this area of the window changes based on the module you have selected. For instance, when you select the CPU Usage Profiler module, it contains a detailed timeline and the option to switch to a Hierarchy view. When you select the Rendering Profiler module, this area displays a list of debugging information. This area is blank when you open the Profiler for the first time, and fills with information when you start profiling your application.


### Profiler controls
The Profiler controls are in the toolbar at the top of the Profiler window. Use these to start or stop recording profiler data, and to navigate through profiled frames.

| Control | Function |
| --- | --- |
| Attach to Player | Select which target to profile your application on. By default, this is set to Playmode. You can also select Editor to profile the Unity Editor and display the resources that the Editor is currently using.Unity also automatically detects any devices that are running on your network or connected via USB, and displays them in the drop-down. Click Enter IP in the drop-down to manually enter the IP address of the device you want to profile your application on. For more information, see Profiling your application. |
| Record | Enable this setting to record profiling information for the active modules when you run your application. If you don’t have this button enabled, the Profiler doesn’t collect any data when you run your application. |
| Back arrow | Navigate one frame back. |
| Forward arrow | Navigate one frame forward. |
| Current Frame | When you click the Current Frame button, the frame indicator line jumps to the last recorded frame, and the Profiler enters Current Frame mode. While the Profiler collects data in this mode, it stays on the current frame and displays the data it collects in real-time. Click the button again to exit Current Frame mode. |
| Frame number | Indicates the frame number you are currently looking at in the Profiler. The number on the left is the current frame selected, and the number on the right is the total number of frames combined that the Profiler collected during your entire Profiling session. |
| Clear | Erase all data from the Profiler window. |
| Clear on Play | Enable this setting to erase all data from the Profiler window next time you click Play in the Player window, or when you connect to a new target device. |
| Deep Profile | Enable this setting to profile all C# methods. When you enable this setting, Unity adds instrumentation to all mono calls, which then allows for a more detailed investigation of your scripts. See Deep Profiling. |
| Call Stacks | To record call stacks for scripting memory allocations, click this toggle. Frames that the Profiler records when you enable this option have information about the selected samples on the full call stack that lead to a managed scripting allocation, even when Deep Profile is not active. By default, the Profiler records the full call stack information for GC.Alloc samples when you enable this setting, but you can change this to a different sample from the dropdown menu (UnsafeUtility.Malloc, JobHandle.Complete, or Native Allocations). For more information, see the Allocation call stacks section of the CPU Usage Profiler module page. |
| Load | Load saved Profiler data into the Profiler window. You can also load binary profile data that the Player has written out to file via the Profiler.logFile API.Hold down the Shift button and click the Load button to append the file contents to the current profile frames. |
| Save | Save the Profiler data into a .data file in your Project folder. |

### Begaining profiling sample & ending profiling sample through scripting

```cs
using UnityEngine;
using System.Collections;
using UnityEngine.Profiling;

public class ExampleClass : MonoBehaviour
{
    void Example()
    {
        Profiler.BeginSample("MyPieceOfCode");
        // Code to measure...
        Profiler.EndSample();
    }
}
```


### ref 
https://www.chunfuchao.com/posts/unity-profiling-tools/ 

https://docs.unity3d.com/Manual/Profiler.html \
https://docs.unity3d.com/Manual/profiler-profiling-applications.html \
https://docs.unity3d.com/Manual/ProfilerWindow.html

**CPU Usage Profiler module** \
https://docs.unity3d.com/Manual/ProfilerCPU.html

**`Profiler`** \
https://docs.unity3d.com/ScriptReference/Profiling.Profiler.html

**`Profiler.BeginSample`** \
https://docs.unity3d.com/ScriptReference/Profiling.Profiler.BeginSample.html

**`Profiler.EndSample`** \
https://docs.unity3d.com/ScriptReference/Profiling.Profiler.EndSample.html



