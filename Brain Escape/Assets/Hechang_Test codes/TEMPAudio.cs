using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TEMPAudio : MonoBehaviour
{
    public AudioSource audioSource;
    public float waitTime;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("PlayAudio", waitTime);
    }

    void PlayAudio()
    {
        audioSource.Play();
    }
}
