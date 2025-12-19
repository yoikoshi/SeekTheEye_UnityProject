using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TalkManager : MonoBehaviour
{
    public GameObject[] TextTalkR;
    public GameObject[] TextTalkL;
    public GameObject ImageChie;
    public GameObject ImageChieShadow;
    public GameObject ImageShujinkou;
    public GameObject ImageShujinkouSup;
    public GameObject ImageShujinkouShadow;
    public GameObject ImageTalkR;
    public GameObject ImageTalkL;
    public GameObject ImageTalkLBack;
    public GameObject ImageTalkRBack;
    public GameObject TextNameL;

    public GameObject Buttonoff;
    public GameObject SoundSlider;
    public bool Click;
    public bool SetTraL;
    public bool SetTraR;

    public GameObject Really;
    public GameObject ButtonBlock;

    public Sprite MiyaSupPicture;
    public Sprite MiyaNormalPicture;

    public int TalkNum = 0;
    CharaMove2Manager script;

    public AudioClip ItemGetSound;
    public GameObject Sound;
    AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = Sound.GetComponent<AudioSource>();
        script = GameObject.Find("CharaMove2Manager").GetComponent<CharaMove2Manager>();
        audioSource.volume = ChangeSoundVolume.getSoundValue();
    }

    // Update is called once per frame
    void Update()
    {
        switch (TalkNum)
        {
            case 0:
                TextTalkR[0].SetActive(true);
                SetR();
                break;
            case 1:
                ResetR();
                TextTalkL[0].SetActive(true);
                SetL();
                script.MoveOn = true;
                break;
            case 2:
                ResetL();
                TextTalkR[1].SetActive(true);
                SetR();
                break;
            case 3:
                ResetR();
                TextTalkL[1].SetActive(true);
                SetL();
                TextNameL.GetComponent<Text>().text = "CHIE";
                break;
            case 4:
                ResetL();
                TextTalkR[2].SetActive(true);
                SetR();
                break;
            case 5:
                
                ResetR();
                TextTalkL[2].SetActive(true);
                SetL();
                SetTraR = false;
                break;
            case 6:
                ResetL();
                TextTalkR[3].SetActive(true);
                SetR();
                break;
            case 7:
                ResetR();
                TextTalkL[3].SetActive(true);
                SetL();
                break;
            case 8:
                ResetL();
                TextTalkR[4].SetActive(true);
                SetR();
                break;
            case 9:
                ResetR();
                TextTalkL[4].SetActive(true);
                SetL();
                break;
            case 10:
                ResetL();
                SetTraR = true;
                TextTalkR[5].SetActive(true);
                ImageShujinkouShadow.SetActive(false);
                ImageShujinkouSup.SetActive(true);
                ImageTalkR.SetActive(true);
                ImageTalkRBack.SetActive(true);
                break;
            case 11:
                ResetR();
                ImageShujinkouSup.SetActive(false);
                TextTalkL[5].SetActive(true);
                ImageShujinkouShadow.GetComponent<Image>().sprite = MiyaSupPicture;
                SetL();
                break;
            case 12:
                ResetL();
                SetTraR = true;
                TextTalkR[6].SetActive(true);
                ImageShujinkouSup.SetActive(true);
                ImageShujinkouShadow.SetActive(false);
                ImageTalkR.SetActive(true);
                ImageTalkRBack.SetActive(true);
                break;
            default:
                SetTraL = false;
                SetTraR = false;
                ImageTalkR.SetActive(false);
                ImageTalkRBack.SetActive(false);
                // SceneManager.LoadScene("GameScene");
                break;
        }
    }

    public void ResetR()
    {
        SetTraR = false;
        ImageTalkR.SetActive(false);
        ImageTalkRBack.SetActive(false);
        ImageShujinkou.SetActive(false);
        ImageShujinkouShadow.SetActive(true);
    }

    public void SetR()
    {
        SetTraR = true;
        ImageTalkR.SetActive(true);
        ImageTalkRBack.SetActive(true);
        ImageShujinkou.SetActive(true);
        ImageShujinkouShadow.SetActive(false);
    }

    public void ResetL()
    {
        SetTraL = false;
        ImageChieShadow.SetActive(true);
        ImageTalkL.SetActive(false);
        ImageTalkLBack.SetActive(false);
        ImageChie.SetActive(false);
    }

    public void SetL()
    {
        SetTraL = true;
        ImageChieShadow.SetActive(false);
        ImageTalkL.SetActive(true);
        ImageChie.SetActive(true);
        ImageTalkLBack.SetActive(true);
    }

    public void PushButtonSpeak()
    {
        SoundSlider.SetActive(true);
        Buttonoff.SetActive(true);
    }

    public void PushButtonOff()
    {
        SoundSlider.SetActive(false);
        Buttonoff.SetActive(false);
    }

    public void PushButtonClick()
    {
        Click = true;
    }

    public void PushButtonClickFade()
    {
        if (TalkNum > 11)
        {
            FadeManager.Instance.LoadScene("GameScene", 2.0f);
        }     
    }

    public void PushButtonSkip()
    {
        audioSource.PlayOneShot(ItemGetSound);
        Really.SetActive(true);
        ButtonBlock.SetActive(true);
    }

    public void PushButtonSkipYes()
    {
        Really.SetActive(false);
        FadeManager.Instance.LoadScene("GameScene", 2.0f);
    }

    public void PushButtonSkipNo()
    {
        Really.SetActive(false);
        ButtonBlock.SetActive(false);
    }
}
