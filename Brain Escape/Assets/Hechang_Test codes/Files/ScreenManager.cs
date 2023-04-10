using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class ScreenManager : MonoBehaviour
{
    public GameObject noise;
    public GameObject mainView;
    public bool doIt = false;

    int numberOfCorrectKnob = 0;

    public PlayableManager playable;

    private void Start()
    {
        mainView.SetActive(false);
        noise.SetActive(true);
    }

    public void oneKnobCorrect()
    {
        numberOfCorrectKnob++;

        if(numberOfCorrectKnob == 3)
        {
            mainView.SetActive(true);
            noise.SetActive(false);

            playable.StartPlaying();
        }
    }

    public void missedJustNow()
    {
        numberOfCorrectKnob--;
    }
        
}
