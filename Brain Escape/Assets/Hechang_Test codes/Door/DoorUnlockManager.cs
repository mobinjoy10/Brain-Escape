using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class DoorUnlockManager : MonoBehaviour
{
    public XRSimpleInteractable simpleInteractable;

    public XRGrabInteractable grabInteractable;

    public bool isLocked;

    public AudioSource source;

    private void Start()
    {
        if (isLocked)
        {
            simpleInteractable.enabled = true;
            grabInteractable.enabled = false;
        }
        else
        {
            simpleInteractable.enabled = false;
            grabInteractable.enabled = true;
        }

    }

    public void OpenDoor()
    {
        simpleInteractable.enabled = false;
        grabInteractable.enabled = true;

        if(source != null)
        {
            source.Play();
        }
    }

    public void CloseDoor()
    {
        simpleInteractable.enabled = true;
        grabInteractable.enabled = false;

        if (source != null)
        {
            source.Play();
        }

    }
}
