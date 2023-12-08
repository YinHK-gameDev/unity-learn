## UGS (Unity Gaming Service)

### What is Unity Gaming Services?
**Unity Gaming Services** is an end-to-end platform that is designed to help you build, engage, and grow your game. This documentation provides general information on features used across the Unity Gaming Services portfolio.


### Overview of services
https://unity.com/solutions/gaming-services?_ga=2.140249203.1981099051.1684656689-1095169982.1671075740&_gac=1.158324168.1683270739.Cj0KCQjw0tKiBhC6ARIsAAOXutkMqCjyUq1S_EkJYEBAljjPBEQxdd-7ahm-iKxYKydX-uSILhguIeYaAr41EALw_wcB

https://docs.unity.com/ugs-overview/en/manual/overview-of-services


### Unity Gaming Services (UGS) CLI
The Unity Gaming Services (UGS) CLI is a unified command line interface tool for gaming services.

#### Install the CLI
To install the CLI with npm, make sure you have node and npm installed, then run:

```
  npm install -g ugs
```

This installs the CLI as an npm package and adds **`ugs`** to your PATH.

After installation, you should be able to call **`ugs --version`** and other commands directly from your command line.

https://services.docs.unity.com/guides/ugs-cli/latest/general/overview/


### Services Core SDK API
The **Services Core package** provides a solution for initializing all Unity Gaming Services with a single call, and defines common components used by multiple packages.

You need to initialize all Unity Gaming Services that are currently installed in your project.

The following example initializes all services at once, using the [Environments](https://docs.unity.com/ugs-overview/en/manual/ServiceEnvironments) initialization extension:

```cs
using System;
using Unity.Services.Core;
using Unity.Services.Core.Environments;
using UnityEngine;
 
public class InitializeUGS : MonoBehaviour {
    
    public string environment = "production";
 
    async void Start() {
        try {
            var options = new InitializationOptions()
                .SetEnvironmentName(environment);
 
            await UnityServices.InitializeAsync(options);
        }
        catch (Exception exception) {
            // An error occurred during initialization.
        }
    }
}
```

### Unity Gaming Services REST APIs

Unity's Web APIs allow you to use Unity Services to build and manage your projects with your preferred language and engine.

A great option if you are not using the Unity Engine or if you prefer more flexibility.

https://services.docs.unity.com/?_ga=2.211027029.1981099051.1684656689-1095169982.1671075740&_gac=1.228159087.1685054585.CjwKCAjw67ajBhAVEiwA2g_jELfgZqYdQzSUK9i0UiLijiFjhJpzmkfKZ_t0NlWiWxhNMwrAGLMG4RoC62YQAvD_BwE


### Unity Gaming Services Use Cases
https://docs.unity.com/ugs-use-cases/en/manual/Welcome


### UGS product and price
https://unity.com/solutions/gaming-services/pricing

### ref 
https://docs.unity.com/ugs-overview/en/manual/unity-gaming-services-home

https://docs.unity3d.com/2021.3/Documentation/Manual/UnityServices.html
