using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RankManager : MonoBehaviour
{
    private int RankNum;
    private Text RankText;
    // Start is called before the first frame update
    void Start()
    {
        RankText = GetComponentInChildren<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        RankNum = (TimerManager.getHintCount() * 2 + TimerManager.getminute());
        if (TextCatLastManager.ExEnd == 1)
        {
            RankText.color = new Color(1.0f, 0.7f, 0.1f, 1.0f);
            RankText.text = "EX";
        }
        else if (RankNum < 20)
        {
            RankText.color = new Color(1.0f, 1.0f, 0.0f, 1.0f);
            RankText.text = "S";
        }
        else if (RankNum < 40)
        {
            RankText.color = new Color(0.9f, 0.5f, 0.55f, 1.0f);
            RankText.text = "A";
        }
        else if (RankNum < 60)
        {
            RankText.color = new Color(0.5f, 0.77f, 0.9f, 1.0f);
            RankText.text = "B";
        }
        else if (60 < RankNum)
        {
            RankText.text = "C";
        }
    }
}
