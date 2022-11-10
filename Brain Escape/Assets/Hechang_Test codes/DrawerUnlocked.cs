using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawerUnlocked : MonoBehaviour
{
    //bool isLocked = true;
    [SerializeField] GameObject grabObj;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Key"))
        {
            grabObj.SetActive(true);
        }
    }

}
