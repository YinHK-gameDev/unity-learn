## Theme Style Sheet (TSS)

**Theme Style Sheet (TSS)** files are regular USS files. \
UI Toolkit treats TSS as a **distinct asset type** and uses it for **management purposes**.

Regular **USS syntax** and format apply to **TSS** files, but usually, a **theme file contains references to other USS files** through the **`@import rule`**.

> **Note**: USS files also support the **`@import rule`**.

### Create a TSS
You can create different TSS files for **different themes** and **switch between them at runtime**. \
**Typically, you should use USS for styles**. Consider TSS when you customize the **look and feel for different platforms or devices**, or when you use **different fonts** for **different languages** if your games or applications **support multiple languages**.

> **Note**: When you add your first UIDocument to a GameObject in your project, it generates a default runtime theme asset at **`Assets/UI Toolkit/UnityThemes/UnityDefaultTheme.tss`**. Although you can create a TSS from scratch, to get all the default UI controls to work, you **must import the default runtime theme**, and then **overwrite** or **add new styles to create your custom theme**.


To create a new TSS:

1.  Create one or more USS files with your custom styles.
2.  Do one of the following:
    - Select **Assets > Create > UI Toolkit > TSS Theme File** to create an empty theme file and import the default theme.
    - Select **Assets > Create > UI Toolkit > Default Runtime Theme File** to create a copy of the default runtime theme file. You can rename the file if you want.
3.  Import your style USS files to your theme.


### ref 
https://docs.unity3d.com/Manual/UIE-tss.html


