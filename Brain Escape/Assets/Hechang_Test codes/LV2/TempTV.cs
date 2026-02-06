using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TempTV : MonoBehaviour
{
    public GameObject screen;
    bool isOn = false;

    public void switchTV()
    {
        isOn = !isOn;

        if (isOn)
        {
            screen.SetActive(true);
        }
        else
        {
            screen.SetActive(false);
        }
    }
}
