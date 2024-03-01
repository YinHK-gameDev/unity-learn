## Observations & Sensors

In order for an agent to learn, the observations should include all the information an agent needs to accomplish its task. 
Without sufficient and relevant information, an agent may learn poorly or may not learn at all. 
A reasonable approach for determining what information should be included is to consider what you would need to calculate an analytical solution to the problem, 
or what you would expect a human to be able to use to solve the problem.


> ML-Agents provides multiple ways for an Agent to make observations

### Overriding the `Agent.CollectObservations()` method

Overriding the `Agent.CollectObservations()` method and passing the observations to the provided `VectorSensor`. 
Adding the `[Observable]` attribute to fields and properties on the Agent. Implementing the `ISensor` interface, 
using a `SensorComponent` attached to the Agent to create the `ISensor`.


`Agent.CollectObservations()` is best used for aspects of the environment which are numerical and non-visual. The Policy class calls the `CollectObservations(VectorSensor sensor)` method of each Agent. Your implementation of this function must call `VectorSensor.AddObservation` to add vector observations.

The `VectorSensor.AddObservation` method provides a number of overloads for adding common types of data to your observation vector. You can add Integers and booleans directly to the observation vector, as well as some common Unity data types such as `Vector2`, `Vector3`, and `Quaternion`.



The observations passed to `VectorSensor.AddObservation()` must always contain the same number of elements must always be in the same order. If the number of observed entities in an environment can vary, you can pad the calls with zeros for any missing entities in a specific observation, or you can limit an agent's observations to a fixed subset. For example, instead of observing every enemy in an environment, you could only observe the closest five.

Additionally, when you set up an Agent's `Behavior Parameters` in the Unity Editor, you must set the **Vector Observations > Space Size** to equal the number of floats that are written by `CollectObservations()`.

eg:
```cs
public GameObject ball;

public override void CollectObservations(VectorSensor sensor)
{
    // Orientation of the cube (2 floats)
    sensor.AddObservation(gameObject.transform.rotation.z);
    sensor.AddObservation(gameObject.transform.rotation.x);
    // Relative position of the ball to the cube (3 floats)
    sensor.AddObservation(ball.transform.position - gameObject.transform.position);
    // Velocity of the ball (3 floats)
    sensor.AddObservation(m_BallRb.velocity);
    // 8 floats total
}
```

### ref 
https://unity-technologies.github.io/ml-agents/Learning-Environment-Design-Agents/#observations-and-sensors

