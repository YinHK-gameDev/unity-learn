## SAC (Soft Actor-Critic)
Soft Actor Critic (SAC) is an algorithm that optimizes a stochastic policy in an off-policy way, forming a bridge between stochastic policy optimization and DDPG-style approaches.

In addition to Proximal Policy Optimization (PPO), ML-Agents also provides Soft Actor-Critic to perform reinforcement learning.

In contrast with PPO, SAC is off-policy, which means it can learn from experiences collected at any time during the past. As experiences are collected, they are placed in an experience replay buffer and randomly drawn during training. This makes SAC significantly more sample-efficient, often requiring 5-10 times less samples to learn the same task as PPO. However, SAC tends to require more model updates. SAC is a good choice for heavier or slower environments (about 0.1 seconds per step or more).

SAC is also a "maximum entropy" algorithm, and enables exploration in an intrinsic way. Read more about maximum entropy RL here.

To train an agent, you will need to provide the agent one or more reward signals which the agent should attempt to maximize. See Reward Signals for the available reward signals and the corresponding hyperparameters.



### ref 
https://spinningup.openai.com/en/latest/algorithms/sac.html

https://github.com/yosider/ml-agents-1/blob/master/docs/Training-SAC.md
