using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class TagCheckSocket : XRSocketInteractor
{
    public string targetTag;

    [System.Obsolete]
    public override bool CanHover(XRBaseInteractable interactable)
    {
        return base.CanHover(interactable) && MatchTag(interactable);
    }

    [System.Obsolete]
    public override bool CanSelect(XRBaseInteractable interactable)
    {
        return base.CanSelect(interactable) && MatchTag(interactable);
    }

    private bool MatchTag(XRBaseInteractable interactable)
    {
        return interactable.CompareTag(targetTag);
    }
}
