using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ThemometerManager : MonoBehaviour
{
    private bool CountFlag;
    private float BarX;
    public GameObject RedBar;
    public GameObject ButtonThermometer;
    public GameObject ButtonDriverGrip;
    public GameObject ImageMeterOpen;

    public AudioClip PSound;
    public AudioClip CorrectSound;
    public GameObject Sound;

    public string text;
    public int Meter_Count = 5;

    RectTransform rt;
    AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = Sound.GetComponent<AudioSource>();
        rt = RedBar.GetComponent<RectTransform>();
    }

    // Update is called once per frame
    void Update()
    { 
        if (CountFlag)
        {
            

            BarX += (0.5f + Time.deltaTime);

            rt.sizeDelta = new Vector2(4.0f, BarX);

            if (BarX >= 45 && Meter_Count > 0)
            {
                if (Meter_Count > 1)
                {
                    audioSource.PlayOneShot(PSound);
                }
                else if(Meter_Count == 1)
                {
                    audioSource.PlayOneShot(CorrectSound);
                }
                
                BarX = 0.0f;
                Meter_Count--;
            }
        }
        else
        {
            if(BarX >= 0)
            {
                BarX -= 0.2f;
                rt.sizeDelta = new Vector2(4.0f, BarX);
            }
        }

        if (Meter_Count == 0)
        {
            ButtonThermometer.SetActive(false);
            ButtonDriverGrip.SetActive(true);
            ImageMeterOpen.SetActive(true);
            Meter_Count = -1;
        }

        text = Meter_Count.ToString();

    }

    public void OnButtonDown()
    {
        
        CountFlag = true;
    }

    public void OnButtonUp()
    {
       
        CountFlag = false;
    }
}
