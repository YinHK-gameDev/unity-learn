## Unity Analysis

When you make an application in Unity, it’s important that you **analyze and debug** it to make sure that its b**ug-free, optimized, and runs correctly** on the target device.

- Memory in Unity
- The Unity Profiler
- Log files
- Asset Loading Metrics


Unity has several tools that you can use to **measure the performance** of your game:

- **The Unity Profiler**
- **Memory Profiler (package)**
- **Frame Debugger**
- **Physics Debugger**
- **Input Debugger**
- **IMGUI Debugger**


### The Unity Profiler

The Unity Profiler is a tool you can **use to get performance information about your application**. You can connect it to devices on your network or devices connected to your machine to test how your application runs on your intended release platform. You can also run it in the Editor to get an overview of resource allocation while you’re developing your application.


To access the Profiler window go to menu: **Window > Analysis > Profiler**. 

When you use the Unity Profiler to profile your application, there are three main ways to record data:

-   Profile your application in a player on your target platform
-   Profile your application in Play mode in the Unity Editor
-   Profile the Unity Editor

https://www.chunfuchao.com/posts/unity-profiling-tools/

### Memory Profiler
The **Memory Profiler** is a tool you can **use to inspect the memory usage of your Unity application and the Unity Editor**. The package adds a Memory Profiler window to the Unity Editor, which you can use to capture, inspect, and compare Snapshots of memory. Snapshots are a record of how the memory your application uses was organized when the Memory Profiler captured the snapshot.


https://docs.unity3d.com/Packages/com.unity.memoryprofiler@1.0/manual/index.html


### Input Debugger
https://docs.unity3d.com/Packages/com.unity.inputsystem@1.0/manual/Debugging.html

### Garbage collector(GC)

Enabled by default (**Project Settings > Player > Configuration**), this mode spreads out the process of garbage collection over multiple frames.

Incremental **garbage collection (GC)** spreads out the process of garbage collection over multiple frames. This is the default garbage collection behavior in Unity.

https://en.wikipedia.org/wiki/Garbage_collection_(computer_science)



### ref 
https://docs.unity3d.com/Manual/analysis.html \

