using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Homelight : MonoBehaviour
{
    [SerializeField] Animator animator;

    [SerializeField] string KnifeTag;
    [SerializeField] LV1LightManager lightManager;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void InitiateBlast()
    {
        animator.SetTrigger("Blast");
    }

    void DisableLight()
    {
        Levelstate.instance.UpdateLevelState(Levelstate.LevelStates.LightDestroy);
        gameObject.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag(KnifeTag))
        {

            lightManager.HomelightHit();
        }
    }
}
