using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondDial : MonoBehaviour
{
    public bool clockIsRunning = true;
    Rigidbody rb;
    float r;

    [SerializeField] MinuteDial minute;
    
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        r = rb.rotation.eulerAngles.x;
        
        RunClock();
    }

    void RunClock()
    {
        if(clockIsRunning)
         StartCoroutine(SecondPasses());
    }

    private IEnumerator SecondPasses()
    {
        for (; ; )
        {
            r += 6;
            rb.MoveRotation(Quaternion.Euler(r, rb.rotation.y, rb.rotation.z));

            if (transform.rotation.eulerAngles.x > -0.5 && transform.rotation.eulerAngles.x < 0.5)
            {
                Debug.Log("Yay");
                minute.OneMinutePassed();
            }

            yield return new WaitForSeconds(1f);
        }
    }
}
