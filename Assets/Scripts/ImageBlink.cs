using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageBlink : MonoBehaviour
{
    public float speed = 1.0f;

    //private
    private Text text;
    private Image image;
    private float time;

    // Start is called before the first frame update
    void Start()
    {
        image = this.gameObject.GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        image.color = GetAlphaColor(image.color);
    }
    //Alpha値を更新してColorを返す
    Color GetAlphaColor(Color color)
    {
        time += Time.deltaTime * 5.0f * speed;
        color.a = Mathf.Sin(time) * 0.5f + 0.5f;

        return color;
    }
}
