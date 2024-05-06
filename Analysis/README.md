## Unity Analysis

When you make an application in Unity, it’s important that you **analyze and debug** it to make sure that its **bug-free, optimized, and runs correctly** on the target device.

- Memory in Unity
- The Unity Profiler
- Log files
- Asset Loading Metrics
- Script debugging


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

#### Installing Memory Profiler
You can install the package using the package registry list. Or using **`com.unity.memoryprofiler`** name when adding a registry package by name.

https://docs.unity3d.com/Packages/com.unity.memoryprofiler@1.0/manual/index.html


### Input Debugger
https://docs.unity3d.com/Packages/com.unity.inputsystem@1.0/manual/Debugging.html

### Garbage collector(GC)

Enabled by default (**Project Settings > Player > Configuration**), this mode spreads out the process of garbage collection over multiple frames.

Incremental **garbage collection (GC)** spreads out the process of garbage collection over multiple frames. This is the default garbage collection behavior in Unity.

https://en.wikipedia.org/wiki/Garbage_collection_(computer_science)


### Script debugging

You can use a debugger to inspect your source code while your application is running. Unity supports the following code editors to debug C# code:

- Visual Studio (with the Visual Studio Tools for Unity plug-in)
- Visual Studio for Mac
- Jetbrains Rider

> Note that while the Visual Studio IDE supports Unity debugging, the Visual Studio Code text editor does not.

Although these code editors vary slightly in the debugging features they support, they all provide basic functionality such as break points, single stepping, and variable inspection. You can attach these code editors to the Unity Editor or Unity Player to debug your code.

#### Debug in the Unity Editor

You can debug C# code as it runs in the Unity Editor while the Unity Editor is in **Play Mode**.

To debug in the Editor, you need to set the Editor’s **Code Optimization mode** to **Debug Mode**, then you can attach a code editor with a debugging feature.

To change the **Code Optimization mode**, select the **Debug Button in the bottom right** of the Unity Editor Status Bar.

The Debug Button in the bottom right of the Unity Editor Status Bar

Unity’s Code Optimization setting has two modes:

-   **Debug Mode**, which you can use to attach external debugger software, but gives slower C# performance when you run your Project in Play Mode in the Editor.
-   **Release Mode**, which gives faster C# performance when you run your Project in Play Mode in the Editor, but you cannot attach any external debuggers.


To change which mode the Unity Editor starts up in, go to **Edit** (macOS: **Unity**) > **Preferences** > **General** > **Code Optimization On Startup**.


https://docs.unity3d.com/6000.0/Documentation/Manual/ManagedCodeDebugging.html

### ref 
https://docs.unity3d.com/Manual/analysis.html 

