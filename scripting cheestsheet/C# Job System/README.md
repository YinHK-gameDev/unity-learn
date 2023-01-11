## C# Job System

The Unity C# Job System allows users to write multithreaded code that interacts well with the rest of Unity 

A job system manages multithreaded code by creating jobs instead of threads.

A job system manages a group of worker threads across multiple cores. It usually has one worker thread per logical CPU core, to avoid context switching (although it may reserve some cores for the operating system or other dedicated applications).

A job system puts jobs into a job queue to execute. Worker threads in a job system take items from the job queue and execute them. A job system manages dependencies and ensures that jobs execute in the appropriate order.


### Creating jobs
To create a job in Unity you need to implement the `IJob` interface. IJob allows you to schedule a single job that runs in parallel to any other jobs that are running.

Note: A “job” is a collective term in Unity for any struct that implements the `IJob` interface.

To create a job, you need to:

- Create a struct that implements IJob.
- Add the member variables that the job uses.
- Create a method in your struct called Execute with the implementation of the job inside it.

```cs
// Job adding two floating point values together
public struct MyJob : IJob
{
    public float a;
    public float b;
    public NativeArray<float> result;

    public void Execute()
    {
        result[0] = a + b;
    }
}
```


