using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioClip BookSound;
    public AudioClip FootSound;
    public AudioClip DeskPullSound;
    public AudioClip KeySound;
    public AudioClip LockerKeySound;
    public AudioClip ItemGetSound;
    public AudioClip CatSound;
    public AudioClip WindowSound;
    public AudioClip LockerSound;


    private bool FootInterval = true;

    AudioSource audioSource;
    BoxManager scriptB;
    GameManager script;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        script = GameObject.Find("GameManager").GetComponent<GameManager>();
        scriptB = GameObject.Find("BoxManager").GetComponent<BoxManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Delay()
    {
        FootInterval = true;
    }

    public void SoundBook()
    {  
        audioSource.PlayOneShot(BookSound);
    }

    public void SoundDeskPull()
    {
        audioSource.PlayOneShot(DeskPullSound);
    }

    public void SoundKey()
    {
        if (script.doeshavekey && script.KeyNo == scriptB.select_num && !scriptB.select)
        {
            audioSource.PlayOneShot(KeySound);
        }
       
    }

    public void SoundLockerKey()
    {
        audioSource.PlayOneShot(LockerKeySound);
    }

    public void SoundItemGet()
    {
        audioSource.PlayOneShot(ItemGetSound);
    }

    public void SoundCat()
    {
        audioSource.PlayOneShot(CatSound);
    }

    public void SoundWindow()
    {
        audioSource.PlayOneShot(WindowSound);
    }

    public void SoundLocker()
    {
        audioSource.PlayOneShot(LockerSound);
    }

    public void SoundFoot()
    {
        if (FootInterval)
        {
            FootInterval = false;
            audioSource.PlayOneShot(FootSound);
            Invoke("Delay", 1.0f);
        } 
    }
}
