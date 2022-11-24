using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorSocManager : MonoBehaviour
{
    [SerializeField] GameObject BaseObj;
    [SerializeField] int numberLeft;

    [SerializeField] DoorManager Door;
    private void Awake()
    {
        Levelstate.OnLevelStateChanged += Levelstate_OnLevelStateChanged;
    }

    private void OnDestroy()
    {
        Levelstate.OnLevelStateChanged -= Levelstate_OnLevelStateChanged;
    }

    private void Levelstate_OnLevelStateChanged(Levelstate.LevelStates state)
    {
        if (state == Levelstate.LevelStates.LightDestroy)
        {
            BaseObj.SetActive(true);
        }
    }

    public void OpenDoorLock()
    {
        numberLeft--;

        if(numberLeft == 0)
        {
            Door.OpenDoor();
        }
    }

    public void CloseDoorLock()
    {
        numberLeft++;
    }
}
