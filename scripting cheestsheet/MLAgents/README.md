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

  -   **`Initialize()`**
  -   **`OnEpisodeBegin()`**
  -   **`CollectObservations(VectorSensor sensor)`**
  -   **`OnActionReceived(ActionBuffers actionBuffers)`**

### Initialization and Resetting the Agent
The process of training in the ML-Agents Toolkit involves running episodes where the Agent (Sphere) attempts to solve the task. Each episode lasts until the Agents solves the task (i.e. reaches the cube), fails (rolls off the platform) or times out (takes too long to solve or fail at the task). At the start of each episode, **`OnEpisodeBegin()`** is called to set-up the environment for a new episode. Typically the scene is initialized in a random manner to enable the agent to learn to solve the task under a variety of conditions.

#### `Agent.Initialize()`
Implement Initialize() to perform **one-time initialization or set up of the Agent instance**.

```cs
	public virtual void Initialize()
```

> `Initialize()` is **called once when the agent is first enabled**. If, for example, the Agent object needs references to other GameObjects in the scene, you can **collect and store those references here**.

#### `Agent.OnEpisodeBegin()`
Called at the beginning of an Agent's episode, including at the beginning of the simulation.

```cs
	public virtual void OnEpisodeBegin()
```

> Note that OnEpisodeBegin() is called **at the start of each of the agent's "episodes"**. You can use that function for items that need to be **reset for each episode**.


### Observing the Environment

The **Agent sends the information we collect to the Brain**, which **uses it to make a decision**. When you train the Agent (or use a trained model), the data is **fed into a neural network as a feature vector**. For an Agent to **successfully learn a t**ask, we need to **provide the correct information**. A good rule of thumb for deciding what information to collect is to consider what you would need to calculate an analytical solution to the problem.

#### `Agent.CollectObservations(VectorSensor)`

`Agent.CollectObservations()` is best used for aspects of the environment which are **numerical** and **non-visual**. The Policy class calls the `CollectObservations(VectorSensor sensor)` method of each Agent. Your implementation of this function **must** call `VectorSensor.AddObservation` to add vector observations.

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


Eg: 
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

### Taking Actions and Assigning Rewards
The final part of the Agent code is the `Agent.OnActionReceived()` method, which receives actions and assigns the reward.

#### `Agent.OnActionReceived(ActionBuffers)`

`Agent.OnActionReceived()` — Called every time the Agent receives an action to take. Receives the action chosen by the Agent. It is also common to assign a reward in this method.

Implement `OnActionReceived()` to specify agent behavior at **every step**, based on the provided action.

An action is passed to this function in the form of an `ActionBuffers`. Your implementation **must use the array to direct the agent's behavior** for the current step.

> You decide **how many elements** you need in the `ActionBuffers` to **control your agent** and **what each element means**.

For example, if you want to apply a force to **move an agent around the environment**, you can **arbitrarily pick three value**s in **`ActionBuffers.ContinuousActions`** array to use as the **force components**. During training, the agent's **policy learns to set those particular elements of the array to maximize the training rewards the agent receives**. (Of course, if you implement a **`Heuristic`(in ActionBuffers) function**, it **must use the same elements of the action array** for the same purpose since there is no learning involved.)

> An Agent can use **continuous** and/or **discrete actions**. An Agent can use **continuous and/or discrete actions**. Configure this along with the size of the action array, in the `BrainParameters` of the agent's associated **BehaviorParameters component**.

- When an agent uses **continuous actions**, the values in the `ActionBuffers.ContinuousActions` array are **floating point numbers**. You should **clamp the values** to the range, **`-1..1`**, to increase **numerical stability** during training. \
  `ActionBuffers.ContinuousActions.Length` = **number of continous actions you defined**. Pass the initial value from the range **`-1..1`** for each contionous action.
  The **continuous actions** to send to an `IActionReceiver`. \
  When an Agent's Policy has **Continuous** actions, the `ActionBuffers.ContinuousActions` passed to the Agent's `OnActionReceived()` function is an array **with length equal to the `Continuous Action Size` property value**. The individual values in the array have whatever meanings that you ascribe to them. If you assign an element in the array as the speed of an Agent, for example, the training process learns to control the speed of the Agent through this parameter.

- When an agent uses discrete actions, the values in the **`ActionBuffers.DiscreteActions`** array are **integers** that each **represent a specific, discrete action**. The **discrete actions** to send to an **`IActionReceiver`**. \
  When an Agent's Policy uses **discrete** actions, the `ActionBuffers.DiscreteActions` passed to the Agent's `OnActionReceived()` function is an array of integers with length equal to `Discrete Branch Size`. \
  When defining the discrete actions, **`Branches`** is **an array of integers**, each value **corresponds to the number of possibilities for each branch**. Each branch in branches(array) has a numbers of **possible discrete actions**. For each number in the branch, assign action for them. \ 
  For example, you could **define a set of discrete actions** such as:

  ```
	0 = Do nothing
	1 = Move one space left
	2 = Move one space right
	3 = Move one space up
	4 = Move one space down
  ```
  ```cs
		// Get the action index for movement
		int movement = actionBuffers.DiscreteActions[0];
		// Get the action index for jumping
		int jump = actionBuffers.DiscreteActions[1];

		// Look up the index in the movement action list:
		if (movement == 1) { directionX = -1; }
		if (movement == 2) { directionX = 1; }
		if (movement == 3) { directionZ = -1; }
		if (movement == 4) { directionZ = 1; }
		// Look up the index in the jump action list:
		if (jump == 1 && IsGrounded()) { directionY = 1; }

		// Apply the action results to move the Agent
		gameObject.GetComponent<Rigidbody>().AddForce( new Vector3(directionX * 40f, directionY * 300f, directionZ * 40f));
  ```
  When making a decision, the agent picks one of the five actions and puts the corresponding integer value in the `ActionBuffers.DiscreteActions` array. \
  For example, if the agent decided to **move left**, the `ActionBuffers.DiscreteActions` parameter would be an array with a **single element with the value 1**. \
  You can define **multiple sets, or branches, of discrete actions** to allow an agent to perform simultaneous, independent actions. For example, you could use one branch for movement and another branch for throwing a ball left, right, up, or down, to allow the agent to do both in the same step. \
  The `ActionBuffers.DiscreteActions` array of an agent with discrete actions contains **one element for each branch**. The value of each element is the integer representing the chosen action for that branch. The agent always **chooses one action for each branch**. \
  When you use the discrete actions, you can **prevent the training process or the neural network model from choosing specific actions** in a step by implementing the **`WriteDiscreteActionMask(IDiscreteActionMask)`** method. \
  For example, if your agent is next to a wall, you could **mask out any actions** that would result in the agent **trying to move into the wall.** 
  > Note that when the Agent is controlled by its Heuristic, the Agent will still be able to decide to perform the masked action. In order to disallow an action, override the `Agent.WriteDiscreteActionMask()` virtual method, and call `SetActionEnabled()` on the provided `IDiscreteActionMask`.


#### `Agent.WriteDiscreteActionMask(IDiscreteActionMask)`
Implement `WriteDiscreteActionMask()` to collects the masks for discrete actions. When using discrete actions, the agent will not perform the masked action.


```cs
	public virtual void WriteDiscreteActionMask(IDiscreteActionMask actionMask)
```


```cs
	public override void WriteDiscreteActionMask(IDiscreteActionMask actionMask)
	{
    		actionMask.SetActionEnabled(branch, actionIndex, isEnabled);
	}
```

> When using **Discrete Control**, you can **prevent the Agent from using a certain action** by masking it with `SetActionEnabled(Int32, Int32, Boolean)`.

Interface **`IDiscreteActionMask`**: 

Interface for writing a mask to **disable discrete actions for agents for the next decision**.

```cs
 	void SetActionEnabled(int branch, int actionIndex, bool isEnabled)
```

Where:

-   **`branch`** is the **index (starting at 0) of the branch** on which you want to allow or **disallow the action**. The branch for which the actions will be **masked**.
-   **`actionIndex`** is the **index of the action** in the specific branch that you want to allow or disallow.
-   **`isEnabled`** is a bool **indicating whether the action should be allowed or not**.

> By default, all discrete actions are allowed. If isEnabled is false, the agent will not be able to perform the actions passed as argument at the next decision for the specified action branch. The actionIndex corresponds to the action options the agent will be unable to perform.

-   You can call `SetActionEnabled` multiple times if you want to put masks on multiple branches.
-   At each step, the state of an action is reset and enabled by default.
-   You cannot mask all the actions of a branch.
-   You cannot mask actions in continuous control.

Struct **`ActionBuffers`**:

A structure that wraps the **`ActionSegment<T>`** s for a particular **`IActionReceiver`** and is used when **`OnActionReceived(ActionBuffers)`** is called.

```cs
// Construct an ActionBuffers instance with the continuous and discrete actions that will be used
public ActionBuffers(float[] continuousActions, int[] discreteActions)

// Construct an ActionBuffers instance with the continuous and discrete actions that will be used
public ActionBuffers(ActionSegment<float> continuousActions, ActionSegment<int> discreteActions)

// Construct an ActionBuffers instance with ActionSpec. All values are initialized to zeros
public ActionBuffers(ActionSpec actionSpec)


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

// Create an ActionBuffers instance with discrete actions stored as a float array.
public static ActionBuffers FromDiscreteActions(float[] discreteActions)

```

Struct **`ActionSegment<T>`**:

`ActionSegment{T}` is a data structure that **allows access to a segment of an underlying array in order to avoid the copying and allocation of sub-arrays**. The segment is defined by the offset into the original array, and an length.

```cs
// Create an ActionSpec initialized with the specified action sizes.
public ActionSpec(int numContinuousActions = 0, int[] discreteBranchSizes = null)

// Allows access to the underlying array using array syntax.
public readonly T this[int index] { get; set; }

// Get the underlying Array of this segment.
public readonly T[] Array { get; }

// The number of items this segment can access in the underlying array.
public readonly int Length

// An Empty segment which has an offset of 0, a Length of 0
public static ActionSegment<T> Empty

// The number of items this segment can access in the underlying array
public readonly int Length

// The zero-based offset into the original array at which this segment starts
public readonly int Offset

```

Struct **`ActionSpec`**:

```cs
// An array of branch sizes for discrete actions.
// Branches is an array of integers
// The array of branch sizes for the discrete actions. Each index contains the number of actions available for that branch.
// For an IActuator that uses discrete actions, the number of branches is the Length of the Array and each index contains the branch size.
// The cumulative sum of the total number of discrete actions can be retrieved by the SumOfDiscreteBranchSizes property.
public int[] BranchSizes

// The number of continuous actions that an Agent can take.
public int NumContinuousActions { get; set; }

// The number of branches for discrete actions that an Agent can take.
public readonly int NumDiscreteActions { get; }

// Get the total number of Discrete Actions that can be taken by calculating the Sum of all of the Discrete Action branch sizes.
public readonly int SumOfDiscreteBranchSizes { get; }

// Combines a list of actions specs and allocates a new array of branch sizes if needed.
public static ActionSpec Combine(params ActionSpec[] specs)

// Creates a Continuous ActionSpec with the number of actions available.
public static ActionSpec MakeContinuous(int numActions)

// Creates a Discrete ActionSpec with the array of branch sizes that represents the action space.
public static ActionSpec MakeDiscrete(params int[] branchSizes)

```


Interface **`IActionReceiver`**:

An interface that **describes an object that can receive actions** from a **Reinforcement Learning network**.

```cs
// Method called in order too allow object to execute actions based on the ActionBuffers contents.
void OnActionReceived(ActionBuffers actionBuffers)

// Implement WriteDiscreteActionMask() to modify the masks for discrete actions.
// When using discrete actions, the agent will not perform the masked action.
void WriteDiscreteActionMask(IDiscreteActionMask actionMask)

```

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

#### `Agent.RequestDecision()`

The observation-decision-action-reward cycle repeats each time the Agent request a decision. Agents will request a decision when `Agent.RequestDecision()` is called. If you need the Agent to request decisions on its own at regular intervals, add a `Decision Requester` component to the Agent's GameObject. Making decisions at regular step intervals is generally most appropriate for physics-based simulations. For example, an agent in a robotic simulator that must provide fine-control of joint torques should make its decisions every step of the simulation. In games such as real-time strategy, where many agents make their decisions at regular intervals, the decision timing for each agent can be staggered by setting the `DecisionStep` parameter in the `Decision Requester` component for each agent. On the other hand, an agent that only needs to make decisions when certain game or simulation events occur, such as in a turn-based game, should call `Agent.RequestDecision()` manually.


Requests a new decision for this agent.
```cs
 public void RequestDecision()
```

Call `RequestDecision()` whenever an agent needs a decision. You often want to request a decision every environment step. However, if an agent cannot use the decision every step, then you can request a decision less frequently.

> You can add a **DecisionRequester component** to the agent's GameObject to **drive the agent's decision making**. When you use this component, **do not call `RequestDecision()` separately**. Note that this function calls `RequestAction()`; you **do not need to call both functions at the same time**.

#### `Agent.RequestAction()`

Requests an action for the agent.

```cs
  public void RequestAction()
```

Call **`RequestAction()`** to **repeat the previous action returned by the agent's most recent decision**. A **new decision** is **not requested**. When you **call this function**, the Agent instance **invokes `OnActionReceived(ActionBuffers)`** with the **existing action vector**.

You can use **`RequestAction()`** in situations where an agent **must take an action every update**, but d**oesn't need to make a decision as often**. \
For example, an agent that moves through its environment might need to apply an action to keep moving, but only needs to make a decision to change course or speed occasionally.

You can add a **DecisionRequester component** to the agent's GameObject to drive the agent's decision making and action **frequency**. 

> When you use this component, **do not call `RequestAction()` separately**. Note that `RequestDecision()` calls `RequestAction()`; you **do not need to call both functions at the same time**.

https://unity-technologies.github.io/ml-agents/Learning-Environment-Design-Agents/#decisions

### Testing the Environment

It is always a good idea to first test your environment by **controlling the Agent using the keyboard**. To do so, you will need to extend the `Heuristic()` method in the `RollerAgent` class. For our example, the heuristic will generate an action corresponding to the values of the "Horizontal" and "Vertical" input axis (which correspond to the keyboard arrow keys).


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
https://docs.unity3d.com/Packages/com.unity.ml-agents@2.3/api/Unity.MLAgents.Actuators.ActionSegment-1.html \
**​MLAgents.​Actuators.IAction​Receiver**: \
https://docs.unity3d.com/Packages/com.unity.ml-agents@2.3/api/Unity.MLAgents.Actuators.IActionReceiver.html \
**​MLAgents.​Actuators.ActionSpec**: \
https://docs.unity3d.com/Packages/com.unity.ml-agents@2.3/api/Unity.MLAgents.Actuators.ActionSpec.html?q=branch

https://github.com/Unity-Technologies/ml-agents/blob/develop/docs/Learning-Environment-Create-New.md


