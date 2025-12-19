using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndingTextTalkManager : MonoBehaviour
{
    EndingTalkManager script;

    public string[] texts;//Unity上で入力するstringの配列
    int textNumber;//何番目のtexts[]を表示させるか
    string displayText;//表示させるstring
    int textCharNumber;//何文字目をdisplayTextに追加するか
    float displayTextSpeed; //全体のフレームレートを落とす変数
    public bool textStop; //テキスト表示を始めるか
    bool textend;

    public GameObject ImageTraL;
    public GameObject ImageTraR;
    public AudioClip TextSound;
    public GameObject Sound;
    private bool SoundOne = false;

    public float time;
    private bool TextGo;

    AudioSource audioSource;

    void Start()
    {
        audioSource = Sound.GetComponent<AudioSource>();
        script = GameObject.Find("EndingTalkManager").GetComponent<EndingTalkManager>();
    }
    void Update()
    {
        time += Time.deltaTime;
        if(time >= 1.2f)
        {
            TextGo = true;
            time = 0;
        }

        if (textStop == false) //テキストを表示させるif文
        {

            if (textNumber == 0 && textCharNumber == 0 && !SoundOne)
            {
                ImageTraL.SetActive(false);
                ImageTraR.SetActive(false);
                audioSource.PlayOneShot(TextSound);
                SoundOne = true;
            }

            displayTextSpeed += Time.deltaTime;
            if (displayTextSpeed >= 0.04f)//５回に一回プログラムを実行するif文
            {
                if (script.Click == true)
                {
                    displayText = "";
                    textCharNumber = texts[textNumber].Length;
                    displayText = texts[textNumber];
                }

                displayTextSpeed = 0;
                if (textCharNumber != texts[textNumber].Length)//もしtext[textNumber]の文字列の文字が最後の文字じゃなければ
                {
                    ImageTraL.SetActive(false);
                    ImageTraR.SetActive(false);
                    displayText = displayText + texts[textNumber][textCharNumber];//displayTextに文字を追加していく
                    textCharNumber = textCharNumber + 1;//次の文字にする
                }
                else//もしtext[textNumber]の文字列の文字が最後の文字だったら
                {
                    textend = true;

                    if (script.SetTraL && TextGo)
                    {
                        ImageTraL.SetActive(true);
                    }
                    else if (script.SetTraR && TextGo)
                    {
                        ImageTraR.SetActive(true);
                    }

                    if (textNumber != texts.Length - 1)//もしtexts[]が最後のセリフじゃないときは
                    {
                        if (script.Click == true && TextGo)//クリックされた判定
                        {
                            TextGo = false;
                            audioSource.PlayOneShot(TextSound);
                            displayText = "";//表示させる文字列を消す
                            textCharNumber = 0;//文字の番号を最初にする
                            textNumber = textNumber + 1;//次のセリフにする                           
                        }
                    }
                    else //もしtexts[]が最後のセリフになったら
                    {
                        if (script.SetTraL && TextGo)
                        {
                            ImageTraL.SetActive(true);
                        }
                        else if (script.SetTraR && TextGo)
                        {
                            ImageTraR.SetActive(true);
                        }

                        if (script.Click == true && textend && TextGo) //クリックされた判定
                        {
                            TextGo = false;
                            displayText = ""; //表示させる文字列も消す
                            textCharNumber = 0; //文字の番号を最初にする
                            textNumber = 0;
                            textStop = true; //セリフ表示を止める

                            script.TalkNum++;
                        }
                    }
                }

                this.GetComponent<Text>().text = displayText;//画面上にdisplayTextを表示
                script.Click = false;//クリックされた判定を解除
            }

        }
    }

}
