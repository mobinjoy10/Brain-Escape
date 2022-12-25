using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinuteDial : MonoBehaviour
{
    Rigidbody rb;
    float r;

    [SerializeField] float hourAngle;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        r = rb.rotation.eulerAngles.x;
    }

    public void OneMinutePassed()
    {
        Debug.Log("There you go");
        r += 6;
        rb.MoveRotation(Quaternion.Euler(r, rb.rotation.y, rb.rotation.z));
    }
}
