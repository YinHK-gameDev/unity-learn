### project structure
When you create a Unity project, Unity creates a folder (named after your project) which contains the following subfolders:

- Temp
- Library
- Assets
- ProjectSettings
- Logs
- Packages

### workflow
#### Import
Importing is the process of bringing your source files into the Unity Editor to work with. When you save or copy a file into your project’s Assets folder, Unity imports that file which allows you to work with it in the Editor.

It’s important to learn some fundamentals of importing assets into Unity, such as where the files are stored in your Project, how to adjust the Import Settings for each kind of asset, what the meta files are for, and how the Asset Database stores imported data. See Importing Assets for more detail about these topics.

You can speed up Unity’s processing of assets when working with teams by using Unity Accelerator.

#### Create
Once you have imported some assets into your project, you can start creating your game or app. This typically involves placing assets into one or more Scenes
 as GameObjects
, and adding scripts
 which control how the user interacts with them.

As development on your project grows, you might need to split your assets up into separate groups which allows your game to incrementally download selected extra content at runtime.

During the creation process, you can decide a strategy on how to group your assets into separate bundles, and implement the code for choosing when to load them.

Grouping your assets into bundles allows you reduce the size of your initial download and load some assets later at runtime. This can help you optimize the download size and memory usage of your game or app. The recommended way to do this is to use Unity’s Addressables system.

#### Build
Building refers to the process of exporting your completed project to binary files which you can then distribute and run on the platform of your choice. For example, when building for Windows, Unity generates an .EXE file, along with some accompanying data files which you can then distribute.

If you’re using Addressables or Asset Bundles to group your assets into separate downloadable bundles you also need to build those bundle files for distribution.

You can build your project on your own computer, or you can use Unity’s Cloud Build service which provides automated build generation and continuous integration for your Unity projects.

#### Distribute
Once you have built your game or app and its content bundles, your users need a way to access it. Your choice of distribution method depends on the platforms that you’re targeting.

For example, mobile platforms have their own app stores, you could use a professional publisher, or you could self-host on your own servers.

Unity offers its own Cloud Content Delivery service, allowing you to host and deliver your game or app and its content to your users, and is fully integrated into the Unity development platform. This can save lots of time and is valuable for content-rich, live games or applications that require content updates on a regular basis.

#### Load
When users load and use your game or app, the loading process and experience is defined by the rules and programming that you set up, and the way that you grouped and bundled your assets.

Using a combination of the techniques and services described here, you can provide fast initial downloads, and ongoing updates and extra content which you can roll out over the lifetime of your project.




### ref
https://docs.unity3d.com/Manual/UsingTheEditor.html
