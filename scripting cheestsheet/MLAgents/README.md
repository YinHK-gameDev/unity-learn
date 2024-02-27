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

#### `Agent.CollectObservations()`

`Agent.CollectObservations()` is best used for aspects of the environment which are numerical and non-visual. The Policy class calls the `CollectObservations(VectorSensor sensor)` method of each Agent. Your implementation of this function must call `VectorSensor.AddObservation` to add vector observations.

Called every step that the Agent requests a decision. This is one possible way for collecting the Agent's observations of the environment; see Generating Observations below for more options.


### Taking Actions and Assigning Rewards
The final part of the Agent code is the `Agent.OnActionReceived()` method, which receives actions and assigns the reward.

#### `Agent.OnActionReceived()`

`Agent.OnActionReceived()` — Called every time the Agent receives an action to take. Receives the action chosen by the Agent. It is also common to assign a reward in this method.


#### Rewards
Reinforcement learning requires rewards to signal which decisions are good and which are bad. The learning algorithm uses the rewards to determine whether it is giving the Agent the optimal actions. You want to reward an Agent for completing the assigned task. 

- Calls **`Agent.SetReward()`** to assign a reward.
- Marks the agent as finished by calling **`EndEpisode()`** on the **Agent**.



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
https://docs.unity3d.com/Packages/com.unity.ml-agents@2.3/api/Unity.MLAgents.html \
https://docs.unity3d.com/Packages/com.unity.ml-agents@2.3/api/Unity.MLAgents.Actuators.html \
https://github.com/Unity-Technologies/ml-agents/blob/develop/docs/Learning-Environment-Create-New.md


