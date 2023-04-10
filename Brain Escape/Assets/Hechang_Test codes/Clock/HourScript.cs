using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HourScript : MonoBehaviour
{
    Rigidbody rb;
    int r;
    [SerializeField] int startingRotation;
    public BirdAnimController birdController;

    public PlayableManager manager;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        //r = (int)rb.rotation.eulerAngles.x;
        r = startingRotation;
    }

    public void OneHourPassed()
    {
        r += 30;

        rb.MoveRotation(Quaternion.Euler(r, rb.rotation.y, rb.rotation.z));

        if (manager)
        {
            manager.StartPlaying();
        }

        if (r > 360)
        {
            r -= 360;
        }

        int numberOfBells = r / 30;
        birdController.BeginBirdChirp(numberOfBells);
        Debug.Log(numberOfBells);

    }
}
