using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LV1LightManager : MonoBehaviour
{
    [SerializeField] GameObject HomeLight;
    [SerializeField] GameObject MoonLight;
    [SerializeField] GameObject MoonLightReflection;

    [SerializeField] Homelight homelight;

    // Start is called before the first frame update
    void Start()
    {
        HomeLight.SetActive(true);
        MoonLight.SetActive(false);
        MoonLightReflection.SetActive(false);
    }

    public void HomelightHit()
    {
        MoonLightReflection.SetActive(true);
        MoonLight.SetActive(true);

        HomelightBlast();
    }

    void HomelightBlast()
    {
        homelight.InitiateBlast();
    }

    private void Update()
    {
        if(Input.GetKey(KeyCode.W)){
            HomelightHit();
        }
    }

}
