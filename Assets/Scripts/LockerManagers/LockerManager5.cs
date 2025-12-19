using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class LockerManager5 : MonoBehaviour
{

    NumberManager script;

    // Start is called before the first frame update
    void Start()
    {
        script = GameObject.Find("NumberManager").GetComponent<NumberManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
        
            this.GetComponent<Text>().text = script.texts1;
        
    }
}
