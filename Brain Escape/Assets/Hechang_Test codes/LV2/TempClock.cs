using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TempClock : MonoBehaviour
{

    public SecondDial second;
    public string penTag;
    bool called = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(penTag))
        {
            if(!called)
                second.RunClock();

            called = true;
        }
    }
}
