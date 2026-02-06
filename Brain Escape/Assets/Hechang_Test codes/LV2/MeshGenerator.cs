using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeshGenerator : MonoBehaviour
{
    Vector3[] vertices;
    int[] triangles;

    Mesh mesh;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<MeshFilter>().mesh = mesh;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
