using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlantManager : MonoBehaviour
{
    GameManager script;
    public GameObject ButtonRedEyes;
    // Start is called before the first frame update
    void Start()
    {
        script = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void FallRedEyes()
    {
        //眼・赤落下
        if (!script.doeshaveredeyes)
        {
            ButtonRedEyes.SetActive(true);
        }
    }

}
