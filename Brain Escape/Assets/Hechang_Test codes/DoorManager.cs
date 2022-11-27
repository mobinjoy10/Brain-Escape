using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorManager : MonoBehaviour
{
    [SerializeField] Animator animator;
    [SerializeField] GameObject OutDoorLight;

    public void OpenDoor()
    {
        animator.SetTrigger("Open");
        OutDoorLight.SetActive(true);

    }
}
