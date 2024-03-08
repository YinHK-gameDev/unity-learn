// Ray class



//Constructor
public Ray(Vector3 origin, Vector3 direction);

//eg:
using UnityEngine;

public class ExampleClass : MonoBehaviour
{
    void Start()
    {
        // Create a ray from the transform position along the transform's z-axis
        Ray ray = new Ray(transform.position, transform.forward);
    }
}

//Properties

//The direction of the ray.
//Direction is always a normalized vector. If you assign a vector of non unit length, it will be normalized.
public Vector3 direction;

//The origin point of the ray.
public Vector3 origin;


//Methods

//Returns a point at distance units along the ray.
public Vector3 GetPoint(float distance);
