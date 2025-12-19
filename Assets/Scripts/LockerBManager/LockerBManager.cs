using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class LockerBManager : MonoBehaviour
{

    NumberBManager script;

    // Start is called before the first frame update
    void Start()
    {
        script = GameObject.Find("NumberBManager").GetComponent<NumberBManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
        
            this.GetComponent<Text>().text = script.texts1B;
        
    }
}
