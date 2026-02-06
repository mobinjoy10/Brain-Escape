using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectorManager : MonoBehaviour
{
    [SerializeField] GameObject projectorLight;
    [SerializeField] GameObject extraLight;

    [SerializeField] MeshRenderer screen;
    [SerializeField] Material staticScreen;
    [SerializeField] Material effectScreen;


    public bool isOn = false;
    private void Start()
    {
        ProjectorOff();
    }
    public void ProjectorOn()
    {
        extraLight.SetActive(true);
        projectorLight.SetActive(true);

        screen.material = effectScreen;

        isOn = true;
    }

    public void ProjectorOff()
    {
        extraLight.SetActive(false);
        projectorLight.SetActive(false);

        screen.material = staticScreen;

        isOn = false;
    }


    public void TempCode()
    {
        if (isOn)
        {
            ProjectorOff();
        }
        else
        {
            ProjectorOn();
        }
    }
}
