using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharaMoveManager : MonoBehaviour
{
    
    public GameObject ImageShujinkou;
    public GameObject ImageShujinkouSup;
    public GameObject ImageShujinkouShadow;
    public GameObject ClickBlockUI;
    private float speed = 0.08f;

    private Image image1;
    private Image image2;
    private Image image3;
    public bool MoveBack = false;
   // private bool MoveOn = false;

    // Start is called before the first frame update
    void Start()
    {
        image1 = ImageShujinkou.GetComponent<Image>();
        image1.color = new Color(1, 1, 1, 1.0f);
        image2 = ImageShujinkouSup.GetComponent<Image>();
        image2.color = new Color(1, 1, 1, 1.0f);
        image3 = ImageShujinkouShadow.GetComponent<Image>();
        image3.color = new Color(1, 1, 1.0f);

    }

    // Update is called once per frame
    void Update()
    {
        Transform tr = ImageShujinkou.GetComponent<Transform>();
        Vector3 pos = tr.position;
        if (pos.x <= -6.5f)
        {
            pos.x += speed;
            tr.position = pos;
        }


        Transform tr2 = ImageShujinkouShadow.GetComponent<Transform>();
        Vector3 pos2 = tr2.position;
        if (pos2.x <= -6.5f)
        {
            pos2.x += speed;
            tr2.position = pos2;
        }

        Transform tr3 = ImageShujinkouSup.GetComponent<Transform>();
        Vector3 pos3 = tr3.position;
        if (pos3.x <= -6.5f && !MoveBack)
        {
            pos3.x += speed;
            tr3.position = pos3;
        }
        else if (MoveBack)
        {
            pos3.x -= speed;
            tr3.position = pos3;
        }

        if (pos.x == -6.5f)
        {
            image1.color = new Color(1, 1, 1, 0.0f);
            image2.color = new Color(1, 1, 1, 0.0f);
            image3.color = new Color(1, 1, 1, 0.0f);
        }
    }
}
