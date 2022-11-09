using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawerUnlocked : MonoBehaviour
{
    //bool isLocked = true;
    [SerializeField] GameObject grabObj;

    public void Unlocked()
    {
        //isLocked = false;
        grabObj.SetActive(true);
    }
}
