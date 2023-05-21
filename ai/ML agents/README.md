## Unity Machine Learning  Agent

**The Unity Machine Learning Agents Toolkit** (ML-Agents) is an open-source project that enables games and simulations to serve as environments for training intelligent agents. We provide implementations (based on PyTorch) of state-of-the-art algorithms to enable game developers and hobbyists to easily train intelligent agents for 2D, 3D and VR/AR games. Researchers can also use the provided simple-to-use Python API to train Agents using reinforcement learning, imitation learning, neuroevolution, or any other methods. These trained agents can be used for multiple purposes, including controlling NPC behavior (in a variety of settings such as multi-agent and adversarial), automated testing of game builds and evaluating different game design decisions pre-release. The ML-Agents Toolkit is mutually beneficial for both game developers and AI researchers as it provides a central platform where advances in AI can be evaluated on Unity’s rich environments and then made accessible to the wider research and game developer communities.


### How Unity ML-Agents works

- **Integrate** \
  Integrate the ML-Agents Unity package.
- **Train** \
  Connect your integrated Unity project and start training the agents to learn the right behaviour. 
- **Embed** \
  When training is complete, embed the trained agent model back into your Unity project.

### Installation
https://unity-technologies.github.io/ml-agents/Installation/

### Using virtual environment
https://unity-technologies.github.io/ml-agents/Using-Virtual-Environment/


### Example for getting started guide from official doc
https://github.com/Unity-Technologies/ml-agents/blob/release_20_docs/docs/Getting-Started.md

### Sample projects
Unity ml agents provide 18+ example environments for demo. 

load the sample Unity Project provided by ml-agents.

- In the Unity Hub, click **Open** > **Add project from disk**.
- Navigate to wherever you cloned or downloaded the **ml-agents repository** from github.
- Select the **'Project'** folder, and click **'Select Folder'** in the file browser

https://github.com/Unity-Technologies/ml-agents/blob/release_18_docs/docs/Learning-Environment-Examples.md


### Train your agent with reinforcement learning
Run in your terminal from the **root** directory
```
mlagents-learn
```
> run `mlagents-learn` from any directory.

### Observing Training Progress
Once you start training using `mlagents-learn`, while training, you'll receive information about the training progress from the console. You'll also be able to visualize the training by running in a separate terminal:
```
tensorboard --logdir results
```

### Embedding the model back into your Unity Environment
Once training has been completed, the training process saves the model. Your trained model will be at **`results/<run-identifier>/<behavior_name>.onnx`** where **`<behavior_name>`** is the name of the Behavior Name of the agents corresponding to the model.  

> **Note**: Do not just close the Unity Window once the Saved Model message appears. Either wait for the training process to close the window or press `Ctrl+C` at the command-line prompt. If you close the window manually, the **`.onnx`** file containing the trained model is not exported.


- In the Hierarchy panel, select the **Agent object**.
- Drag your model (**`behavior_name>.onnx`** file) the *Model** field under **Behavior Parameters** in the Inspector panel.
- Set inference device to CPU (for most of the models generated with the ML-Agents toolkit, CPU will be faster than GPU)



### ref
web doc \
https://unity-technologies.github.io/ml-agents/ \
https://unity-technologies.github.io/ml-agents/ML-Agents-Toolkit-Documentation/

package doc \
https://docs.unity3d.com/Packages/com.unity.ml-agents@2.0/manual/index.html

https://github.com/Unity-Technologies/ml-agents

https://unity.com/products/machine-learning-agents


https://medium.com/ericzhan-publication/unity-ml-agent%E7%AD%86%E8%A8%98-%E5%AE%8C%E5%85%A8%E5%BE%9E%E9%9B%B6%E9%96%8B%E5%A7%8B%E7%9A%84%E6%A9%9F%E5%99%A8%E5%AD%B8%E7%BF%92-01-39472fccc7be

https://a0707127.medium.com/unity-ml-agents-installation-%E7%AD%86%E8%A8%98-3f2f18a14e8c

https://youtu.be/Z6fjTZAtziQ

https://medium.com/@fgriasa123/unity-ml-agents-%E7%AC%AC%E4%B8%80%E7%AB%A0-%E5%BB%BA%E6%A7%8B%E7%92%B0%E5%A2%83-ee27391cf4b0

https://learn.unity.com/course/ml-agents-hummingbirds

https://thomassimonini.medium.com/an-introduction-to-unity-ml-agents-with-hugging-face-efbac62c8c80

Example environment \
https://www.gocoder.one/blog/introduction-to-unity-ml-agents/#whats-unity-ml-agents \
https://www.gocoder.one/blog/build-a-reinforcement-learning-environment-using-unity-mlagents/ \
https://www.gocoder.one/blog/designing-reinforcement-learning-agents-using-unity-ml-agents/ \
https://www.gocoder.one/blog/training-agents-using-ppo-with-unity-ml-agents/ \
https://www.gocoder.one/blog/competitive-self-play-unity-ml-agents/ 



AI LEARNS TENNIS \
https://youtu.be/HcWbggArjXo

在Unity環境中訓練強化學習AI \
https://www.youtube.com/watch?v=aOb0GSfA1pw&t=52s \
https://youtu.be/61j0q81hoIw \
https://www.youtube.com/watch?v=RjWpb7BazdA \
https://www.youtube.com/watch?v=UIaywmBsCFM \
https://www.youtube.com/watch?v=bsEYAlrD3mA \
https://www.youtube.com/watch?v=RbouZ_KgaUc \
https://www.youtube.com/watch?v=xsvpvHn4WU8

