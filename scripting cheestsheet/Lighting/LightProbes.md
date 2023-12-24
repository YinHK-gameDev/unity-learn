### Placing Light Probes using scripting
Placing Light Probes over large levels by hand can be time consuming. You can automate the placing of light probes by writing your own editor scripts.

Your script can create a new GameObject with a **LightProbeGroup** component, and you can add **probe positions** individually according to any rules that you choose to program.   

Using **`LightProbeGroup`** API:

```cs
using UnityEngine;

public class PlaceLightProbes : MonoBehaviour
{
    public int rows = 5;
    public int cols = 5;
    public float spacing = 2f;
 
    [ContextMenu("Place Light Probes")]
    void PlaceProbes()
    {
        LightProbeGroup probeGroup = gameObject.GetComponent<LightProbeGroup>();
        if (probeGroup == null)
        {
            probeGroup = gameObject.AddComponent<LightProbeGroup>();
        }
 
        Vector3 center = transform.position;
        Vector3[] probePositions = new Vector3[rows * cols];
 
        for (int x = 0; x < rows; x++)
        {
            for (int z = 0; z < cols; z++)
            {
                Vector3 pos = center + new Vector3(x * spacing, 0f, z * spacing);
                probePositions[x * cols + z] = pos;
            }
        }
 
        probeGroup.probePositions = probePositions;
        Debug.Log("Light Probes placed.");
    }
}

```


### ref
https://docs.unity3d.com/ScriptReference/LightProbeGroup.html















