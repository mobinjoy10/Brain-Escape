using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class NumberEmission : MonoBehaviour
{
    [SerializeField] Material emissionMat;

    MeshRenderer meshRenderer;

    public int CodeNumber;

    [SerializeField] GameObject grabObj;


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
            grabObj.SetActive(true);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        
    }


    public void DisableGrab()
    {
        grabObj.SetActive(false);
    }

}
