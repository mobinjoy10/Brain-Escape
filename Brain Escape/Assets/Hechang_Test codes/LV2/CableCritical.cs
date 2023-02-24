using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class CableCritical : MonoBehaviour
{
    public XRGrabInteractable interactable;
    public Transform target;
    public float maxDist;

    private void FixedUpdate()
    {
        if(Vector3.Distance(transform.position, target.position) >= maxDist){
            interactable.enabled = false;
            Invoke("ReEnable", 0.5f);
        }
    }

    void ReEnable()
    {
        interactable.enabled = true;
    }
}
