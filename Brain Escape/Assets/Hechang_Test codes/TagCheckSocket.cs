using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TagCheckSocket : UnityEngine.XR.Interaction.Toolkit.Interactors.XRSocketInteractor
{
    public string targetTag;

    [System.Obsolete]
    public override bool CanHover(UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable interactable)
    {
        return base.CanHover(interactable) && MatchTag(interactable);
    }

    [System.Obsolete]
    public override bool CanSelect(UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable interactable)
    {
        return base.CanSelect(interactable) && MatchTag(interactable);
    }

    private bool MatchTag(UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable interactable)
    {
        return interactable.CompareTag(targetTag);
    }
}
