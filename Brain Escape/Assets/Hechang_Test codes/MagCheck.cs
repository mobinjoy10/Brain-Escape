using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagCheck : MonoBehaviour
{
    [SerializeField] string magTag;
    [SerializeField] SimpleShoot shootScript;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(magTag))
        {
            shootScript.MagAttached();
        }
    }

}
