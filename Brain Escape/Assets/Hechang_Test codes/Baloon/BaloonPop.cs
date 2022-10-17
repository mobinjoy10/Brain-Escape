using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaloonPop : MonoBehaviour
{

    Animator baloonAnim;

    [SerializeField] string triggerName;

    [SerializeField] Transform KeyObject;

    [SerializeField] string KnifeTag;

    // Start is called before the first frame update
    void Start()
    {
        baloonAnim = GetComponent<Animator>();
    }

    //This code will be called by Bullet Object to reduce update calls.
    //This code manages the burst animation of the Baloon.
    void baloonBurstAnim()
    {
        baloonAnim.SetTrigger(triggerName);
    }

    //This code will be called from the animator
    //This code destroys/disables the baloon and spawns a key.
    void baloonDestroy()
    {

        //Spawn the key giving an illusion of the key coming out of the baloon after it pops
        if(KeyObject)
            Instantiate(KeyObject, transform.position, Quaternion.identity);

        gameObject.SetActive(false);
    }


    //The following code checks for any collision with Knife tagged object and initiates Burst animation method
    private void OnTriggerEnter(Collider other)
    {

        
        if (other.CompareTag(KnifeTag))
        {
            Debug.Log("Putush");
            baloonBurstAnim();
        }
    }
}
