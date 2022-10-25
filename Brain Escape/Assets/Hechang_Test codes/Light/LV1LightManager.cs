using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LV1LightManager : MonoBehaviour
{
    [SerializeField] GameObject HomeLight;
    [SerializeField] GameObject MoonLight;
    [SerializeField] GameObject MoonLightReflection;

    // Start is called before the first frame update
    void Start()
    {
        HomeLight.SetActive(true);
        MoonLight.SetActive(false);
        MoonLightReflection.SetActive(false);
    }

    void HomelightHit()
    {
        MoonLightReflection.SetActive(true);
        MoonLight.SetActive(true);

        HomelightBlast();
    }

    void HomelightBlast()
    {
        HomeLight.SetActive(false); 
    }

    private void Update()
    {
        if(Input.GetKey(KeyCode.W)){
            HomelightHit();
        }
    }

}
