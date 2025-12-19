using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClockPositionManager : MonoBehaviour
{
    GameManager script;
    public GameObject ButtonClock;
    private int ClockSpeed;

    // Start is called before the first frame update
    void Start()
    {
        script = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        ClockSpeed++;
        Transform tr = ButtonClock.GetComponent<Transform>();
        Vector3 pos = tr.position;
        if(pos.x <= 1)
        {
            if (ClockSpeed % 2 == 0)
            {
                pos.x += (1 % 100);
                tr.position = pos;
            }
        }
    }
}
