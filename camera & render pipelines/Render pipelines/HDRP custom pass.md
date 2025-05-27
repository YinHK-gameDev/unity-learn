# HDRP: Custom Fullscreen Pass vs Custom Render Pass

This document explains the key differences between **Custom Fullscreen Passes** and **Custom Render Passes** in Unity’s **High Definition Render Pipeline (HDRP)**. Both are powerful tools used to inject custom rendering logic, but they serve different purposes and integrate into different stages of the HDRP pipeline.

---

## 🔶 Custom Fullscreen Pass

### 📌 Purpose
Used to apply **fullscreen image effects** as post-processing, such as screen overlays, blur, or color grading.

### ✅ Key Features

| Feature             | Description |
|---------------------|-------------|
| 🎯 Use Case         | Post-processing effects like blur, glow, outlines, color correction. |
| 📺 Scope            | Operates on the **entire screen**. |
| 🛠 Integration Point| Injected into the HDRP pipeline after rendering (e.g. AfterOpaque, AfterPostProcess). |
| 🧰 Implementation   | Use a **fullscreen quad** shader with custom logic. |
| 🔍 Shader           | Typically uses `CustomPostProcessVolumeComponent` or Fullscreen Shader Graph. |
| 🎨 Buffer Access    | Can read/write to **camera color, depth, and normal buffers**. |

---

## 🔷 Custom Render Pass

### 📌 Purpose
Used to **draw or manipulate geometry**, create masks, perform stencil operations, or render objects with special effects.

### ✅ Key Features

| Feature             | Description |
|---------------------|-------------|
| 🎯 Use Case         | Drawing glowing objects, world-space outlines, depth or mask effects. |
| 📺 Scope            | Can be used on **specific GameObjects**, layers, or custom geometry. |
| 🛠 Integration Point| Works within a `CustomPassVolume` and runs at user-defined stages. |
| 🧰 Implementation   | Create a script that inherits from `CustomPass` and override `Execute()`. |
| 🔍 Shader           | Can use any Shader Graph, Lit, or custom HLSL shader. |
| 🧱 Render Targets   | Access to color/depth/stencil buffers; can write to them. |

---

## 📊 Feature Comparison

| Feature                        | Custom Fullscreen Pass       | Custom Render Pass            |
|-------------------------------|------------------------------|-------------------------------|
| Type                          | Post-process (image-space)   | Render injection (geometry)   |
| Operates On                   | Whole screen                 | Specific objects/layers       |
| Timing                        | After rendering              | Any stage in render pipeline  |
| Geometry Rendering            | No                           | Yes                           |
| Shader Type                   | Fullscreen/Blit shader       | Surface shader, Shader Graph  |
| Main Use                      | Screen effects               | World effects, geometry masks |
| Buffer Access                 | Yes                          | Yes                           |

---

## ✅ Use Case Recommendations

| Scenario                                   | Recommended Pass       |
|-------------------------------------------|-------------------------|
| Add bloom or blur to whole screen         | Custom Fullscreen Pass |
| Render a glowing checkpoint in 3D space   | Custom Render Pass     |
| Apply outlines to selected objects        | Custom Render Pass     |
| Overlay a UI distortion effect            | Custom Fullscreen Pass |
| Highlight geometry with a mask            | Custom Render Pass     |

---

## 📘 References

- Unity Documentation: [Custom Pass in HDRP](https://docs.unity3d.com/Packages/com.unity.render-pipelines.high-definition@latest)
- Unity Manual: [Post-processing in HDRP](https://docs.unity3d.com/Packages/com.unity.render-pipelines.high-definition@latest/manual/Post-Processing.html)

---

**Author:** Yin  
**Date:** 2025-05-19  
**Pipeline:** Unity HDRP  
