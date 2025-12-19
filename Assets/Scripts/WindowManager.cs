using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WindowManager : MonoBehaviour
{
    public GameObject ImageWindow1;
    public GameObject ImageWindow2;
    public GameObject ImageWindow3;
    public GameObject ImageWindow4;
    public GameObject ImageWindow5;
    public GameObject ImageWindow6;
    public GameObject ImageWindowOpen;
    public GameObject ImageWindowOpen2;
    public GameObject ImageWindowMiddle;
    public GameObject ImageWindowMiddle2;
    public GameObject ButtonWindowOpen;
    public GameObject ButtonWindowOpen2;

    public Sprite WindowRedPicture;
    public Sprite WindowBluePicture;
    public Sprite WindowPurplePicture;
    public Sprite WindowGreenPicture;
    public Sprite WindowYellowPicture;

    public Sprite WindowRRedPicture;
    public Sprite WindowRBluePicture;
    public Sprite WindowRGreenPicture;
    public Sprite WindowRYellowPicture;

    public Sprite WindowRRRedPicture;
    public Sprite WindowRRBluePicture;
    public Sprite WindowRRGreenPicture;
    public Sprite WindowRRYellowPicture;

    public Sprite WindowLLRedPicture;
    public Sprite WindowLLBluePicture;
    public Sprite WindowLLGreenPicture;
    public Sprite WindowLLYellowPicture;

    public bool RightColor;

    public AudioClip CorrectSound;
    public GameObject Sound;

    AudioSource audioSource;

    private int Window1_count = 0;
    private int Window2_count = 0;
    private int Window3_count = 0;
    private int Window4_count = 0;
    private int Window5_count = 0;
    private int Window6_count = 0;
    private bool WindowOpen1;
    private bool WindowOpen2;
    private bool SoundRight = false;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = Sound.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Window1_count == 2 && Window6_count == 1 && WindowOpen1 && WindowOpen2)
        {
            RightColor = true;
            SoundOne();
        }
        else
        {
            RightColor = false;
            SoundRight = false;
        }
    }

    public void SoundOne()
    {
        if (RightColor && !SoundRight)
        {
            audioSource.PlayOneShot(CorrectSound);
            SoundRight = true;
        }
    }

    public void PushButtonWindowOpen()
    {
        ImageWindowOpen.SetActive(true);
        ButtonWindowOpen.SetActive(false);
        if ((Window2_count == 0 && Window3_count == 1) ||(Window2_count == 1 && Window3_count == 0))
        {
            ImageWindowMiddle.GetComponent<Image>().sprite = WindowPurplePicture;
        }
        else if ((Window2_count == 0 && Window3_count == 3) || (Window2_count == 3 && Window3_count == 0))
        {
            ImageWindowMiddle.GetComponent<Image>().sprite = WindowGreenPicture;
            WindowOpen1 = true;
        }

    }

    public void PushButtonWindowOpen2()
    {
        ImageWindowOpen2.SetActive(true);
        ButtonWindowOpen2.SetActive(false);
        if ((Window4_count == 0 && Window5_count == 1) || (Window4_count == 1 && Window5_count == 0))
        {
            ImageWindowMiddle2.GetComponent<Image>().sprite = WindowPurplePicture;
            WindowOpen2 = true;
        }
        else if ((Window4_count == 0 && Window5_count == 3) || (Window4_count == 3 && Window5_count == 0))
        {
            ImageWindowMiddle2.GetComponent<Image>().sprite = WindowGreenPicture;
        }

    }

    public void PushButtonWindowClose()
    {
        ButtonWindowOpen.SetActive(true);
        ImageWindowOpen.SetActive(false);
        ImageWindowMiddle.GetComponent<Image>().sprite = WindowBluePicture;
        WindowOpen1 = false;
    }

    public void PushButtonWindowClose2()
    {
        ButtonWindowOpen2.SetActive(true);
        ImageWindowOpen2.SetActive(false);
        ImageWindowMiddle2.GetComponent<Image>().sprite = WindowBluePicture;
        WindowOpen2 = false;
    }

    public void PushButtonWindow1()
    {
        Window1_count++;
        if (Window1_count == 1)
        {
            ImageWindow1.GetComponent<Image>().sprite = WindowLLRedPicture;
        }
        else if (Window1_count == 2)
        {
            ImageWindow1.GetComponent<Image>().sprite = WindowLLGreenPicture;
        }
        else if (Window1_count == 3)
        {
            ImageWindow1.GetComponent<Image>().sprite = WindowLLYellowPicture;
        }
        else if (Window1_count == 4)
        {
            ImageWindow1.GetComponent<Image>().sprite = WindowLLBluePicture;
            Window1_count = 0;
        }
    }

    public void PushButtonWindow2()
    {
        Window2_count++;
        if (Window2_count == 1)
        {
            ImageWindow2.GetComponent<Image>().sprite = WindowRRedPicture;
        }
        else if (Window2_count == 2)
        {
            ImageWindow2.GetComponent<Image>().sprite = WindowRGreenPicture;
        }
        else if (Window2_count == 3)
        {
            ImageWindow2.GetComponent<Image>().sprite = WindowRYellowPicture;
        }
        else if (Window2_count == 4)
        {
            ImageWindow2.GetComponent<Image>().sprite = WindowRBluePicture;
            Window2_count = 0;
        }
    }

    public void PushButtonWindow3()
    {
        Window3_count++;
        if(Window3_count == 1)
        {
            ImageWindow3.GetComponent<Image>().sprite = WindowRedPicture;
        }
        else if (Window3_count == 2)
        {
            ImageWindow3.GetComponent<Image>().sprite = WindowGreenPicture;
        }
        else if (Window3_count == 3)
        {
            ImageWindow3.GetComponent<Image>().sprite = WindowYellowPicture;
        }
        else if (Window3_count == 4)
        {
            ImageWindow3.GetComponent<Image>().sprite = WindowBluePicture;
            Window3_count = 0;
        }
    }

    public void PushButtonWindow4()
    {
        Window4_count++;
        if (Window4_count == 1)
        {
            ImageWindow4.GetComponent<Image>().sprite = WindowRRedPicture;
        }
        else if (Window4_count == 2)
        {
            ImageWindow4.GetComponent<Image>().sprite = WindowRGreenPicture;
        }
        else if (Window4_count == 3)
        {
            ImageWindow4.GetComponent<Image>().sprite = WindowRYellowPicture;
        }
        else if (Window4_count == 4)
        {
            ImageWindow4.GetComponent<Image>().sprite = WindowRBluePicture;
            Window4_count = 0;
        }
    }

    public void PushButtonWindow5()
    {
        Window5_count++;
        if (Window5_count == 1)
        {
            ImageWindow5.GetComponent<Image>().sprite = WindowRedPicture;
        }
        else if (Window5_count == 2)
        {
            ImageWindow5.GetComponent<Image>().sprite = WindowGreenPicture;
        }
        else if (Window5_count == 3)
        {
            ImageWindow5.GetComponent<Image>().sprite = WindowYellowPicture;
        }
        else if (Window5_count == 4)
        {
            ImageWindow5.GetComponent<Image>().sprite = WindowBluePicture;
            Window5_count = 0;
        }
    }

    public void PushButtonWindow6()
    {
        Window6_count++;
        if (Window6_count == 1)
        {
            ImageWindow6.GetComponent<Image>().sprite = WindowRRRedPicture;
        }
        else if (Window6_count == 2)
        {
            ImageWindow6.GetComponent<Image>().sprite = WindowRRGreenPicture;
        }
        else if (Window6_count == 3)
        {
            ImageWindow6.GetComponent<Image>().sprite = WindowRRYellowPicture;
        }
        else if (Window6_count == 4)
        {
            ImageWindow6.GetComponent<Image>().sprite = WindowRRBluePicture;
            Window6_count = 0;
        }
    }

    public void ResetWindows()
    {
        ImageWindow1.GetComponent<Image>().sprite = WindowLLBluePicture;
        Window1_count = 0;
        ImageWindow2.GetComponent<Image>().sprite = WindowRBluePicture;
        Window2_count = 0;
        ImageWindow3.GetComponent<Image>().sprite = WindowBluePicture;
        Window3_count = 0;
        ImageWindow4.GetComponent<Image>().sprite = WindowRBluePicture;
        Window4_count = 0;
        ImageWindow5.GetComponent<Image>().sprite = WindowBluePicture;
        Window5_count = 0;
        ImageWindow6.GetComponent<Image>().sprite = WindowRRBluePicture;
        Window6_count = 0;
    }
}
