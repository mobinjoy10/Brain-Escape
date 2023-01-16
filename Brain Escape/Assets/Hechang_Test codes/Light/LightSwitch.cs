using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSwitch : MonoBehaviour
{
    public Light attachedLight;

    bool isOn;
    Animator animator;
    [SerializeField] float lightIntensity;

    private void Start()
    {
        if(attachedLight.intensity > 0)
        {
            isOn = true;
            lightIntensity = attachedLight.intensity;
        }

        animator = GetComponent<Animator>();
    }

    public void UseSwitch()
    {
        isOn = !isOn;
        if (isOn)
        {
            attachedLight.intensity = lightIntensity;
            animator.SetBool("On", true);
        }
        else
        {
            attachedLight.intensity = 0;
            animator.SetBool("On", false);
        }
    }
}
