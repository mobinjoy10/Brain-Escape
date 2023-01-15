using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdAnimController : MonoBehaviour
{
    [SerializeField] Animator animator;
    [SerializeField] AudioSource chirp;
    [SerializeField] AudioSource bell;
    int hourCount;


    public void BeginBirdChirp(int count)
    {
        hourCount = count;
        PlayBirdAnim();
    }

    public void PlayBirdAnim()
    {
        if(hourCount == 0)
        {
            return;
        }

        hourCount--;
        animator.SetTrigger("Play");
        chirp.Play();
        bell.Play();
    }
}
