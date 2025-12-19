using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NumberBManager : MonoBehaviour
{
    private int Num_count1B = 0;
    private int Num_count2B = 0;
    private int Num_count3B = 0;
    private int Num_count4B = 0;
    public string texts1B;
    public string texts2B;
    public string texts3B;
    public string texts4B;

    public GameObject ButtonChokeDoor;
    public GameObject ButtonNumberKeyB;
    public GameObject ImageNumberKeyB;
    public GameObject ImageOpenB;
    public GameObject ImageLockedB;

    public bool LockOpenedB;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        texts1B = Num_count1B.ToString();
        texts2B = Num_count2B.ToString();
        texts3B = Num_count3B.ToString();
        texts4B = Num_count4B.ToString();

        if (Num_count1B == 3 && Num_count2B == 2 && Num_count3B == 1 && Num_count4B == 4)
        {
            ButtonChokeDoor.SetActive(true);
            ButtonNumberKeyB.SetActive(false);
            ImageOpenB.SetActive(true);
            ImageLockedB.SetActive(false);
        }
        else
        {
            ButtonChokeDoor.SetActive(false);
            ButtonNumberKeyB.SetActive(true);
            ImageOpenB.SetActive(false);
            ImageLockedB.SetActive(true);
        }
    }

    public void PushButtonNumber1B()
    {
        Num_count1B++;
        if (Num_count1B > 9)
        {
            Num_count1B = 0;
        }
    }

    public void PushButtonNumber2B()
    {
        Num_count2B++;
        if (Num_count2B > 9)
        {
            Num_count2B = 0;
        }
    }

    public void PushButtonNumber3B()
    {
        Num_count3B++;
        if (Num_count3B > 9)
        {
            Num_count3B = 0;
        }
    }

    public void PushButtonNumber4B()
    {
        Num_count4B++;
        if (Num_count4B > 9)
        {
            Num_count4B = 0;
        }
    }

    public void ResetNumber()
    {
        Num_count1B = 0;
        Num_count2B = 0;
        Num_count3B = 0;
        Num_count4B = 0;
    }

    public void PushButtonChokeDoor()
    {
        LockOpenedB = true;
        ButtonChokeDoor.SetActive(false);
        Num_count1B = 0;
    }
}
