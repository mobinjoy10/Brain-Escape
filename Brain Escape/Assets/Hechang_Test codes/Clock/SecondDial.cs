using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondDial : MonoBehaviour
{
    public bool clockIsRunning = true;
    Rigidbody rb;
    int r;

    [SerializeField] AudioSource clickSound;

    [SerializeField] int startingRotation;

    [SerializeField] MinuteDial minute;
    
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        //r = (int)rb.rotation.eulerAngles.x;
        r = startingRotation;
        if (clockIsRunning)
        {
            RunClock();
        }
    }

    public void RunClock()
    {
            clickSound.Play();
            StartCoroutine(SecondPasses());
    }

    private IEnumerator SecondPasses()
    {
        for (; ; )
        {
            r += 6;
            rb.MoveRotation(Quaternion.Euler(r, rb.rotation.y, rb.rotation.z));

            if(r > 359)
            {
                r -= 360;

                minute.OneMinutePassed();
            }

            yield return new WaitForSeconds(1f);
        }
    }
}
