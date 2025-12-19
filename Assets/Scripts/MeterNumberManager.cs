using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MeterNumberManager : MonoBehaviour
{
    ThemometerManager script;
    // Start is called before the first frame update
    void Start()
    {
        script = GameObject.Find("ThermometerManager").GetComponent<ThemometerManager>();
    }

    // Update is called once per frame
    void Update()
    {
        this.GetComponent<Text>().text = script.text;
    }
}
