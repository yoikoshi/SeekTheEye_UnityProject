using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HintTextManager : MonoBehaviour
{
    public GameObject Talk;
    public GameObject boxes;
    public GameObject Item;
    public GameObject GameManager;
    public GameObject Text;
    public GameObject FaceImage;
    public GameObject FaceImage2;
    public GameObject ClickBlockUI;
    public GameObject Sound;

    public string[] texts;//Unity上で入力するstringの配列
    int textNumber;//何番目のtexts[]を表示させるか
    string displayText;//表示させるstring
    int textCharNumber;//何文字目をdisplayTextに追加するか
    float displayTextSpeed; //全体のフレームレートを落とす変数
    bool click;//クリック判定
    public bool textStop; //テキスト表示を始めるか
    bool textend;
    private bool SoundOne = false;
    public AudioClip TextSound;

    GameManager script;
    AudioSource audioSource;

    public GameObject ImageTra;
    private float time;
    private bool TextGo;

    void Start()
    {
        audioSource = Sound.GetComponent<AudioSource>();
        GameManager = GameObject.Find("GameManager");
        script = GameManager.GetComponent<GameManager>();
        FaceImage.SetActive(true);
        FaceImage2.SetActive(false);
    }
    void Update()
    {
        time += Time.deltaTime;
        if (time >= 1.2f)
        {
            TextGo = true;
            time = 0;
        }

        if (script.textone)
        {
            textStop = false;
            FaceImage.SetActive(true);
            FaceImage2.SetActive(false);
        }

        if (textNumber == 0 && textCharNumber == 0 && !SoundOne)
        {
            audioSource.PlayOneShot(TextSound);
            SoundOne = true;
        }

        if (textStop == false) //テキストを表示させるif文
        {
            displayTextSpeed += Time.deltaTime;
            if (displayTextSpeed >= 0.04f)//５回に一回プログラムを実行するif文
            {

                displayTextSpeed = 0;
                if (textCharNumber != texts[textNumber].Length)//もしtext[textNumber]の文字列の文字が最後の文字じゃなければ
                {
                    ImageTra.SetActive(false);
                    displayText = displayText + texts[textNumber][textCharNumber];//displayTextに文字を追加していく
                    textCharNumber = textCharNumber + 1;//次の文字にする
                }
                else//もしtext[textNumber]の文字列の文字が最後の文字だったら
                {
                    textend = true;

                    if (textNumber != texts.Length - 1)//もしtexts[]が最後のセリフじゃないときは
                    {
                        if (TextGo)
                        {
                            ImageTra.SetActive(true);
                        }
                        if (click == true && TextGo)//クリックされた判定
                        {
                            TextGo = false;
                            displayText = "";//表示させる文字列を消す
                            textCharNumber = 0;//文字の番号を最初にする
                            textNumber = textNumber + 1;//次のセリフにする
                            audioSource.PlayOneShot(TextSound);
                        }
                    }
                    else //もしtexts[]が最後のセリフになったら
                    {
                        if (TextGo)
                        {
                            ImageTra.SetActive(true);
                        }
                        if (click == true && textend && TextGo) //クリックされた判定
                        {
                            TextGo = false;
                            displayText = ""; //表示させる文字列も消す
                            textCharNumber = 0; //文字の番号を最初にする
                            textNumber = 0;
                            script.textone = false;
                            textStop = true; //セリフ表示を止める
                            Talk.SetActive(false);
                            boxes.SetActive(true);
                            Item.SetActive(true);                            
                            Text.SetActive(false);
                            ClickBlockUI.SetActive(false);
                            FaceImage.SetActive(false);
                            FaceImage2.SetActive(true);
                            SoundOne = false;
                        }
                    }
                }

                this.GetComponent<Text>().text = displayText;//画面上にdisplayTextを表示
                click = false;//クリックされた判定を解除
            }
            if (Input.GetMouseButton(0))//マウスをクリックしたら
            {
                click = true; //クリックされた判定にする
            }
        }
    }
}
