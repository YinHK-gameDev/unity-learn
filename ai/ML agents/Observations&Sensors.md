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



#### Observable Fields and Properties

Another approach is to define the relevant observations as fields or properties on your Agent class, and annotate them with an `ObservableAttribute`. For example, in the Ball3DHardAgent, the difference between positions could be observed by adding a property to the Agent:

```
using Unity.MLAgents.Sensors.Reflection;

public class Ball3DHardAgent : Agent {

    [Observable(numStackedObservations: 9)]
    Vector3 PositionDelta
    {
        get
        {
            return ball.transform.position - gameObject.transform.position;
        }
    }
}
```

`ObservableAttribute` currently supports most basic types (e.g. floats, ints, bools), as well as `Vector2`, `Vector3`, `Vector4`, `Quaternion`, and enums.


> **NOTE**: you do not need to adjust the Space Size in the Agent's `Behavior Parameters` when you add `[Observable]` fields or properties to an Agent, since their size can be computed before they are used.




> Both `Agent.CollectObservations()` and `ObservableAttribute`s produce vector observations, which are represented at lists of `float`s. `ISensor`s can produce both vector observations and visual observations, which are multi-dimensional arrays of floats.

#### One-hot encoding categorical information

Type enumerations should be encoded in the _one-hot_ style. That is, add an element to the feature vector for each element of enumeration, setting the element representing the observed member to one and set the rest to zero. For example, if your enumeration contains \[Sword, Shield, Bow\] and the agent observes that the current item is a Bow, you would add the elements: 0, 0, 1 to the feature vector. The following code example illustrates how to add.

```
enum ItemType { Sword, Shield, Bow, LastItem }
public override void CollectObservations(VectorSensor sensor)
{
    for (int ci = 0; ci &lt; (int)ItemType.LastItem; ci++)
    {
        sensor.AddObservation((int)currentItem == ci ? 1.0f : 0.0f);
    }
}
```

`VectorSensor` also provides a two-argument function `AddOneHotObservation()` as a shortcut for _one-hot_ style observations. The following example is identical to the previous one.

```
enum ItemType { Sword, Shield, Bow, LastItem }
const int NUM_ITEM_TYPES = (int)ItemType.LastItem + 1;

public override void CollectObservations(VectorSensor sensor)
{
    // The first argument is the selection index; the second is the
    // number of possibilities
    sensor.AddOneHotObservation((int)currentItem, NUM_ITEM_TYPES);
}
```

`ObservableAttribute` has built-in support for enums. Note that you don't need the `LastItem` placeholder in this case:

```
enum ItemType { Sword, Shield, Bow }

public class HeroAgent : Agent
{
    [Observable]
    ItemType m_CurrentItem;
}
```




### ref 
https://unity-technologies.github.io/ml-agents/Learning-Environment-Design-Agents/#observations-and-sensors

