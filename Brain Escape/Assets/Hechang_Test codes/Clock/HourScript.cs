using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HourScript : MonoBehaviour
{
    Rigidbody rb;
    int r;
    [SerializeField] int startingRotation;
    public BirdAnimController birdController;


    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        //r = (int)rb.rotation.eulerAngles.x;
        r = startingRotation;
    }

    public void OneHourPassed()
    {
        Debug.Log(r);

        r += 30;

        Debug.Log(r);

        rb.MoveRotation(Quaternion.Euler(r, rb.rotation.y, rb.rotation.z));


        if (r > 360)
        {
            r -= 360;
        }

        int numberOfBells = r / 30;
        birdController.BeginBirdChirp(numberOfBells);
        Debug.Log(numberOfBells);

    }
}
