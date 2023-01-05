using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberEmission : MonoBehaviour
{
    [SerializeField] Material emissionMat;

    public int CodeNumber;

    MeshRenderer meshRenderer;

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
        if(state == Levelstate.LevelStates.LightDestroy)
        {
            meshRenderer.material = emissionMat;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }

    
}
