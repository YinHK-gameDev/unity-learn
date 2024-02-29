## Unity.MLAgents


- In your own **Agent script**, Import **ML-Agent package** by adding: 

  ```cs
     using Unity.MLAgents;
     using Unity.MLAgents.Sensors;
     using Unity.MLAgents.Actuators;
  ```
- Change the base class from **`MonoBehaviour`** to **`Agent`**.
- Delete **`Update()`** since not using it, but keep **`Start()`**.
- Next, we will add the logic that will let our Agent learn to roll to the cube using reinforcement learning. More specifically, we will need to extend three methods from the `Agent` base class:

  -   **`OnEpisodeBegin()`**
  -   **`CollectObservations(VectorSensor sensor)`**
  -   **`OnActionReceived(ActionBuffers actionBuffers)`**

### Initialization and Resetting the Agent
The process of training in the ML-Agents Toolkit involves running episodes where the Agent (Sphere) attempts to solve the task. Each episode lasts until the Agents solves the task (i.e. reaches the cube), fails (rolls off the platform) or times out (takes too long to solve or fail at the task). At the start of each episode, **`OnEpisodeBegin()`** is called to set-up the environment for a new episode. Typically the scene is initialized in a random manner to enable the agent to learn to solve the task under a variety of conditions.

#### `Agent.OnEpisodeBegin()`
Called at the beginning of an Agent's episode, including at the beginning of the simulation.

### Observing the Environment

The Agent sends the information we collect to the Brain, which uses it to make a decision. When you train the Agent (or use a trained model), the data is fed into a neural network as a feature vector. For an Agent to successfully learn a task, we need to provide the correct information. A good rule of thumb for deciding what information to collect is to consider what you would need to calculate an analytical solution to the problem.

#### `Agent.CollectObservations(VectorSensor)`

`Agent.CollectObservations()` is best used for aspects of the environment which are numerical and non-visual. The Policy class calls the `CollectObservations(VectorSensor sensor)` method of each Agent. Your implementation of this function must call `VectorSensor.AddObservation` to add vector observations.

Called every step that the Agent requests a decision. This is one possible way for collecting the Agent's observations of the environment; see Generating Observations below for more options.

An **agent's observation** is **any environment information that helps the agent achieve its goal**. For example, for a fighting agent, its observation could include distances to friends or enemies, or the current level of ammunition at its disposal.

> You can use **a combination of vector, visual, and raycast observations for an agent**. If you **only use visual** or **raycast observations**, you **do not need** to implement a `CollectObservations()` function.


Add vector observations to the sensor parameter passed to this method by calling the **VectorSensor helper methods**:

```cs
// Adds a boolean observation to the vector observation of the agent.
public void AddObservation(bool observation);

// Adds a list or array of float observations to the vector observations of the agent.
public void AddObservation(IList<float> observation);

// Adds an integer observation to the vector observations of the agent.
public void AddObservation(int observation);

// Adds a float observation to the vector observations of the agent.
public void AddObservation(float observation);

// Adds a quaternion observation to the vector observations of the agent.
public void AddObservation(Quaternion observation);

// Adds an Vector2 observation to the vector observations of the agent.
public void AddObservation(Vector2 observation);

// Adds an Vector3 observation to the vector observations of the agent.
public void AddObservation(Vector3 observation);

// Adds a one-hot encoding observation.
public void AddOneHotObservation(int observation, int range);

```

### Taking Actions and Assigning Rewards
The final part of the Agent code is the `Agent.OnActionReceived()` method, which receives actions and assigns the reward.

#### `Agent.OnActionReceived(ActionBuffers)`

`Agent.OnActionReceived()` — Called every time the Agent receives an action to take. Receives the action chosen by the Agent. It is also common to assign a reward in this method.

Implement `OnActionReceived()` to specify agent behavior at **every step**, based on the provided action.

An action is passed to this function in the form of an `ActionBuffers`. Your implementation **must use the array to direct the agent's behavior** for the current step.

> You decide **how many elements** you need in the `ActionBuffers` to **control your agen**t and **what each element means**.

For example, if you want to apply a force to **move an agent around the environment**, you can **arbitrarily pick three value**s in **`ActionBuffers.ContinuousActions`** array to use as the **force components**. During training, the agent's **policy learns to set those particular elements of the array to maximize the training rewards the agent receives**. (Of course, if you implement a **`Heuristic`(in ActionBuffers) function**, it **must use the same elements of the action array** for the same purpose since there is no learning involved.)

> An Agent can use **continuous** and/or **discrete actions**.

- When an agent uses **continuous actions**, the values in the `ActionBuffers.ContinuousActions` array are **floating point numbers**. You should **clamp the values** to the range, **`-1..1`**, to increase **numerical stability** during training.

- When an agent uses discrete actions, the values in the **`ActionBuffers.DiscreteActions`** array are **integers** that each **represent a specific, discrete actio**n. For example, you could define a set of discrete actions such as:

  ```
	0 = Do nothing
	1 = Move one space left
	2 = Move one space right
	3 = Move one space up
	4 = Move one space down
  ```

When making a decision, the agent picks one of the five actions and puts the corresponding integer value in the ActionBuffers.DiscreteActions array. For example, if the agent decided to move left, the ActionBuffers.DiscreteActions parameter would be an array with a single element with the value 1.

You can define multiple sets, or branches, of discrete actions to allow an agent to perform simultaneous, independent actions. For example, you could use one branch for movement and another branch for throwing a ball left, right, up, or down, to allow the agent to do both in the same step.

The ActionBuffers.DiscreteActions array of an agent with discrete actions contains one element for each branch. The value of each element is the integer representing the chosen action for that branch. The agent always chooses one action for each branch.

Struct **`ActionBuffers`**:

```cs
// An empty action buffer.
public static ActionBuffers Empty

// Holds the Continuous ActionSegment<T> to be used by an IActionReceiver
public readonly ActionSegment<float> ContinuousActions { get; }

// Holds the Discrete ActionSegment<T> to be used by an IActionReceiver
public readonly ActionSegment<int> DiscreteActions { get; }

// Clear the ContinuousActions and DiscreteActions segments to be all zeros
public readonly void Clear()

// Indicates whether the current ActionBuffers is equal to another ActionBuffers
public override readonly bool Equals(object obj)

```

Struct **`ActionSegment<T>`**:

`ActionSegment{T}` is a data structure that **allows access to a segment of an underlying array in order to avoid the copying and allocation of sub-arrays**. The segment is defined by the offset into the original array, and an length.



#### Rewards
Reinforcement learning requires rewards to signal which decisions are good and which are bad. The learning algorithm uses the rewards to determine whether it is giving the Agent the optimal actions. You want to reward an Agent for completing the assigned task. Rewards are used during reinforcement learning; they are ignored during inference. Typically, you assign rewards in the Agent subclass's OnActionReceived(ActionBuffers) implementation after carrying out the received action and evaluating its success.

- Calls **`Agent.AddReward(float increment)`** for increments the step and episode rewards by the provided value. \
  Use a **positive reward to reinforce desired behavior**. You can use a **negative reward to penalize mistakes**. 
  ```cs
    public void AddReward(float increment)
  ```
- Calls **`Agent.SetReward(float reward)`** to assign a reward. This function replaces any rewards given to the agent during the current step. Use `AddReward(float increment)` to **incrementally change the reward rather than overriding it**. Use `SetReward()` to set the reward assigned to the current step with a specific value rather than increasing or decreasing it.
  ```cs
    public void SetReward(float reward)
  ```
- Marks the agent as finished by calling **`EndEpisode()`** on the **Agent**. Sets the done flag to true and resets the agent.
  > This should be used when the episode can **no longer continue**, such as when the **Agent reaches the goal** or **fails at the task**.
  ```cs
    public void EndEpisode()
  ```


### Decisions

The observation-decision-action-reward cycle repeats each time the Agent request a decision. Agents will request a decision when `Agent.RequestDecision()` is called. If you need the Agent to request decisions on its own at regular intervals, add a `Decision Requester` component to the Agent's GameObject. Making decisions at regular step intervals is generally most appropriate for physics-based simulations. For example, an agent in a robotic simulator that must provide fine-control of joint torques should make its decisions every step of the simulation. In games such as real-time strategy, where many agents make their decisions at regular intervals, the decision timing for each agent can be staggered by setting the `DecisionStep` parameter in the `Decision Requester` component for each agent. On the other hand, an agent that only needs to make decisions when certain game or simulation events occur, such as in a turn-based game, should call `Agent.RequestDecision()` manually.

https://unity-technologies.github.io/ml-agents/Learning-Environment-Design-Agents/#decisions

### Testing the Environment

It is always a good idea to first test your environment by controlling the Agent using the keyboard. To do so, you will need to extend the `Heuristic()` method in the `RollerAgent` class. For our example, the heuristic will generate an action corresponding to the values of the "Horizontal" and "Vertical" input axis (which correspond to the keyboard arrow keys).


Eg:


```cs
public override void Heuristic(in ActionBuffers actionsOut)
{
    var continuousActionsOut = actionsOut.ContinuousActions;
    continuousActionsOut[0] = Input.GetAxis("Horizontal");
    continuousActionsOut[1] = Input.GetAxis("Vertical");
}

```

### Example
```cs
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.MLAgents;
using Unity.MLAgents.Sensors;
using Unity.MLAgents.Actuators;


public class RollerAgent : Agent
{
	public Transform Target;
	private Rigidbody rBody;
	private float timer=0;
	public float forceMultiplier = 10;
	


	// Start is called before the first frame update
	void Start()
	{
		rBody = GetComponent<Rigidbody>();
	}
	
	void Update() 
	{
		timer += Time.deltaTime;
	}

	public override void OnEpisodeBegin() 
	{
		
		timer = 0;
		// If the Agent fell, zero its momentum
		if (this.transform.localPosition.y < 0)
		{
			this.rBody.angularVelocity = Vector3.zero;
			this.rBody.velocity = Vector3.zero;
			this.transform.localPosition = new Vector3( 0, 0.5f, 0);
		}

		// Move the target to a new spot
		Target.localPosition = new Vector3(Random.Range(-4.0f, 4.0f), 0.5f, Random.Range(-4.0f, 4.0f));
	}

	public override void CollectObservations(VectorSensor sensor)
	{
		// Target and Agent positions
		sensor.AddObservation(Target.localPosition);
		sensor.AddObservation(this.transform.localPosition);

		// Agent velocity
		sensor.AddObservation(rBody.velocity.x);
		sensor.AddObservation(rBody.velocity.z);
	}

	public override void OnActionReceived(ActionBuffers actionBuffers)
	{
		// Actions, size = 2
		Vector3 controlSignal = Vector3.zero;
		controlSignal.x = actionBuffers.ContinuousActions[0];
		controlSignal.z = actionBuffers.ContinuousActions[1];
		rBody.AddForce(controlSignal * forceMultiplier);

		// Rewards
		float distanceToTarget = Vector3.Distance(this.transform.localPosition, Target.localPosition);

		// Reached target
		if (distanceToTarget < 1.42f)
		{
			SetReward(50.0f);
			EndEpisode();
		}
		// Over time
		else if (timer == 15.0f)
		{
			SetReward(-50.0f);
			EndEpisode();
		}
	}
}

```



### ref 

**MLAgents**: \
https://docs.unity3d.com/Packages/com.unity.ml-agents@2.3/api/Unity.MLAgents.html \
**MLAgents.Actuators**: \
https://docs.unity3d.com/Packages/com.unity.ml-agents@2.3/api/Unity.MLAgents.Actuators.html \
**MLAgents.Sensors**: \
https://docs.unity3d.com/Packages/com.unity.ml-agents@2.3/api/Unity.MLAgents.Sensors.html \
**MLAgents.Sensors.VectorSensor**: \
https://docs.unity3d.com/Packages/com.unity.ml-agents@2.3/api/Unity.MLAgents.Sensors.VectorSensor.html#methods \
**MLAgents.Actuators.ActionBuffers**: \
https://docs.unity3d.com/Packages/com.unity.ml-agents@2.3/api/Unity.MLAgents.Actuators.ActionBuffers.html \
**MLAgents.Actuators.ActionSegment<T>**: \
https://docs.unity3d.com/Packages/com.unity.ml-agents@2.3/api/Unity.MLAgents.Actuators.ActionSegment-1.html

https://github.com/Unity-Technologies/ml-agents/blob/develop/docs/Learning-Environment-Create-New.md


