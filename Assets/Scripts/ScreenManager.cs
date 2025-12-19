using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScreenManager : MonoBehaviour
{
    public Sprite FullScreenPicture;
    public Sprite WindowScreenPicture;
    public GameObject ButtonScreen;

    private bool FullScreen = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClickFullScreenMode()
    {
        if (!FullScreen)
        {
            ButtonScreen.GetComponent<Image>().sprite = WindowScreenPicture;
            Screen.fullScreen = true;
            FullScreen = true;
        }
        else
        {
            ButtonScreen.GetComponent<Image>().sprite = FullScreenPicture;
            Screen.fullScreen = false;
            FullScreen = false;
        }
        
    }

    public void A()
    {
        Debug.Log("Pushed");
    }
}
