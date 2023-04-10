using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class PlayableManager : MonoBehaviour
{
    public PlayableDirector director;

    public void StartPlaying()
    {
        director.Play();
    }
}
