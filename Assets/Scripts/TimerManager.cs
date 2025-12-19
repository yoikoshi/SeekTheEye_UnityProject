using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerManager : MonoBehaviour
{
    public static int minute;
    public static float seconds;

    public static int HintCount = 0;

    public bool TimerStop = true;


    // Start is called before the first frame update
    void Start()
    {
        minute = 0;
        seconds = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (!TimerStop)
        {
            seconds += Time.deltaTime;
            if (seconds >= 60f)
            {
                minute++;
                seconds = seconds - 60;
            }
        }

    }

    public void PushButtonTimer()
    {
        TimerStop = false;
    }


    public void PushButtonForTitle()
    {
        HintCount = 0;
        minute = 0;
        seconds = 0f;
        TextCatLastManager.ExEnd = 0;
    }

    public static int getHintCount()
    {
        return HintCount;
    }

    public static float getseconds()
    {
        return seconds;
    }

    public static int getminute()
    {
        return minute;
    }
}
