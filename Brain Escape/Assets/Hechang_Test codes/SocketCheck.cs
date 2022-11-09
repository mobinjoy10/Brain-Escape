using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SocketCheck : MonoBehaviour
{
    [SerializeField] int requiredCode;

    [SerializeField] DoorSocManager doorSoc;
    [SerializeField] string numberTag;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(numberTag))
        {
            if(requiredCode == other.GetComponent<NumberEmission>().CodeNumber)
            {
                doorSoc.ManageDoorLock();
            }
        }
    }
}
