using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class BoxManager : MonoBehaviour
{
    public const int BOX = 7;
    public GameObject[] Boxes = new GameObject[BOX];
    public Sprite Boxselect;
    public Sprite Box;

    public bool select = true;
    public int select_num = 0;
    public int select_num_past = 0;
    public int buttonNo = 0;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (select_num == -1)
        {
            ResetSelect();
        }
    }

    public void ResetSelect()
    {
        for (int i = 0; i < BOX; i++)
        {
            Boxes[i].GetComponent<Image>().sprite = Box;
            select_num = 0;
            buttonNo = 0;
            select = true;
        }
    }

    public void PushButtonBox1()
    {
        buttonNo = 1;
        if (select)
        {
            Boxes[0].GetComponent<Image>().sprite = Boxselect;
            select = false;
            select_num = 1;
        }
         else if (select_num == 1)
        {
            Boxes[0].GetComponent<Image>().sprite = Box;
            select = true;
            select_num = -1;
        }
        else
        {
            for (int i = 0; i < BOX; i++)
            {
                Boxes[i].GetComponent<Image>().sprite = Box;
            }
            Boxes[0].GetComponent<Image>().sprite = Boxselect;
            select = false;
            select_num_past = select_num;
            select_num = 1;
        }
    }
    public void PushButtonBox2()
    {
        buttonNo = 2;
        if (select)
        {
            Boxes[1].GetComponent<Image>().sprite = Boxselect;
            select = false;
            select_num = 2;
        }
        else if (select_num == 2)
        {
            Boxes[1].GetComponent<Image>().sprite = Box;
            select = true;
            select_num = -1;
        }
        else
        {
            for (int i = 0; i < BOX; i++)
            {
                Boxes[i].GetComponent<Image>().sprite = Box;
            }
            Boxes[1].GetComponent<Image>().sprite = Boxselect;
            select = false;
            select_num_past = select_num;
            select_num = 2;
        }
    }
    public void PushButtonBox3()
    {
        buttonNo = 3;
        if (select)
        {
            Boxes[2].GetComponent<Image>().sprite = Boxselect;
            select = false;
            select_num = 3;
        }
        else if (select_num == 3)
        {
            Boxes[2].GetComponent<Image>().sprite = Box;
            select = true;
            select_num = -1;
        }
        else
        {
            for (int i = 0; i < BOX; i++)
            {
                Boxes[i].GetComponent<Image>().sprite = Box;
            }
            Boxes[2].GetComponent<Image>().sprite = Boxselect;
            select = false;
            select_num_past = select_num;
            select_num = 3;
        }
    }
    public void PushButtonBox4()
    {
        buttonNo = 4;
        if (select)
        {
            Boxes[3].GetComponent<Image>().sprite = Boxselect;
            select = false;
            select_num = 4;
        }
        else if (select_num == 4)
        {
            Boxes[3].GetComponent<Image>().sprite = Box;
            select = true;
            select_num = -1;
        }
        else
        {
            for (int i = 0; i < BOX; i++)
            {
                Boxes[i].GetComponent<Image>().sprite = Box;
            }
            Boxes[3].GetComponent<Image>().sprite = Boxselect;
            select = false;
            select_num_past = select_num;
            select_num = 4;
        }
    }
    public void PushButtonBox5()
    {
        buttonNo = 5;
        if (select)
        {
            Boxes[4].GetComponent<Image>().sprite = Boxselect;
            select = false;
            select_num = 5;
        }
        else if (select_num == 5)
        {
            Boxes[4].GetComponent<Image>().sprite = Box;
            select = true;
            select_num = -1;
        }
        else
        {
            for (int i = 0; i < BOX; i++)
            {
                Boxes[i].GetComponent<Image>().sprite = Box;
            }
            Boxes[4].GetComponent<Image>().sprite = Boxselect;
            select = false;
            select_num_past = select_num;
            select_num = 5;
        }
    }
    public void PushButtonBox6()
    {
        buttonNo = 6;
        if (select)
        {
            Boxes[5].GetComponent<Image>().sprite = Boxselect;
            select = false;
            select_num = 6;
        }
        else if (select_num == 6)
        {
            Boxes[5].GetComponent<Image>().sprite = Box;
            select = true;
            select_num = -1;
        }
        else
        {
            for (int i = 0; i < BOX; i++)
            {
                Boxes[i].GetComponent<Image>().sprite = Box;
            }
            Boxes[5].GetComponent<Image>().sprite = Boxselect;
            select = false;
            select_num_past = select_num;
            select_num = 6;
        }
    }
    public void PushButtonBox7()
    {
        buttonNo = 7;
        if (select)
        {
            Boxes[6].GetComponent<Image>().sprite = Boxselect;
            select = false;
            select_num = 7;
        }
        else if (select_num == 7)
        {
            Boxes[6].GetComponent<Image>().sprite = Box;
            select = true;
            select_num = -1;
        }
        else
        {
            for (int i = 0; i < BOX; i++)
            {
                Boxes[i].GetComponent<Image>().sprite = Box;
            }
            Boxes[6].GetComponent<Image>().sprite = Boxselect;
            select = false;
            select_num_past = select_num;
            select_num = 7;
        }
    }

}
