using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharaMove2Manager : MonoBehaviour
{
    public GameObject ImageChie;
    public GameObject ImageChieShadow;
    public GameObject ClickBlockUI;
    private float speed = 0.08f;
    public bool MoveOn = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Transform tr = ImageChie.GetComponent<Transform>();
        Vector3 pos = tr.position;
        if (pos.x >= 6.5f && MoveOn)
        {
            pos.x -= speed;
            tr.position = pos;
        }

        Transform tr2 = ImageChieShadow.GetComponent<Transform>();
        Vector3 pos2 = tr2.position;
        if (pos2.x >= 6.5f && MoveOn)
        {
            pos2.x -= speed;
            tr2.position = pos2;
        }
    }
}
