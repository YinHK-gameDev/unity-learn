## Displacement in Unity Shader Graph

To set displacement in Unity Shader Graph, you can manipulate vertices in the mesh using Height Maps or a mathematical function. The approach depends on your rendering pipeline (HDRP or URP):

= In **HDRP**, displacement can modify vertices for **actual geometry displacement** using **tessellation**.
- In **URP**, only simulated displacement (e.g., **parallax mapping**) is available.

### **Displacement in HDRP (with Tessellation)**

**HDRP** supports **true vertex displacement** through tessellation.

#### **Steps:**

1.  **Enable Tessellation in Shader Graph:**
    
    -   Open your Shader Graph.
    -   In the **Graph Inspector**, enable **Tessellation** (available in HDRP).
    -   Set tessellation parameters as needed (e.g., Edge Length, Phong smoothing).
2.  **Add a Height Map Texture:**
    
    -   Add a **Sample Texture 2D Node** and load your **Height Map**.
    -   Use the red channel (`R`) or grayscale output.
3.  **Scale the Height Map:**
    
    -   Use a **Multiply Node** to control the intensity of the height map.
    -   Add a **Float Property** (e.g., "Displacement Strength") and connect it to the Multiply Node for easy adjustment.
4.  **Add a Displacement Node:**
    
    -   Add a **Vertex Displacement Node** or use the **Displacement Node**.
    -   Connect:
        -   The scaled Height Map to the **Displacement Input**.
        -   Mesh UVs to the **Height Map UV Input** if needed.
5.  **Output to Vertex Position:**
    
    -   Connect the **Output** of the Displacement Node to the **Vertex Position** input of the Master Node.

### **Displacement in URP (Simulated)**

**URP** doesn't support true vertex displacement but allows **Parallax Mapping** for simulated depth.

#### **Steps:**

1.  **Add a Parallax Mapping Node:**
    
    -   Add a **Parallax Mapping Node**.
    -   Connect:
        -   Mesh UVs or a **Tiling and Offset Node** to the **UV Input**.
        -   Height Map (grayscale or red channel) to the **Height Input**.
2.  **Set Height Scale:**
    
    -   Add a **Float Property** (e.g., "Height Scale") to control the depth intensity.
    -   Connect it to the Height Scale input of the Parallax Mapping Node.
3.  **Output UVs:**
    
    -   Connect the UV Output of the Parallax Mapping Node to the UV inputs of your textures (e.g., Albedo, Normal Map).
