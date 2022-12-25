using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rottest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("Check", 1f);
    }

    void Check()
    {
        Debug.Log("RigidBody : " + GetComponent<Rigidbody>().rotation.eulerAngles);
        Debug.Log("Transform : " + transform.rotation.eulerAngles);
    }
}
