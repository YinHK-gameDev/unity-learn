## Package 
A **package** contains features to **fit the various needs of your project**. This can include any core Unity features included during the Editor installation, or other packages that you can install as needed.

### Unity’s Package Manager
A **package** is a **container** that stores **various types of features or assets**, such as:

- **Editor tools** and **libraries**, such as a **text editor**, an **animation viewer**, or **test frameworks**.
- **Runtime tools** and **libraries**, such as the **Physics API** or a **Graphics pipeline**.
- **Asset collections**, such as **Textures** or **animations**.
- **Project templates** to share common project types with others.

Packages deliver a **wide range of enhancements** to Unity through the **Package Manager**. To help find and use these packages, the Package Manager window **provides collections of package**s that you can use together, called **feature sets**.

The Package Manager also supports management of packages you download or import from the **Unity Asset Store**.

In the Editor, you can access the **Package Manager window** through this menu: **Window > Package Manager**.


https://docs.unity3d.com/Manual/Packages.html

> Unity provides **3** Package Manager interfaces:   **Package Manager window**, **Scripting API**, and **manifest files**.

#### For Package Manager window:
Find packages and manage them in your project, and resolve conflicts in package dependencies. The Package Manager provides a **user interface** that makes changes to the **Project manifest** directly.

Use the Unity Package Manager (in Unity’s top menu: **Window > Package Manager**) to view which packages and feature sets are available for installation or already installed in your project. In addition, you can use this window to see which versions are available, and install, remove, disable, or update packages and feature sets for each project.
 
https://docs.unity3d.com/Manual/upm-ui.html


#### Scripting API for packages:
Use the **Scripting API** to **interact with the Package Manager** using **C#** scripts.

For example, you might want to install a specific package or version depending on the platform of the target machine.

The system relies heavily on the **`PackageManager.Client` class**, which you can use to **find packages**, **browse the list of packages**, and **install and uninstall packages** through scripting.

Another important class is **`PackageManager.PackageInfo`**, which contains the **state of a package,** including **metadata obtained from the package manifest and the registry**.

For example, you can get a list of versions available for the package, or the list of any errors that might occur while locating or installing the package.

https://docs.unity3d.com/Manual/upm-api.html


#### For Project manifest
When Unity loads a project, the Unity Package Manager reads the project manifest so that it can compute a list of which packages to retrieve and load. When a user installs or uninstalls a package through the Package Manager window, the Package Manager stores those changes in the project manifest file. The project manifest file manages the list of packages through the dependencies object.

In addition, the project manifest serves as a configuration file for the Package Manager, which uses the manifest to customize the registry URL and register custom registries.

You can find the **project manifest** file, called **`manifest.json`**, in the Packages folder under the **root folder of your Unity project**. Like the **package manifest** file, the project manifest file uses JSON syntax.

https://docs.unity3d.com/Manual/upm-manifestPrj.html


### Finding packages and feature sets
https://docs.unity3d.com/Manual/upm-ui-find.html

### Released packages
**"Released"** packages are packages that have undergone testing with a specific version of Unity, and all other packages released for that version. The package also contains complete and accurate documentation, an updated changelog, and valid licensing.

https://docs.unity3d.com/Manual/pack-safe.html

### Pre-release packages
https://docs.unity3d.com/Manual/pack-preview.html


### Core packages
**Core packages** are similar to other Unity packages, except that they are bound to the Editor version and they never appear on the Unity package registry. This means that you cannot find them in the Unity Registry list context. And unlike regular Unity packages, their version number is typically 1.0.0, because core package versioning is fixed to the Editor version.

https://docs.unity3d.com/Manual/pack-core.html


### Built-in packages
Built-in packages allow users to toggle Unity features on or off through the Package Manager. Enabling or disabling a package reduces the run-time build size. 

https://docs.unity3d.com/Manual/pack-build.html


### Creating custom packages
The Unity Package Manager is the official package management system for Unity. It does the following:

- Allows Unity to **distribute new features and update existing features** quickly and easily.
- Provides a platform for users to **discover and share reusable components**.
- Promotes Unity as an **extendable and open platform**.


https://docs.unity3d.com/Manual/CustomPackages.html


