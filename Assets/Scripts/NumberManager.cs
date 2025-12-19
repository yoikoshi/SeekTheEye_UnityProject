using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class NumberManager : MonoBehaviour
{
    private int Num_count1 = 0;
    private int Num_count2 = 0;
    private int Num_count3 = 0;
    private int Num_count4 = 0;
    public string texts1;
    public string texts2;
    public string texts3;
    public string texts4;

    public GameObject ButtonLockerDoor;
    public GameObject ButtonNumberKey;
    public GameObject ImageNumberKey;
    public GameObject ImageOpen;
    public GameObject ImageLocked;

    public bool LockOpened;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        texts1 = Num_count1.ToString();
        texts2 = Num_count2.ToString();
        texts3 = Num_count3.ToString();
        texts4 = Num_count4.ToString();

        if(Num_count1 == 4 && Num_count2 == 4 && Num_count3 == 1 && Num_count4 == 1)
        {
            ButtonLockerDoor.SetActive(true);
            //ImageNumberKey.SetActive(false);
            ButtonNumberKey.SetActive(false);
            ImageOpen.SetActive(true);
            ImageLocked.SetActive(false);
        }
        else
        {
            ButtonLockerDoor.SetActive(false);
            ButtonNumberKey.SetActive(true);
            ImageOpen.SetActive(false);
            ImageLocked.SetActive(true);
        }
    }

    public void PushButtonNumber1()
    {
        Num_count1++;
        if(Num_count1 > 9)
        {
            Num_count1 = 0;
        }
    }

    public void PushButtonNumber2()
    {
        Num_count2++;
        if (Num_count2 > 9)
        {
            Num_count2 = 0;
        }
    }

    public void PushButtonNumber3()
    {
        Num_count3++;
        if (Num_count3 > 9)
        {
            Num_count3 = 0;
        }
    }

    public void PushButtonNumber4()
    {
        Num_count4++;
        if (Num_count4 > 9)
        {
            Num_count4 = 0;
        }
    }

    public void ResetNumber()
    {
        Num_count1 = 0;
        Num_count2 = 0;
        Num_count3 = 0;
        Num_count4 = 0;
    }

    public void PushButtonLockerDoor()
    {
        LockOpened = true;
        ButtonLockerDoor.SetActive(false);
        Num_count1 = 0;
    }
}
