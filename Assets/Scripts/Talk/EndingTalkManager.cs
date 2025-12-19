using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EndingTalkManager : MonoBehaviour
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
    public GameObject ImageBack;
    public GameObject ButtonForTitle;
    public GameObject Buttonoff;

    public bool Click;
    public bool SetTraL;
    public bool SetTraR;
    public GameObject ImageTraL;
    public GameObject ImageTraR;

    public GameObject Really;
    public GameObject ButtonBlock;
    public GameObject ButtonSkip;

    public GameObject TextClearTime;
    public GameObject TextTime;
    public GameObject TextHint;
    public GameObject TextHintCount;
    public GameObject TextRank;
    public GameObject TextRankLetter;
    public GameObject ImageNeko;
    public GameObject SoundSlider;

    public AudioClip ItemGetSound;
    public AudioClip ShogiSound;
    public AudioClip ShakinSound;
    public GameObject Sound;

    public int TalkNum = 0;
    CharaMove2Manager script;
    CharaMoveManager script2;

    AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = Sound.GetComponent<AudioSource>();
        script = GameObject.Find("CharaMove2Manager").GetComponent<CharaMove2Manager>();
        script2 = GameObject.Find("CharaMoveManager").GetComponent<CharaMoveManager>();
        audioSource.volume = ChangeSoundVolume.getSoundValue();
    }

    // Update is called once per frame
    void Update()
    {
        switch (TalkNum)
        {
            case 0:
                if (TextCatLastManager.getExEnd() == 1)
                {
                    TextTalkR[6].SetActive(true);
                }
                else
                {
                    TextTalkR[0].SetActive(true);
                }                   
                SetR();
                break;
            case 1:
                ResetR();
                if (TextCatLastManager.getExEnd() == 1)
                {
                    TextTalkL[7].SetActive(true);
                }
                else
                {
                    TextTalkL[0].SetActive(true);
                }
                SetL();
                script.MoveOn = true;
                break;
            case 2:
                ResetL();
                if (TextCatLastManager.getExEnd() == 1)
                {
                    TextTalkR[7].SetActive(true);
                }
                else
                {
                    TextTalkR[1].SetActive(true);
                }
                SetR();
                break;
            case 3:
                ResetR();
                TextTalkL[1].SetActive(true);
                SetL();
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
                ImageTalkR.SetActive(true);
                ImageTalkRBack.SetActive(true);
                ImageShujinkouSup.SetActive(true);
                ImageShujinkou.SetActive(false);
                ImageShujinkouShadow.SetActive(false);
                break;
            case 11:
                SetTraL = true;
                ImageTalkR.SetActive(false);
                ImageTalkRBack.SetActive(false);
                TextTalkL[5].SetActive(true);
                script2.MoveBack = true;
                SetL();
                break;
            case 12:
                SetTraL = false;
                SetTraR = false;
                ButtonSkip.SetActive(false);
                ImageTalkL.SetActive(false);
                ImageTalkLBack.SetActive(false);
                StartCoroutine(DelayCoroutine());
                TalkNum++;
                ImageTraL.SetActive(false);
                break;
            default:
                SetTraL = false;
                SetTraR = false;
                break;
        }
    }

    private IEnumerator DelayCoroutine()
    {
        yield return new WaitForSeconds(1);
        
        TextClearTime.SetActive(true);
        audioSource.PlayOneShot(ShogiSound);

        yield return new WaitForSeconds(1);
        audioSource.PlayOneShot(ShogiSound);
        TextTime.SetActive(true);

        yield return new WaitForSeconds(1);
        audioSource.PlayOneShot(ShogiSound);
        TextHint.SetActive(true);

        yield return new WaitForSeconds(1);
        audioSource.PlayOneShot(ShogiSound);
        TextHintCount.SetActive(true);

        yield return new WaitForSeconds(1);
        audioSource.PlayOneShot(ShogiSound);
        TextRank.SetActive(true);

        yield return new WaitForSeconds(1);
        audioSource.PlayOneShot(ShakinSound);
        TextRankLetter.SetActive(true);
        if (TextCatLastManager.getExEnd() == 1)
        {
            ImageNeko.SetActive(true);
        }

        yield return new WaitForSeconds(1);
        TextTalkL[6].SetActive(true);      

        yield return new WaitForSeconds(1);
        ButtonForTitle.SetActive(true);
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

    public void PushButtonForTitle()
    {
        FadeManager.Instance.LoadScene("TitleScene", 2.0f);
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

    public void PushButtonSkip()
    {
        audioSource.PlayOneShot(ItemGetSound);
        Really.SetActive(true);
        ButtonBlock.SetActive(true);
    }

    public void PushButtonSkipYes()
    {
        script.MoveOn = true;
        for (int i = 0; i < 8; i++)
        {
            TextTalkL[i].SetActive(false);
            TextTalkR[i].SetActive(false);
        }
        ImageChie.SetActive(true);
        ImageChieShadow.SetActive(false);
        ImageTraR.SetActive(false);
        ImageTalkR.SetActive(false);
        ImageTalkRBack.SetActive(false);
        ImageShujinkou.SetActive(false);
        ImageShujinkouShadow.SetActive(false);
        Really.SetActive(false);
        ButtonBlock.SetActive(false);
        ButtonSkip.SetActive(false);
        TalkNum = 12;
    }

    public void PushButtonSkipNo()
    {
        Really.SetActive(false);
        ButtonBlock.SetActive(false);
    }
}
