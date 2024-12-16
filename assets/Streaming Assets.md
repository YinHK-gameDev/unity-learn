##  Streaming Assets
Unity combines **Scenes** and Assets into binary files inside the generated Player when it builds the Project. However, you can place files into the normal filesystem on the target machine to make them available using a pathname. For example, for deploying a movie file on iOS devices, the original movie file must be available from a location in the filesystem to play using the `PlayMovie` function. This folder can also include `AssetBundles` that you intend to distribute directly in the Player installation, rather than downloading them on-demand.


Unity copies any files placed in the folder called StreamingAssets (case-sensitive) in a Unity Project verbatim to a particular folder on the target machine. 
To retrieve the folder, use the **`Application.streamingAssetsPath`** property. 
It’s always best to use **`Application.streamingAssetsPath`** to get the location of the **StreamingAssets folder**, 
because it always points to the correct location on the platform where the application is running.

The location returned by `Application.streamingAssetsPath` varies per platform:

-   Most platforms (Unity Editor, Windows, Linux players) use `Application.dataPath + "/StreamingAssets"`.
-   macOS player uses `Application.dataPath + "/Resources/Data/StreamingAssets"`.
-   iOS uses `Application.dataPath + "/Raw"`.
-   Android uses files inside a compressed `APK/JAR` file, `"jar:file://" + Application.dataPath + "!/assets"`.
-   On Web, `Application.streamingAssetsPath` returns a HTTP URL that points to the `StreamingAssets/` path on the web server. For example, `http://localhost:8000/unity_webgl_build/StreamingAssets/` is returned when your application is running against a local development server.

### Accessing streaming assets
On **Android** and the **Web platform**, it’s **not possible to access the streaming asset files directly** via **file system APIs** 
and **streamingAssets path** because these platforms **return a URL**. Use the **`UnityWebRequest` class** to **access the content** instead.


> **Notes:** 
> - The **`streamingAssets` path** is **read-only**. **Don’t modify or write new files** to the `streamingAssets` directory at runtime.
> - **`.dll`** and **script files** located in the **StreamingAssets folder** **aren’t included **during script compilation.
> - **Asset Bundles** and **Addressables** are alternative ways of accessing content that’s not part of regular game build data, and preferred over Streaming Assets folder.



### ref

https://docs.unity3d.com/Manual/StreamingAssets.html


