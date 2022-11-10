using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SocketCheck : MonoBehaviour
{
    [SerializeField] int requiredCode;

    [SerializeField] DoorSocManager doorSoc;
    [SerializeField] string numberTag;

    [SerializeField] GameObject placeholderNum;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(numberTag))
        {
            if(requiredCode == other.GetComponentInParent<NumberEmission>().CodeNumber)
            {
                doorSoc.ManageDoorLock();
                other.gameObject.SetActive(false);
                placeholderNum.SetActive(true);
            }
        }
    }
}
