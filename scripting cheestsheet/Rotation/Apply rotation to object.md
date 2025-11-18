## Apply rotation to object
This script apply rotation as 0,0,0 to object without modified in external tool

```cs
using UnityEditor;
using UnityEngine;

public class ApplyRotation : MonoBehaviour
{
    [MenuItem("Tools/Transform/Apply Rotation to Mesh")]
    static void ApplyRotationToMesh()
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

        // Duplicate the mesh
        Mesh mesh = Instantiate(mf.sharedMesh);

        // Cache rotation
        Quaternion rotation = obj.transform.localRotation;
        Quaternion inverseRotation = Quaternion.Inverse(rotation);

        Vector3[] vertices = mesh.vertices;
        Vector3[] normals = mesh.normals;

        // Rotate vertices and normals
        for (int i = 0; i < vertices.Length; i++)
        {
            vertices[i] = rotation * vertices[i];
        }

        for (int i = 0; i < normals.Length; i++)
        {
            normals[i] = rotation * normals[i];
        }

        mesh.vertices = vertices;
        mesh.normals = normals;

        mesh.RecalculateBounds();
        mesh.RecalculateTangents();

        // Assign the baked mesh
        mf.sharedMesh = mesh;

        // Reset object rotation
        obj.transform.localRotation = Quaternion.identity;

        Debug.Log("Applied rotation to mesh and reset transform rotation.");
    }
}

```
