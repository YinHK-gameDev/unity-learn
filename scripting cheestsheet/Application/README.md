## Application
Access to **application runtime data**.


### Static Properties

<table class="list"><tbody><tr><td class="lbl"><a href="https://docs.unity3d.com/ScriptReference/Application.htmlApplication-absoluteURL.html">absoluteURL</a></td><td class="desc">The URL of the document. For WebGL, this is a web URL. For Android, iOS, or Universal Windows Platform (UWP) this is a deep link URL (Read Only).</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/ScriptReference/Application.htmlApplication-backgroundLoadingPriority.html">backgroundLoadingPriority</a></td><td class="desc">Priority of background loading thread.</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/ScriptReference/Application.htmlApplication-buildGUID.html">buildGUID</a></td><td class="desc">Returns a GUID for this build (Read Only).</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/ScriptReference/Application.htmlApplication-cloudProjectId.html">cloudProjectId</a></td><td class="desc">A unique cloud project identifier. It is unique for every project (Read Only).</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/ScriptReference/Application.htmlApplication-companyName.html">companyName</a></td><td class="desc">Returns application company name (Read Only).</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/ScriptReference/Application.htmlApplication-consoleLogPath.html">consoleLogPath</a></td><td class="desc">Returns the path to the console log file, or an empty string if the current platform does not support log files.</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/ScriptReference/Application.htmlApplication-dataPath.html">dataPath</a></td><td class="desc">Contains the path to the game data folder on the target device (Read Only).</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/ScriptReference/Application.htmlApplication-exitCancellationToken.html">exitCancellationToken</a></td><td class="desc">Cancellation token raised on exiting Play mode (Editor) or on quitting the application (Read Only).</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/ScriptReference/Application.htmlApplication-genuine.html">genuine</a></td><td class="desc">Returns false if application is altered in any way after it was built.</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/ScriptReference/Application.htmlApplication-genuineCheckAvailable.html">genuineCheckAvailable</a></td><td class="desc">Returns true if application integrity can be confirmed.</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/ScriptReference/Application.htmlApplication-identifier.html">identifier</a></td><td class="desc">Returns the application identifier at runtime.</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/ScriptReference/Application.htmlApplication-installerName.html">installerName</a></td><td class="desc">Returns the name of the store or package that installed the application (Read Only).</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/ScriptReference/Application.htmlApplication-installMode.html">installMode</a></td><td class="desc">Returns application install mode (Read Only).</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/ScriptReference/Application.htmlApplication-internetReachability.html">internetReachability</a></td><td class="desc">Returns the type of internet reachability currently possible on the device.</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/ScriptReference/Application.htmlApplication-isBatchMode.html">isBatchMode</a></td><td class="desc">Returns true when Unity is launched with the -batchmode flag from the command line (Read Only).</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/ScriptReference/Application.htmlApplication-isConsolePlatform.html">isConsolePlatform</a></td><td class="desc">Is the current Runtime platform a known console platform.</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/ScriptReference/Application.htmlApplication-isEditor.html">isEditor</a></td><td class="desc">Whether the game is running inside the Unity Editor (Read Only).</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/ScriptReference/Application.htmlApplication-isFocused.html">isFocused</a></td><td class="desc">Whether the Player currently has focus (Read-only).</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/ScriptReference/Application.htmlApplication-isMobilePlatform.html">isMobilePlatform</a></td><td class="desc">Identifies whether the current Runtime platform is a known mobile platform.</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/ScriptReference/Application.htmlApplication-isPlaying.html">isPlaying</a></td><td class="desc">Returns true when called in any kind of built Player, or when called in the Editor in Play mode (Read Only).</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/ScriptReference/Application.htmlApplication-persistentDataPath.html">persistentDataPath</a></td><td class="desc">Contains the path to a persistent data directory (Read Only).</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/ScriptReference/Application.htmlApplication-platform.html">platform</a></td><td class="desc">Returns the platform the game is running on (Read Only).</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/ScriptReference/Application.htmlApplication-productName.html">productName</a></td><td class="desc">Returns application product name (Read Only).</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/ScriptReference/Application.htmlApplication-runInBackground.html">runInBackground</a></td><td class="desc">Should the Player be running when the application is in the background?</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/ScriptReference/Application.htmlApplication-sandboxType.html">sandboxType</a></td><td class="desc">Returns application running in sandbox (Read Only).</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/ScriptReference/Application.htmlApplication-streamingAssetsPath.html">streamingAssetsPath</a></td><td class="desc">The path to the StreamingAssets folder (Read Only).</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/ScriptReference/Application.htmlApplication-systemLanguage.html">systemLanguage</a></td><td class="desc">The language the user's operating system is running in.</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/ScriptReference/Application.htmlApplication-targetFrameRate.html">targetFrameRate</a></td><td class="desc">Specifies the frame rate at which Unity tries to render your game.</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/ScriptReference/Application.htmlApplication-temporaryCachePath.html">temporaryCachePath</a></td><td class="desc">Contains the path to a temporary data / cache directory (Read Only).</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/ScriptReference/Application.htmlApplication-unityVersion.html">unityVersion</a></td><td class="desc">The version of the Unity runtime used to play the content.</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/ScriptReference/Application.htmlApplication-version.html">version</a></td><td class="desc">Returns application version number (Read Only).</td></tr></tbody></table>

### Static Methods

<table class="list"><tbody><tr><td class="lbl"><a href="https://docs.unity3d.com/ScriptReference/Application.htmlApplication.CanStreamedLevelBeLoaded.html">CanStreamedLevelBeLoaded</a></td><td class="desc">Checks if the streamed level can be loaded.</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/ScriptReference/Application.htmlApplication.GetStackTraceLogType.html">GetStackTraceLogType</a></td><td class="desc">Get stack trace logging options. The default value is StackTraceLogType.ScriptOnly.</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/ScriptReference/Application.htmlApplication.HasProLicense.html">HasProLicense</a></td><td class="desc">Is Unity activated with the Pro license?</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/ScriptReference/Application.htmlApplication.HasUserAuthorization.html">HasUserAuthorization</a></td><td class="desc">Check if the user has authorized use of the webcam or microphone on iOS and WebGL.</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/ScriptReference/Application.htmlApplication.IsPlaying.html">IsPlaying</a></td><td class="desc">Returns true if the given object is part of the playing world either in any kind of built Player or in Play Mode.</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/ScriptReference/Application.htmlApplication.OpenURL.html">OpenURL</a></td><td class="desc">Opens the URL specified, subject to the permissions and limitations of your app’s current platform and environment.</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/ScriptReference/Application.htmlApplication.Quit.html">Quit</a></td><td class="desc">Quits the player application.</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/ScriptReference/Application.htmlApplication.RequestAdvertisingIdentifierAsync.html">RequestAdvertisingIdentifierAsync</a></td><td class="desc">Request advertising ID for iOS and Windows Store.</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/ScriptReference/Application.htmlApplication.RequestUserAuthorization.html">RequestUserAuthorization</a></td><td class="desc">Request authorization to use the webcam or microphone on iOS and WebGL.</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/ScriptReference/Application.htmlApplication.SetStackTraceLogType.html">SetStackTraceLogType</a></td><td class="desc">Set stack trace logging options. The default value is StackTraceLogType.ScriptOnly.</td></tr><tr><td class="lbl"><a href="https://docs.unity3d.com/ScriptReference/Application.htmlApplication.Unload.html">Unload</a></td><td class="desc">Unloads the Unity Player.</td></tr></tbody></table>

| Events | Descriptions |
| --- | --- |
| `deepLinkActivated` | This event is raised when an application running on Android, iOS, or the Universal Windows Platform (UWP) is activated using a deep link URL. |
| `focusChanged` | Defines the delegate to use to register for events in which the focus gained or lost. |
| `logMessageReceived` | Event that is fired if a log message is received. |
| `logMessageReceivedThreaded` | Event that is fired if a log message is received. |
| `lowMemory` | This event occurs when your app receives a low-memory notification from the device it is running on. |
| `memoryUsageChanged` | Informs about significant changes in the application's memory usage. |
| `onBeforeRender` | Delegate method used to register for "Just Before Render" input updates for VR devices. |
| `quitting` | Unity raises this event when the Player application is quitting. |
| `unloading` | Unity raises this event when Player is unloading. |
| `wantsToQuit` | Unity raises this event when the player application wants to quit. |

| Delegates | Descriptions |
| --- | --- |
| `AdvertisingIdentifierCallback` | Delegate method for fetching advertising ID. |
| `LogCallback` | Use this delegate type with Application.logMessageReceived or Application.logMessageReceivedThreaded to monitor what gets logged. |
| `LowMemoryCallback` | This is the delegate function when a mobile device notifies of low memory. |
| `MemoryUsageChangedCallback` | A delegate for the Application.memoryUsageChanged vent. |




#### `Application.Quit`
Quits the application, quit the game. 

Shut down the running application. 

> However, the `Application.Quit` call is **ignored in the Unity Editor**. Only work at real device

**Android and iOS platforms have their own dedicated interfaces to hide and close applications**, which might be the preferred way to close applications for some users. Therefore, it's not recommended to create your own way of shutting down with Application.Quit to prevent inconsistent user experience between your application and these platform interfaces.

If you must programmatically quit an Android application, you can instead move the application to the background via Activity.moveTaskToBack. For more information, refer to Quit a Unity Android application.

For iOS platform, in most cases the termination of application should be left at the user's discretion. Calling Application.Quit method in iOS Player might appear to the user that the application has crashed. For more information, refer to Apple Technical Page qa1561.

```cs
 public static void Quit();
```

#### `Application.persistentDataPath`
Contains the path to a persistent data directory (Read Only). Path for the saving game data.

This value is a directory path (notice the difference in slash directions on different operating systems according to `Path.DirectorySeparatorChar)`, where you **can store data** that you want to be **kept between runs**. When you publish on **iOS** and **Android**, `persistentDataPath` points to a **public directory on the device**. Files in this location are **not erased by app updates**. The files **can still be erased by users directly**.

When you build the Unity application, a GUID is generated that is based on the Bundle Identifier. This GUID is part of persistentDataPath. If you keep the same Bundle Identifier in future versions, the application keeps accessing the same location on every update.


eg:
```cs
using UnityEngine;

public class Info : MonoBehaviour
{
    void Start()
    {
        Debug.Log(Application.persistentDataPath);
    }
}
```

```cs
using UnityEngine;
using System.IO;
using System.Text;

void FileExample(string serizliedData)
{
   var raws = Encoding.UTF8.GetBytes(serizliedData);
   FileExample(raws);
}

void FileExample(byte[] serizliedData)
{
   const string fileName = "gamesave.dat";
   var filePath = Application.persistentDataPath + "/" + fileName;

   // Save
   try
   {
      File.WriteAllBytes(filePath, serizliedData);
   }
   catch (System.Exception e)
   {
      // TODO: Handle exception
   }

   // Load
   try
   {
      serizliedData = File.ReadAllBytes(filePath);
   }
   catch (System.Exception e)
   {
      // TODO: Handle exception
   }
}
```

- **Windows Store Apps**: `Application.persistentDataPath` points to `C:\Users\<user>\AppData\LocalLow\<company name>`
- **WebGL**: `Application.persistentDataPath` points to `/idbfs/<md5 hash of data path>` where the data path is the URL stripped of everything including and after the last '/' before any '?' components.
- **Linux**: `Application.persistentDataPath` points to `$XDG_CONFIG_HOME/unity3d` or `$HOME/.config/unity3d`.
- **iOS**: `Application.persistentDataPath` points to **/var/mobile/Containers/Data/Application/<guid>/Documents**.
- **tvOS**: `Application.persistentDataPath` is not supported and returns an empty string.
- **Android**: Application.persistentDataPath points to `/storage/emulated/<userid>/Android/data/<packagename>/files` on most devices (some older phones might point to location on SD card if present), the path is resolved using `android.content.Context.getExternalFilesDir`.
- **Mac**: `Application.persistentDataPath` points to the user Library folder. (This folder is often hidden.) In recent Unity releases user data is written into `~/Library/Application Support/company name/product name`. Older versions of Unity wrote into the `~/Library/Caches folder`, or `~/Library/Application Support/unity.company name.product name`. 


### ref
https://docs.unity3d.com/ScriptReference/Application.html


