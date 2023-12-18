## Time

Provide you with numeric values that allow you to measure time elapsing while your game or app is running.

- **`Time.time`** returns the amount of time in seconds since your project started playing.
- **`Time.deltaTime`** returns the amount of time in seconds that elapsed since the last frame completed. This value varies depending on the frames per second
 (FPS) rate at which your game or app is running.
- **`Time.timeScale`** **controls the rate at which time elapses**. The scale at which time passes. You can read this value, or set it to control how fast time passes, allowing you to **create slow-motion effects**. This can be used for slow motion effects or to speed up your application. When timeScale is 1.0, time passes as fast as real time. When timeScale is 0.5 time passes 2x slower than realtime.
- **`Time.fixedDeltaTime`** controls the interval of Unity’s fixed timestep
 loop (used for physics, and if you want to write deterministic time-based code).
- **`Time.maximumDeltaTime`** sets an upper limit on the amount of time the engine will report as having passed by the “delta time” properties above.
  

![](./time-flowchart.png)



### ref 
https://docs.unity3d.com/ScriptReference/Time.html
