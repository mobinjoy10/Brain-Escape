using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class numbercheck : MonoBehaviour
{
    [SerializeField] string CodeNumber;
    [SerializeField] string socketTag;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(socketTag))
        {

        }
    }
}
