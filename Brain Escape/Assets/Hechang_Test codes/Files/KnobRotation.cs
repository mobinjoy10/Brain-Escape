using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class KnobRotation : MonoBehaviour
{
    public int currentNum = 0;
    public int targetNum;
    bool onCurrectPos;

    public ScreenManager manager;

    public bool test;

    public TMP_Text text;
    public Animator anim;


    private void Start()
    {
        if (currentNum == targetNum)
        {
            onCurrectPos = true;
            manager.oneKnobCorrect();
        
        }

        text.text = currentNum.ToString();
    }

    private void Update()
    {
        if (test)
        {
            Rotate();
            test = false;
        }
    }

    public void Rotate()
    {
        anim.Play("KnobRotate");

        currentNum++;
        if(currentNum > 9)
            currentNum = 0;

        text.text = currentNum.ToString();
        if (currentNum == targetNum)
        {
            onCurrectPos = true;
            manager.oneKnobCorrect();
        }
        else
        {
            if (onCurrectPos)
            {
                manager.missedJustNow();
                onCurrectPos = false;
            }
        }
    }
}
