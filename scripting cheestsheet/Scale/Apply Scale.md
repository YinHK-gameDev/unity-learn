### Apply Scale to object 

This script apply scale of 1 to object without modified in external tool

```cs
using UnityEditor;
using UnityEngine;

public class ApplyScale : MonoBehaviour
{
    [MenuItem("Tools/Transform/Apply Scale to Mesh")]
    static void ApplyScaleToMesh()
    {
        GameObject obj = Selection.activeGameObject;
        if (obj == null)
        {
            Debug.LogWarning("No GameObject selected.");
            return;
        }

        MeshFilter mf = obj.GetComponent<MeshFilter>();
        if (mf == null || mf.sharedMesh == null)
        {
            Debug.LogWarning("Selected object has no mesh.");
            return;
        }

        Mesh mesh = Instantiate(mf.sharedMesh);
        Vector3[] vertices = mesh.vertices;

        Vector3 scale = obj.transform.localScale;
        for (int i = 0; i < vertices.Length; i++)
        {
            vertices[i] = Vector3.Scale(vertices[i], scale);
        }

        mesh.vertices = vertices;
        mesh.RecalculateBounds();
        mesh.RecalculateNormals();
        mf.sharedMesh = mesh;

        // Reset the transform scale to 1
        obj.transform.localScale = Vector3.one;

        Debug.Log("Applied scale to mesh and reset transform scale.");
    }
}

```

