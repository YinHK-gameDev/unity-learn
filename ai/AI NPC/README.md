## AI NPCs


#### NPC AI Behavior 

Behavior Designer: https://opsive.com/assets/behavior-designer/

### **🟡 1. Behavior Designer (Third-Party Asset)**

🛠 **Tool:** Behavior Designer (by Opsive)  
🎯 **Best for:** Creating **decision-making AI** (like NPCs in FPS, RPG, Strategy games)  
📌 **Core Feature:** **Behavior Trees** (BT)

#### **🔹 Key Features:**

✅ Uses a **Behavior Tree** (BT) system to control NPC logic.  
✅ **Drag-and-drop nodes** for tasks like "Patrol," "Attack," or "Flee."  
✅ Supports **State Machines (FSM)** and **Utility AI**.  
✅ Advanced **AI decision-making** (like enemy AI in a shooter).  
✅ Works well with **NavMesh & animation systems**.  
✅ **Best for complex AI behavior** (e.g., enemy AI, boss fights, dynamic NPCs).

#### **🔸 Example Use Case:**

🚀 Enemy AI in an FPS game that:

-   **Patrols an area**
-   **Detects the player**
-   **Decides to attack, hide, or run away**
-   **Searches for cover when taking damage**

**👀 Example Behavior Tree (BT) Flow:**  
👀 **See Player?** → **Yes? Attack!** → **No? Keep Patrolling.**

📌 **Similar to:** Unreal Engine's Behavior Trees.


### **🟢 2. Behavior Graph (Unity Visual Scripting)**

🛠 **Tool:** **Unity's Behavior Graph (Experimental)**  
🎯 **Best for:** Simple **state-based AI & animation logic**  
📌 **Core Feature:** **Graph-based visual scripting**

#### **🔹 Key Features:**

✅ **Built into Unity** (Experimental in newer versions).  
✅ **More like a State Machine (FSM)** instead of Behavior Trees.  
✅ Good for **basic AI & animation transitions**.  
✅ Similar to **Animator Graph** but for AI.  
✅ **Easier for beginners** but **less powerful than Behavior Designer**.

#### **🔸 Example Use Case:**

**A simple NPC AI** that switches between:

-   **Idle → Walk → Run → Attack** based on player distance.
-   **Fewer decision-making options than Behavior Designer.**

📌 **Similar to:** Unity's Animator Controller or PlayMaker.



### **⚡Which One Should You Use?**

| Feature | **Behavior Designer** 🟡 | **Behavior Graph** 🟢 |
| --- | --- | --- |
| **Approach** | **Behavior Tree (BT)** | **State Machine (FSM-like)** |
| **Best For** | **Complex AI decisions** (e.g., FPS enemies, boss fights, stealth AI) | **Simple AI state changes** (e.g., NPC movement, basic AI) |
| **Use Case** | AI with **advanced decision-making** (Attack, Hide, Flee) | AI with **simple state transitions** (Idle → Walk → Run) |
| **Customization** | More powerful (supports Utility AI, FSM, & BT) | More limited (FSM-like state changes) |
| **Complexity** | **More advanced, requires some learning** | **Easier, good for beginners** |
| **Performance** | **Efficient for complex AI** | **Lightweight for simple AI** |


### **🔥 Which One Should You Pick?**

✔ **If you need** **smart AI decision-making (e.g., FPS enemies, boss fights, stealth AI)** → **Use Behavior Designer.**  
✔ **If you need** **basic AI state transitions (e.g., NPC Idle → Walk → Attack)** → **Use Behavior Graph.**

**💡 Need help choosing for your game? Let me know your AI goal! 🚀**



### ref
**Inworld** \
https://inworld.ai/engine \
https://www.youtube.com/@inworldai/videos \
https://www.youtube.com/watch?v=KeFAbIjd0GQ


