using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorSocManager : MonoBehaviour
{
    [SerializeField] GameObject BaseObj;

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
}
