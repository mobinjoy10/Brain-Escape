using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Levelstate : MonoBehaviour
{
    public static Levelstate Instance;

    public LevelStates state;

    public static event Action<LevelStates> OnLevelStateChanged;

    private void Awake()
    {
        Instance = this;
    }
   
    public enum LevelStates{
        Begin,
        BaloonPop,
        LightDestroy,
        DoorUnlocked,
    }

    void UpdateLevelState(LevelStates newState)
    {
        state = newState;

        switch (newState)
        {
            case LevelStates.Begin:
                break;
            case LevelStates.BaloonPop:
                break;
            case LevelStates.LightDestroy:
                break;
            case LevelStates.DoorUnlocked:
                break;

        }

        OnLevelStateChanged?.Invoke(newState);

    }
}
