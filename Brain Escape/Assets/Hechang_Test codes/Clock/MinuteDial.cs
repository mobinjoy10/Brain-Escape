using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinuteDial : MonoBehaviour
{
    Rigidbody rb;
    int r;
    public HourScript hourScript;

    public Rigidbody hourRB;
    public Transform hour;
    [SerializeField] int startingRotation;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        r = startingRotation;
    }

    public void OneMinutePassed()
    {
        r += 6;

        rb.MoveRotation(Quaternion.Euler(r, rb.rotation.y, rb.rotation.z));


        if (r > 359)
        {
            r -= 360;
            hourScript.OneHourPassed();
        }
    }
}
