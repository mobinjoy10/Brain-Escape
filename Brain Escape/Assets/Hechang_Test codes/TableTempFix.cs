using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TableTempFix : MonoBehaviour
{
    public GameObject knob;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("turnThisOn", 0.5f);
    }

    void turnThisOn()
    {
        knob.SetActive(true);
    }
}
