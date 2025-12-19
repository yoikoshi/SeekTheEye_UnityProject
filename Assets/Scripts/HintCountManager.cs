using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HintCountManager : MonoBehaviour
{
    private Text hintcountText;
    // Start is called before the first frame update
    void Start()
    {
        hintcountText = GetComponentInChildren<Text>();
    }

    // Update is called once per frame
    void Update()
    {
         hintcountText.text = TimerManager.getHintCount().ToString("00");
    }

    
}
