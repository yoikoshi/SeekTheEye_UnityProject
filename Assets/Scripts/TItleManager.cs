using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TItleManager : MonoBehaviour
{
    AudioSource audioSource;
    public AudioClip ButtonSound;
    public GameObject Sound;
    public GameObject SlliderSound;
    public GameObject ButtonOff;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = Sound.GetComponent<AudioSource>();
        audioSource.volume = ChangeSoundVolume.getSoundValue();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PushStartButton ()
    {
        audioSource.PlayOneShot(ButtonSound);
        FadeManager.Instance.LoadScene("TalkScene", 2.0f);
    }

    public void PushButtonSpeak()
    {
        SlliderSound.SetActive(true);
        ButtonOff.SetActive(true);
    }

    public void PushButtonOff()
    {
        SlliderSound.SetActive(false);
        ButtonOff.SetActive(false);
    }
}
