## MLAgent’s Environment Executable
MLAgent allows you to create an executable file and use that file to create multiple instances of application environments that will work in the same way as creating the duplicates of the environment prefab in the same scenes.

You can create and use built environments rather than the Editor to interact with an environment.

Using an executable file has some advantages over using the Editor for training:
- You can use Server Build (Headless) mode for faster training (as long as the executable does not need rendering).
- You can keep using the Unity Editor for other tasks while the agents are training. \
  Freedom to use editor while training. \
  The feature uses an executable file generated from unity to be used as a source for ML-Agent training, meaning you will have an editor available during the whole training process and you can continue your work while the agent is being trained in the background application.
- Sharing is easy
  You will no longer need to share your entire repository for training and instead just need to share executable files with your colleagues. You can exchange executable with other people without having to share your entire repository.
- Remote Training
  You can put your executable file on a remote machine for faster training.


### Training for your executable file
After you build your executable unity project. You can start training by your executable file through **local terminal window or remote machine**.

#### For local terminal
Run:
```
mlagents-learn <trainer-config-file> --env=<env_name> --run-id=<run-identifier>
```
-   `<trainer-config-file>` is the file path of the trainer configuration yaml
-   `<env_name>` is the name and path to the executable you exported from Unity (without extension). It is the name and path to the executable file you exported from unity
-   `<run-identifier>` is a string used to separate the results of different training runs


#### Start training running on Jupyter Notebook
https://jupyter-notebook-beginner-guide.readthedocs.io/en/latest/execute.html


#### Running on Google colab
https://dhyeythumar.medium.com/training-ml-agents-with-google-colab-cb166c3dca46 

https://colab.research.google.com/drive/1tz04VDRmCNPDrqa2ehtR1Kk9mOmUsFbA?hl=en







### ref 
https://werplay.medium.com/unitys-ml-agents-and-effective-ways-of-training-3-3-e8e519af5ab7

https://github.com/Unity-Technologies/ml-agents/blob/develop/docs/Learning-Environment-Executable.md

