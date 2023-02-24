## Dynamic resolution

Dynamic resolution is a Camera setting that allows you to dynamically scale individual render targets, to reduce workload on the GPU. In cases where the application’s frame rate reduces, you can gradually scale down the resolution to maintain a consistent frame rate instead. Unity triggers this scaling if performance data suggests that the frame rate is about to decrease as a result of the application being GPU-bound. You can also trigger the scaling manually by preempting a particularly GPU-intensive section of the application and controlling the scaling via a script. If scaled gradually, dynamic resolution can be almost unnoticeable.
 
 
 






### ref
https://docs.unity3d.com/Manual/DynamicResolution.html

https://docs.unity3d.com/Packages/com.unity.render-pipelines.high-definition@16.0/manual/Dynamic-Resolution.html

