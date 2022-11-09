using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Levelstate : MonoBehaviour
{
    public static Levelstate instance;

    public LevelStates state;

    public static event Action<LevelStates> OnLevelStateChanged;

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        UpdateLevelState(LevelStates.Begin);
    }

    public enum LevelStates{
        Begin,
        BaloonPop,
        LightDestroy,
        DoorUnlocked,
    }

    public void UpdateLevelState(LevelStates newState)
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
