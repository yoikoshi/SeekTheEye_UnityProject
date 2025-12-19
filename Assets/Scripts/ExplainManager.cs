using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExplainManager : MonoBehaviour
{
    TimerManager scripttimer;
    BoxManager script;
    public GameObject ImageExplain;
    public GameObject TextExplainNum;
    public GameObject ClickBlockEx;
    public GameObject[] TextExplain;
    private bool ExplainOn = true;
    private int ExplainNum = 0;
    // Start is called before the first frame update
    void Start()
    {
        script = GameObject.Find("BoxManager").GetComponent<BoxManager>();
        scripttimer = GameObject.Find("TimerManager").GetComponent<TimerManager>();
    }

    // Update is called once per frame
    void Update()
    {

        if (ExplainOn && ExplainNum == 0)
        {
            ImageExplain.SetActive(true);
            TextExplain[0].SetActive(true);
            TextExplainNum.GetComponent<Text>().text = "1/4";
        }
        else if (ExplainOn && ExplainNum == 1)
        {
            TextExplain[0].SetActive(false);
            TextExplain[1].SetActive(true);
            TextExplainNum.GetComponent<Text>().text = "2/4";
        }
        else if (ExplainOn && ExplainNum == 2)
        {
            TextExplain[1].SetActive(false);
            TextExplain[2].SetActive(true);
            TextExplainNum.GetComponent<Text>().text = "3/4";
        }
        else if (ExplainOn && ExplainNum == 3)
        {
            TextExplain[2].SetActive(false);
            TextExplain[3].SetActive(true);
            TextExplainNum.GetComponent<Text>().text = "4/4";
        }
        else if (ExplainOn && ExplainNum == 4)
        {
            ImageExplain.SetActive(false);
            TextExplain[3].SetActive(false);
            ExplainNum = 0;
            ExplainOn = false;
            ClickBlockEx.SetActive(false);
            scripttimer.TimerStop = false;
        }
    }

    public void PushButtonQ()
    {
        script.select_num = -1;
        ExplainOn = true;
        ClickBlockEx.SetActive(true);
    }

    public void PushClickBlockEx()
    {
        ExplainNum++;
    }
}
