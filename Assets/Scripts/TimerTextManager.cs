using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerTextManager : MonoBehaviour
{
    public Text timerText;
    // Start is called before the first frame update
    void Start()
    {
        timerText = GetComponentInChildren<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        timerText.text = TimerManager.getminute().ToString("00") + ":" + ((int)TimerManager.getseconds()).ToString("00");
    }
}
