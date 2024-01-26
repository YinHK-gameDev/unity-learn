## Create user interfaces (UI)
Unity provides **3 UI systems** that you can use to create user interfaces (UI) for the Unity Editor and applications made in the Unity Editor:

- UI Toolkit
- Unity UI package (**uGUI**)
- IMGUI

> **Note**: Unity intends for UI Toolkit to become the recommended UI system for new UI development projects, but it is still missing some features found in Unity UI (uGUI) and IMGUI. These older systems are better in certain use cases, and are required to support legacy projects. Your choice of UI system for a given project depends on the kind of UI you plan to develop, and the features you need support for.


| **2022** | **Recommendation** |**Alternative** |
| --- | --- | --- |
| **Runtime** | Unity UI | UI Toolkit |
| **Editor** | UI Toolkit | IMGUI |



### Comparison of UI systems in Unity
https://docs.unity3d.com/Manual/UI-system-compare.html


| Roles | UI Toolkit | Unity UI(uGUI) | IMGUI | Skill sets |
| --- | --- | --- | --- | --- |
| Programmer | Yes | Yes | Yes | Programmers can use any game development tool or API. |
| Technical Artist | Partial | Yes | No | Technical artists who are familiar with Unity’s GameObject-based tools and workflows are likely to be comfortable working with GameObjects, Components, and the Scene view.They might not be comfortable with UI Toolkit’s web-like approach or IMGUI’s pure C# approach. |
| UI Designer | Yes | Partial | No | UI designers who are familiar with UI creation tools are likely to be comfortable with UI Toolkit’s document-based approach and can use the https://docs.unity3d.com/Manual/UIBuilder.html to visually edit their UI.If they are not familiar with GameObject-based workflows, they might require help from programmers or level designers. |

### Type of UI

- Non-Diegetic UI
- Diegetic UI
- Spatial UI
- Meta UI


https://www.gameres.com/890547.html

### ref 
https://www.youtube.com/watch?v=8w0qvO4Vumc

**`UnityEngine.UI` scripting API** \
https://docs.unity3d.com/Packages/com.unity.ugui@2.0/api/UnityEngine.UI.html

**`UnityEditor.UI` scripting API** \
https://docs.unity3d.com/Packages/com.unity.ugui@2.0/api/UnityEditor.UI.html

**`UnityEngine.UIElements` scripting API** \
https://docs.unity3d.com/Packages/com.unity.ui@1.0/api/UnityEngine.UIElements.html

**`UnityEditor.UIElements` scripting API** \
https://docs.unity3d.com/Packages/com.unity.ui@1.0/api/UnityEditor.UIElements.html



