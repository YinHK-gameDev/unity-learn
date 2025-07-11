### Merging mesh by script(combine multiple objects)

```cs
using UnityEditor;
using UnityEngine;


// This script is for merging multiple meshes into one(combine multiple objects)
public class MeshCombiner : MonoBehaviour
{
    [MenuItem("Tools/Mesh/Combine Selected Meshes")]
    static void CombineMeshes()
    {
        GameObject[] selectedObjects = Selection.gameObjects;

        if (selectedObjects.Length < 2)
        {
            Debug.LogWarning("Select at least 2 objects with MeshFilters.");
            return;
        }

        CombineInstance[] combine = new CombineInstance[selectedObjects.Length];
        int i = 0;

        foreach (GameObject obj in selectedObjects)
        {
            MeshFilter mf = obj.GetComponent<MeshFilter>();
            if (mf == null) continue;

            combine[i].mesh = mf.sharedMesh;
            combine[i].transform = mf.transform.localToWorldMatrix;
            i++;
        }

        Mesh combinedMesh = new Mesh();
        combinedMesh.CombineMeshes(combine);

        GameObject merged = new GameObject("MergedMesh");
        MeshFilter filter = merged.AddComponent<MeshFilter>();
        MeshRenderer renderer = merged.AddComponent<MeshRenderer>();

        filter.sharedMesh = combinedMesh;
        renderer.sharedMaterial = selectedObjects[0].GetComponent<MeshRenderer>().sharedMaterial;

        Debug.Log("Mesh combined.");
    }
}


```
