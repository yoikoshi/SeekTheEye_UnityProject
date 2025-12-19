using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{
    BoxManager script;
    NumberManager scriptnumber;
    WindowManager scriptwindow;
    TimerManager scripttimer;
    AudioSource audioSource;

    public AudioClip ItemGetSound;
    public AudioClip KachaSound;
    public AudioClip LightSound;
    public AudioClip DoorSound;
    public AudioClip WaterSound;
    public AudioClip GoGoGoSound;
    public AudioClip FireSound;
    public AudioClip PironSound;
    public AudioClip LockerOpenSound;
    public GameObject Sound;

    public GameObject penelWalls;

    public GameObject FaceImage2;
    public GameObject FaceImage3;

    public GameObject ButtonOffUI;
    public GameObject ButtonOff;
    public GameObject ButtonOff3;
    public GameObject ButtonOff4;

    public GameObject ButtonScissors;
    public GameObject ButtonKokubankeshi;
    public GameObject ButtonMemo;
    public GameObject ButtonKey;
    public GameObject ButtonPencil;

    public GameObject ButtonScissorsBig;
    public GameObject ButtonKokubankeshiBig;
    public GameObject ButtonMemoBig;
    public GameObject ButtonLightBig;
    public GameObject ButtonPencilBig;
    public GameObject ButtonBlueEyesInBig;
    public GameObject ButtonDriverMBig;
    public GameObject ButtonMemoWritten;
    public GameObject ButtonMemoUp;
    public GameObject ButtonNumberKey;
    public GameObject ImageNumberKey;
    public GameObject ImageNumberKeyB;
    public GameObject ImageLockerOpen;
    public GameObject ButtonBlueEyesIn;
    public GameObject ButtonDriver;
    public GameObject ButtonHandrailUp;
    public GameObject ImageHandrailUp;
    public GameObject ButtonDriverGripBig;
    public GameObject ButtonDriverGrip;
    public GameObject ButtonDriverMinus;
    public GameObject ButtonBlueEyes;
    public GameObject ButtonEyesEmpty;
    public GameObject ImagePlantBig;
    public GameObject ImageOcto;
    public GameObject ClickBlockUI;
    public GameObject ClickBlockUILast;
    public GameObject ButtonRedEyes;
    public GameObject ButtonRedEyesBig;
    public GameObject ButtonStandLight;
    public GameObject ImageShineLight;
    public GameObject ImageShine;
    public GameObject ImageLightCircle;
    public GameObject ButtonRedEyesBig2;
    public GameObject ImageRedEyesBig;
    public GameObject TextRedEyesBig;
    public GameObject ImageOpenChokeBox;
    public GameObject ImageChokeBoxKey;
    public GameObject ButtonDriverP;
    public GameObject ButtonDriverPBig;
    public GameObject ButtonDriverPlusBig;
    public GameObject ImageHide;
    public GameObject Board;
    public GameObject ButtonBlackLight;
    public GameObject ButtonBlackLightBig;
    public GameObject ButtonBlackLight2Big;
    public GameObject ButtonBlackLightMural;
    public GameObject ImageBlackLightMural;
    public GameObject ButtonOffMural;
    public GameObject ImageBlackLightClock;
    public GameObject ButtonBlackLightClock;
    public GameObject ButtonOffClock;
    public GameObject ButtonClock;
    public GameObject ImageClock;
    public GameObject ButtonWhiteEyesBig;
    public GameObject ButtonWhiteEyes;
    public GameObject ImageDoorR;
    public GameObject ImageDoorL;
    public GameObject EscapeSuccess;
    public GameObject SliderSound;
    public GameObject ButtonTimer;
    public GameObject ButtonNekokanBig;
    public GameObject ButtonNekokan;
    public GameObject ButtonTextNekokan;
    public GameObject ImageLockerOpenNekokan;
    public GameObject ButtonHintYellow;
    public GameObject Really;
    public GameObject ButtonItemComent;
    public GameObject[] ImageDark = new GameObject [4];
    public GameObject[] ButtonScrew = new GameObject[4];
    public GameObject[] Black = new GameObject[4];

    public GameObject ImageBlueEyes;
    public GameObject ImageRedEyes;
    public GameObject ImageWhiteEyes;

    public GameObject Talk;
    public GameObject boxes;
    public GameObject Item;

    //Sヒントテキスト
    public GameObject SuperHintMemoText;
    public GameObject SuperHintClockText;
    public GameObject SuperHintRedEyesText;
    public GameObject SuperHintWindowText;
    public GameObject SuperHintScrewText;
    public GameObject SuperNoHintText;
    public GameObject ButtonSuperHintOrange;
    public GameObject SuperHintReady;

    //ヒントテキスト
    public GameObject MemoText;
    public GameObject ScissorsText;
    public GameObject KokubankeshiText;
    public GameObject KeyText;
    public GameObject LightText;
    public GameObject PencilText;
    public GameObject DarkText;
    public GameObject BlueEyesInText;
    public GameObject ColorText;
    public GameObject DriverMText;
    public GameObject MinusDriverText;
    public GameObject DriverGripText;
    public GameObject EyesEmptyText;
    public GameObject WaterInText;
    public GameObject PlantText;
    public GameObject OctoText;
    public GameObject AboveEyesText;
    public GameObject PlantGrowedText;
    public GameObject RoomDarkText;
    public GameObject DriverPText;
    public GameObject DriverPlusText;
    public GameObject ScrewNormalText;
    public GameObject ScrewNotText;
    public GameObject PaperText;
    public GameObject BlackLightText;
    public GameObject BlackLight2Text;
    public GameObject ClockText;
    public GameObject ClockOpenText;
    public GameObject DoorText;
    public GameObject CanOpenText;
    public GameObject ExitText;
    public GameObject CanWaterText;
    public GameObject CatText;
    public GameObject CatText2;
    public GameObject CatText3;
    public GameObject NekokanText;
    public GameObject NekokanLockerText;
    public GameObject NekokanExitText;

    public GameObject [] HintText;

    public GameObject ButtonDesk;
    public GameObject ButtonDeskOpen;
    public GameObject ButtonDeskTrigger;
    public GameObject ButtonLight;
    public GameObject ImageDesk;

    public GameObject ButtonSchoolDesk;
    public GameObject ButtonSchoolDeskOpen;
    public GameObject ButtonSchoolDeskUp;
    public GameObject ButtonSchoolDeskUp2;

    public const int WALL_FRONT = 1;
    public const int WALL_RIGHT = 2;
    public const int WALL_LEFT = 3;
    public const int WALL_BACK = 4;
    public const int BOX_TYPE = 7;

    public Sprite ScissorsPicture;
    public Sprite KokubankeshiPicture;
    public Sprite EmptyPicture;
    public Sprite KeyPicture;
    public Sprite MemoPicture;
    public Sprite LightPicture;
    public Sprite PencilPicture;
    public Sprite MemoWrittenPicture;
    public Sprite DeskOpenPicture;
    public Sprite BlueEyesInPicture;
    public Sprite HandrailUpOpenPicture;
    public Sprite HandrailUpPicture;
    public Sprite DriverMPicture;
    public Sprite DriverGripPicture;
    public Sprite DriverMinusPicture;
    public Sprite BlueEyesPicture;
    public Sprite EyesEmptyPicture;
    public Sprite WaterInPicture;
    public Sprite RedEyesPicture;
    public Sprite StandLightPicture;
    public Sprite StandLight2Picture;
    public Sprite ShineLightPicture;
    public Sprite ShineLight2Picture;
    public Sprite RedEyesBigPicture;
    public Sprite RedEyesNumBigPicture;
    public Sprite DriverPPicture;
    public Sprite DriverPlusPicture;
    public Sprite BlackLightPicture;
    public Sprite BlackLight2Picture;
    public Sprite WhiteEyesPicture;
    public Sprite DoorRPicture;
    public Sprite DoorBlackPicture;
    public Sprite NekokanPicture;

    public bool textone;
    public int box_count = 0;
    public GameObject[] Empty = new GameObject[7];

    private int Block_count;
    private int Block_num;
    private int Screw_count = 0;

    private int CatCount;

    private int wallNo;
    private int ScissorsNo;
    private int KokubankeshiNo;
    public int KeyNo;
    private int MemoNo;
    private int LightNo;
    private int PencilNo;
    private int MemoWrittenNo;
    private int BlueEyesInNo;
    private int DriverMNo;
    private int DriverGripNo;
    private int DriverMinusNo;
    private int EyesEmptyNo;
    private int WaterInNo;
    private int DriverPNo;
    private int DriverPlusNo;
    private int BlackLightNo;
    private int BlackLight2No;
    private int NekokanNo;

    //private int DeltaItem;

    private bool boxfull = true;
    private bool DeskOpened;
    private bool SchoolDeskOpened;
    private bool PlantGrow;
    private bool Darked;
    private bool StandLight2nd;
    private bool RedEyesBack;
    private bool RedEyesBigOn;
    private bool RedEyesBiged;
    private bool BlackLightClockOn;
    private bool ClockOpenTextSent = false;
    private bool ClockOpen = false;
    private bool CanOpen = false;
   // private bool FlagExplain;
    public bool ExDoorOpen;

    private bool doeshavescissors;
    private bool doeshavekokubankeshi;
    public bool doeshavekey;
    private bool doeshaveMemo;
    private bool doeshavelight;
    private bool doeshavepencil;
    private bool doeshavememowritten;
    private bool doeshaveblueeyesin;
    private bool doeshavedriverm;
    private bool doeshavedrivergrip;
    private bool doeshavedriverminus;
    private bool doeshaveblueeyes;
    private bool doeshaveeyesempty;
    private bool doeshavewaterin;
    public bool doeshaveredeyes;
    private bool doeshavedriverp;
    private bool doeshavedriverplus;
    private bool doeshaveblacklight;
    private bool doeshaveblacklight2;
    private bool doeshavewhiteeyes;
    private bool doeshavenekokan;

    // Start is called before the first frame update
    void Start()
    {
        //黒化
  
        //初期化処理
        boxfull = true;
        DeskOpened = false;
        SchoolDeskOpened = false;
        PlantGrow = false;
        Darked = false;
        StandLight2nd = false;
        RedEyesBack = false;
        RedEyesBigOn = false;
        RedEyesBiged = false;
        BlackLightClockOn = false;
        ClockOpenTextSent = false;
        ClockOpen = false;
        CanOpen = false;

        ExDoorOpen = false;

   　　 doeshavescissors = false;
   　　 doeshavekokubankeshi = false;
        doeshavekey = false;
        doeshaveMemo = false;
        doeshavelight = false;
        doeshavepencil = false;
        doeshavememowritten = false;
        doeshaveblueeyesin = false;
        doeshavedriverm = false;
        doeshavedrivergrip = false;
        doeshavedriverminus = false;
        doeshaveblueeyes = false;
        doeshaveeyesempty = false;
        doeshavewaterin = false;
        doeshaveredeyes = false;
        doeshavedriverp = false;
        doeshavedriverplus = false;
        doeshaveblacklight = false;
        doeshaveblacklight2 = false;
        doeshavewhiteeyes = false;
        doeshavenekokan = false;


        wallNo = WALL_FRONT;

        audioSource = Sound.GetComponent<AudioSource>();

        //他のスクリプト読み込み

        script = GameObject.Find("BoxManager").GetComponent<BoxManager>();
        scriptnumber = GameObject.Find("NumberManager").GetComponent<NumberManager>();
        scriptwindow = GameObject.Find("WindowManager").GetComponent<WindowManager>();
        scripttimer = GameObject.Find("TimerManager").GetComponent<TimerManager>();
    }
    // Update is called once per frame
    void Update()
    {
        //アイテムがいっぱいか
        if (box_count == 7)
        {
            boxfull = false;
        }
        else
        {
            boxfull = true;
        }

        //謎のバグ処理
        if (box_count < 0)
        {
            box_count = 0;
        }

        if (scriptnumber.LockOpened)
        {
            ImageLockerOpen.SetActive(true);
            ButtonBlueEyesIn.SetActive(true);
            scriptnumber.LockOpened = false;
        }


        //スタンドライト光出現
        if (Darked && !StandLight2nd)
        {
            ImageShine.SetActive(true);
        }
        else
        {
            ImageShine.SetActive(false);
        }

        //スタンドライト光(正面)出現
        if (Darked && StandLight2nd)
        {
            ImageLightCircle.SetActive(true);
        }
        else
        {
            ImageLightCircle.SetActive(false);
        }


        //ブラックライト懐中電灯合成
        if (doeshavelight && doeshaveblacklight && script.select_num_past == BlackLightNo)
        {
            if (script.buttonNo == LightNo)
            {
                Empty[BlackLightNo - 1].SetActive(false);
                Empty[LightNo - 1].SetActive(false);
                ButtonBlackLight2Big.SetActive(true);
                script.buttonNo = 0;
                script.select_num = -1;
                audioSource.PlayOneShot(ItemGetSound);
            }
        }

        //+ドライバー合成
        if (doeshavedriverp && doeshavedriverminus && script.select_num_past == DriverPNo)
        {
            if (script.buttonNo == DriverMinusNo)
            {       
                Empty[DriverMinusNo - 1].SetActive(false);
                Empty[DriverPNo - 1].SetActive(false);
                ButtonDriverPlusBig.SetActive(true);
                script.buttonNo = 0;
                script.select_num = -1;
                audioSource.PlayOneShot(ItemGetSound);
            }

        }

        //容器を外す（合成）
        if (doeshavedriverminus && doeshaveblueeyesin && script.select_num_past == DriverMinusNo)
        {
            if (script.buttonNo == BlueEyesInNo)
            {
                Empty[BlueEyesInNo - 1].SetActive(false);
                ButtonBlueEyes.SetActive(true);
                script.buttonNo = 0;
                script.select_num = -1;
                audioSource.PlayOneShot(ItemGetSound);
            }

        }

        //-ドライバー合成
        if (doeshavedriverm && doeshavedrivergrip && script.select_num_past == DriverMNo)
        {
            if (script.buttonNo == DriverGripNo)
            {               
                Empty[DriverGripNo - 1].SetActive(false);               
                Empty[DriverMNo - 1].SetActive(false);
                ButtonDriverMinus.SetActive(true);
                script.buttonNo = 0;
                script.select_num = -1;
                audioSource.PlayOneShot(ItemGetSound);
            }

        }

        //鍵合成
        if (doeshavescissors && doeshavekokubankeshi && script.select_num_past == ScissorsNo)
        {
            if (script.select_num == KokubankeshiNo)
            {
                Empty[KokubankeshiNo - 1].SetActive(false);
                Empty[ScissorsNo - 1].SetActive(false);
                ButtonKey.SetActive(true);
                script.buttonNo = 0;
                script.select_num = -1;
                audioSource.PlayOneShot(ItemGetSound);
            }
        }



        //メモ＋鉛筆合成
        if (doeshaveMemo && doeshavepencil && script.select_num_past == PencilNo)
        {
            if (script.buttonNo == MemoNo)
            {
                Empty[PencilNo - 1].SetActive(false);
                Empty[MemoNo - 1].SetActive(false);
                ButtonMemoWritten.SetActive(true);
                script.buttonNo = 0;
                script.select_num = -1;
                audioSource.PlayOneShot(ItemGetSound);
            }

        }

        //メモ説明
        if (
            (doeshaveMemo && MemoNo == script.select_num && !script.select) ||
            (doeshavescissors && ScissorsNo == script.select_num && !script.select) ||
            (doeshavekokubankeshi && KokubankeshiNo == script.select_num && !script.select) ||
            (doeshavekey && KeyNo == script.select_num && !script.select) ||
            (doeshavelight && LightNo == script.select_num && !script.select) ||
            (doeshavepencil && PencilNo == script.select_num && !script.select) ||
            (doeshavememowritten && MemoWrittenNo == script.select_num && !script.select) ||
            (doeshaveblueeyesin && BlueEyesInNo == script.select_num && !script.select) ||
            (doeshavedriverm && DriverMNo == script.select_num && !script.select) ||
            (doeshavedriverminus && DriverMinusNo == script.select_num && !script.select) ||
            (doeshaveeyesempty && EyesEmptyNo == script.select_num && !script.select) ||
            (doeshavewaterin && EyesEmptyNo == script.select_num && !script.select) ||
            (doeshavedriverp && DriverPNo == script.select_num && !script.select) ||
            (doeshavedrivergrip && DriverGripNo == script.select_num && !script.select) ||
            (doeshavedriverplus && DriverPlusNo == script.select_num && !script.select) ||
            (doeshaveblacklight && BlackLightNo == script.select_num && !script.select) ||
            (doeshaveblacklight2 && BlackLight2No == script.select_num && !script.select) ||
            (doeshavenekokan && NekokanNo == script.select_num && !script.select)
            )
        {
            ButtonItemComent.SetActive(true);
        }
        else
        {
            ButtonItemComent.SetActive(false);
        }

        

        //眼・赤暗号オン
        if (RedEyesBigOn && RedEyesBack)
        {
            TextRedEyesBig.SetActive(true);
        }
        else
        {
            TextRedEyesBig.SetActive(false);
        }

        //時計解けたよ
        if (PlantGrow && StandLight2nd && BlackLightClockOn && !ClockOpenTextSent)
        {
            TextOn();
            script.select_num = -1;
            ClockOpenText.SetActive(true);
            ClickBlockUI.SetActive(true);
            ClockOpenTextSent = true;
            ClockOpen = true;
        }

        //ドア開いたよ
        if ((doeshaveblueeyes && doeshaveredeyes && doeshavewhiteeyes && !CanOpen))
        {
            TextOn();
            script.select_num = -1;
            CanOpenText.SetActive(true);
            ClickBlockUI.SetActive(true);
            CanOpen = true;
            audioSource.PlayOneShot(KachaSound);
            doeshaveblueeyes = false;
        }

        //ヒントあるよ
        if (ExDoorOpen)
        {
            ButtonHintYellow.SetActive(false);
        }
        else if (!doeshavekokubankeshi && !doeshavekey && !doeshavelight && !doeshaveblacklight2 && wallNo == 1)
        {
            ButtonHintYellow.SetActive(true);
        }
        else if (doeshavekey && wallNo == 1)
        {
            ButtonHintYellow.SetActive(true);
        }
        else if (!doeshavedrivergrip && !doeshavedriverminus && !doeshavedriverplus && wallNo == 1)
        {
            ButtonHintYellow.SetActive(true);
        }
        else if (doeshaveredeyes && !doeshavedriverp && !doeshavedriverplus && RedEyesBiged && wallNo == 1)
        {
            ButtonSuperHintOrange.SetActive(true);
            ButtonHintYellow.SetActive(true);
        }
        else if (doeshaveblacklight2 && doeshaveredeyes && !doeshavewhiteeyes && wallNo == 1)
        {
            ButtonSuperHintOrange.SetActive(true);
            ButtonHintYellow.SetActive(true);
        }
        else if (!doeshavedriverm && !doeshavedriverminus && !doeshavedriverplus && wallNo == 4)
        {
            ButtonHintYellow.SetActive(true);
        }
        else if (!doeshaveblueeyesin && doeshavememowritten && wallNo == 3)
        {
            ButtonSuperHintOrange.SetActive(true);
            ButtonHintYellow.SetActive(true);
        }
        else if (!doeshaveredeyes && !Darked && doeshaveeyesempty && wallNo == 3)
        {
            ButtonHintYellow.SetActive(true);
        }
        else if (doeshavedriverplus && !doeshaveblacklight && !doeshaveblacklight2 && wallNo == 3)
        {
            ButtonSuperHintOrange.SetActive(true);
            ButtonHintYellow.SetActive(true);
        }
        else
        {
            ButtonSuperHintOrange.SetActive(false);
            ButtonHintYellow.SetActive(false);
        }

    }

    //アイテム説明
    public void PushButtonItemComent()
    {
        //メモ説明
        if (doeshaveMemo && MemoNo == script.select_num && !script.select)
        {
            MemoText.SetActive(true);
            TextSet();
        }

        //はさみ説明
        if (doeshavescissors && ScissorsNo == script.select_num && !script.select)
        {
            ScissorsText.SetActive(true);
            TextSet();
        }

        //黒板消し説明
        if (doeshavekokubankeshi && KokubankeshiNo == script.select_num && !script.select)
        {
            KokubankeshiText.SetActive(true);
            TextSet(); ;
        }

        //鍵説明
        if (doeshavekey && KeyNo == script.select_num && !script.select)
        {
            KeyText.SetActive(true);
            TextSet();
        }

        //ライト説明
        if (doeshavelight && LightNo == script.select_num && !script.select)
        {
            LightText.SetActive(true);
            TextSet();
        }

        //鉛筆説明
        if (doeshavepencil && PencilNo == script.select_num && !script.select)
        {
            PencilText.SetActive(true);
            TextSet();
        }

        //メモアップ
        if (doeshavememowritten && MemoWrittenNo == script.select_num && !script.select)
        {
            ButtonMemoUp.SetActive(true);
            PushButtonOff();
        }

        //眼蒼容器説明
        if (doeshaveblueeyesin && BlueEyesInNo == script.select_num && !script.select)
        {
            BlueEyesInText.SetActive(true);
            TextSet();
        }

        //-ドライバーの先説明
        if (doeshavedriverm && DriverMNo == script.select_num && !script.select)
        {
            DriverMText.SetActive(true);
            TextSet();
        }

        //-ドライバー説明
        if (doeshavedriverminus && DriverMinusNo == script.select_num && !script.select)
        {
            MinusDriverText.SetActive(true);
            TextSet();
        }

        //空の容器説明
        if (doeshaveeyesempty && EyesEmptyNo == script.select_num && !script.select)
        {
            EyesEmptyText.SetActive(true);
            TextSet();
        }

        //容器水入り説明
        if (doeshavewaterin && EyesEmptyNo == script.select_num && !script.select)
        {
            WaterInText.SetActive(true);
            TextSet();
        }

        //+ドライバーの先説明
        if (doeshavedriverp && DriverPNo == script.select_num && !script.select)
        {
            DriverPText.SetActive(true);
            TextSet();
        }

        //ドライバーの柄説明
        if (doeshavedrivergrip && DriverGripNo == script.select_num && !script.select)
        {
            DriverGripText.SetActive(true);
            TextSet();
        }

        //+ドライバーの説明
        if (doeshavedriverplus && DriverPlusNo == script.select_num && !script.select)
        {
            DriverPlusText.SetActive(true);
            TextSet();
        }

        //ブラックライト電球の説明
        if (doeshaveblacklight && BlackLightNo == script.select_num && !script.select)
        {
            BlackLightText.SetActive(true);
            TextSet();
        }

        //ブラックライト電灯の説明
        if (doeshaveblacklight2 && BlackLight2No == script.select_num && !script.select)
        {
            BlackLight2Text.SetActive(true);
            TextSet();
        }

        //猫缶の説明
        if (doeshavenekokan && NekokanNo == script.select_num && !script.select)
        {
            NekokanText.SetActive(true);
            TextSet();
        }
    }

    //スーパーヒント
    public void PushSuperHintText()
    {

        if (ExDoorOpen)
        {
            TextOn();
            script.select_num = -1;
            HintText[10].SetActive(true);
            ClickBlockUI.SetActive(true);
        }
        else if (doeshaveredeyes && !doeshavedriverp && !doeshavedriverplus && RedEyesBiged && wallNo == 1)
        {
            //redeyes
            TextHintSet();
            SuperHintRedEyesText.SetActive(true);
        }
        else if (doeshaveblacklight2 && doeshaveredeyes && !doeshavewhiteeyes && wallNo == 1)
        {
            //clock
            TextHintSet();
            SuperHintClockText.SetActive(true);
        }
        else if (!doeshaveblueeyesin && doeshavememowritten && wallNo == 3)
        {
            //memo
            TextHintSet();
            SuperHintMemoText.SetActive(true);
        }
        else if (doeshavedriverplus && !doeshaveblacklight && !doeshaveblacklight2 && wallNo == 3)
        {
            //screw
            TextHintSet();
            SuperHintScrewText.SetActive(true);
        }
        else
        {
            TextOn();
            script.select_num = -1;
            SuperNoHintText.SetActive(true);
            ClickBlockUI.SetActive(true);
        }
    }

    public void PushSuperHintNo()
    {
        SuperHintReady.SetActive(false);
    }

    //Ex脱出勧告テキスト
    public void PushBlock()
    {
        TextOn();
        script.select_num = -1;
        NekokanExitText.SetActive(true);
        ClickBlockUI.SetActive(true);
    }

    //タイマースイッチ消す
    public void PushButtonTimer()
    {
        ButtonTimer.SetActive(false);
    }


    //音量調節バー
    public void PushButtonSpeaker()
    {
        SliderSound.SetActive(true);
        ButtonOffUI.SetActive(true);
    }


    //ヒントテキスト
    public void PushButtonBoxHint()
    {
        if (ExDoorOpen)
        {
            TextOn();
            script.select_num = -1;
            HintText[10].SetActive(true);
            ClickBlockUI.SetActive(true);
        }
        else if (!doeshavekokubankeshi && !doeshavekey && !doeshavelight && !doeshaveblacklight2 && wallNo == 1)
        {
            TextHintSet();
            HintText[0].SetActive(true);           
        }
        else if (doeshavekey && wallNo == 1)
        {
            TextHintSet();
            HintText[5].SetActive(true);
        }
        else if (!doeshavedrivergrip  && !doeshavedriverminus && !doeshavedriverplus && wallNo == 1)
        {
            TextHintSet();
            HintText[3].SetActive(true);
        }
        else if (doeshaveredeyes && !doeshavedriverp && !doeshavedriverplus && RedEyesBiged && wallNo == 1)
        {
            TextHintSet();
            HintText[7].SetActive(true);
        }
        else if (doeshaveblacklight2 && doeshaveredeyes && !doeshavewhiteeyes && wallNo == 1)
        {
            TextHintSet();
            HintText[6].SetActive(true);
        }
        else if (!doeshavedriverm && !doeshavedriverminus && !doeshavedriverplus && wallNo == 4)
        {
            TextHintSet();
            HintText[1].SetActive(true);
        }
        else if (!doeshaveblueeyesin && doeshavememowritten && wallNo == 3)
        {
            TextHintSet();
            HintText[4].SetActive(true);
        }
        else if (!doeshaveredeyes&& !Darked && doeshaveeyesempty && wallNo == 3)
        {
            TextHintSet();
            HintText[2].SetActive(true);
        }
        else if (doeshavedriverplus && !doeshaveblacklight && !doeshaveblacklight2 && wallNo == 3)
        {
            TextHintSet();
            HintText[9].SetActive(true);
        }
        else
        {
            TextOn();
            script.select_num = -1;
            HintText[8].SetActive(true);
            ClickBlockUI.SetActive(true);
        }
    }

    //猫テキスト
    public void PushButtonCat()
    {
        if (CatCount >= 0 && !doeshavedriverplus)
        {
            CatCount++;
        }
        
        if (CatCount <= 10)
        {
            FaceImage3.SetActive(true);
            TextOn();
            script.select_num = -1;
            CatText.SetActive(true);
            ClickBlockUI.SetActive(true);
        }
        else if (doeshavenekokan && NekokanNo == script.select_num)
        {
            doeshavenekokan = false;
            ResetBox();
            Reget();
            FaceImage3.SetActive(true);
            TextOn();
            script.select_num = -1;
            CatText3.SetActive(true);
            ClickBlockUI.SetActive(true);
            CatCount = -1;
        }
        else
        {
            FaceImage3.SetActive(true);
            TextOn();
            script.select_num = -1;
            CatText.SetActive(false);
            CatText2.SetActive(true);
            ClickBlockUI.SetActive(true);
            ButtonTextNekokan.SetActive(true);
        }

    }

    //猫缶取得
    public void PushButtonTextNekokan()
    {
        if (CatCount >= 10 && DriverMinusNo == script.select_num && doeshavedriverminus)
        {
            ButtonTextNekokan.SetActive(false);
            ButtonNekokan.SetActive(true);
            ImageLockerOpenNekokan.SetActive(true);
            audioSource.PlayOneShot(LockerOpenSound);
        }
        else
        {
            TextOn();
            script.select_num = -1;
            NekokanLockerText.SetActive(true);
            ClickBlockUI.SetActive(true);
        }
    }

    public void PushButtonNekokan()
    {
        ButtonNekokan.SetActive(false);
        ButtonNekokanBig.SetActive(true);
    }

    public void PushButtonNekokanBig()
    {
        if (boxfull)
        {
            ButtonNekokanBig.SetActive(false);
            Empty[box_count].SetActive(true);
            Empty[box_count].GetComponent<Image>().sprite = NekokanPicture;
            NekokanNo = box_count + 1;
            box_count++;
            script.select_num = -1;
            doeshavenekokan = true;
        }
    }

    //ドアオープン
    public void PushImageDoor()
    {
        if((doeshaveredeyes && doeshavewhiteeyes) || ExDoorOpen)
        {
            ImageDoorR.GetComponent<Image>().sprite = DoorBlackPicture;
            ImageDoorL.GetComponent<Image>().sprite = DoorRPicture;
            EscapeSuccess.SetActive(true);
            audioSource.PlayOneShot(DoorSound);
            audioSource.PlayOneShot(PironSound);
            scripttimer.TimerStop = true;

            TextOn();
            ExitText.SetActive(true);
            ClickBlockUI.SetActive(true);
            ClickBlockUILast.SetActive(true);
        }
        else
        {
            TextOn();
            script.select_num = -1;
            DoorText.SetActive(true);
            ClickBlockUI.SetActive(true);
        }
    }

    //眼・白取得
    public void PushButtonWhiteEyes()
    {
        ButtonWhiteEyes.SetActive(false);
        ButtonWhiteEyesBig.SetActive(true);
    }

    public void PushButtonWhiteEyesBig()
    {
        ImageWhiteEyes.GetComponent<Image>().sprite = WhiteEyesPicture;
        ButtonWhiteEyesBig.SetActive(false);
        doeshavewhiteeyes = true;
    }

    //時計移動
    public void PushButtonClock()
    {
        if (ClockOpen)
        {
            ButtonClock.SetActive(false);
            audioSource.PlayOneShot(GoGoGoSound);
            Transform tr = ImageClock.GetComponent<Transform>();
            Vector3 pos = tr.position;
            pos.x = 1;
            tr.position = pos;
        }
        else
        {
            TextOn();
            script.select_num = -1;
            ClockText.SetActive(true);
            ClickBlockUI.SetActive(true);
        }
    }

    //壁画出現(時計)
    public void PushButtonBlackLightClock()
    {
        if (doeshaveblacklight2 && BlackLight2No == script.select_num && !script.select && Darked)
        {
            ImageBlackLightClock.SetActive(true);
            ButtonOffClock.SetActive(true);
            BlackLightClockOn = true;
        }
    }

    //壁画出現
    public void PushButtonBlackLightMural()
    {
        if (doeshaveblacklight2 && BlackLight2No == script.select_num && !script.select && Darked)
        {
            ButtonBlackLightMural.SetActive(false);
            ImageBlackLightMural.SetActive(true);
            ButtonOffMural.SetActive(true);
        }
    }


    //ブラックライト電灯取得
    public void PushButtonBlackLight2Big()
    {
        if (boxfull)
        {
            ResetBox();
            doeshaveblacklight = false;
            doeshavelight = false;
            ButtonBlackLight2Big.SetActive(false);
            Empty[box_count].SetActive(true);
            Empty[box_count].GetComponent<Image>().sprite = BlackLight2Picture;
            BlackLight2No = box_count + 1;
            box_count++;
            script.select_num = -1;
            Reget();
            doeshaveblacklight2 = true;
        }
    }


    //ブラックライト取得
    public void PushButtonBlackLight()
    {
        ButtonBlackLightBig.SetActive(true);
        ButtonBlackLight.SetActive(false);
    }

    public void PushButtonBlackLightBig()
    {
        if (boxfull)
        {
            ButtonBlackLightBig.SetActive(false);
            Empty[box_count].SetActive(true);
            Empty[box_count].GetComponent<Image>().sprite = BlackLightPicture;
            BlackLightNo = box_count + 1;
            box_count++;
            script.select_num = -1;
            doeshaveblacklight = true;
        }
    }


    //後ろ黒板紙ヒントテキスト
    public void PushButtonPaper()
    {
        TextOn();
        PaperText.SetActive(true);
        ClickBlockUI.SetActive(true);
        script.select_num = -1;
    }


    //ネジの処理


    //ネジ
    public void PushButtonScrew1()
    {
        if (!doeshavedriverplus)
        {
            TextOn();
            script.select_num = -1;
            ScrewNormalText.SetActive(true);
            ClickBlockUI.SetActive(true);
        }
        else if(Screw_count != 2 && DriverPlusNo == script.select_num)
        {
            TextOn();
            ScrewNotText.SetActive(true);
            ClickBlockUI.SetActive(true);
            script.select_num = -1;
            for (int i = 0; i < 4; i++)
            {
                ButtonScrew[i].SetActive(true);
                Screw_count = 0;
            }
        }
        else if(Screw_count == 2 && DriverPlusNo == script.select_num)
        {
            audioSource.PlayOneShot(KachaSound);
            ButtonScrew[0].SetActive(false);
            Screw_count++;
        }
        else if (doeshavedriverplus)
        {
            TextOn();
            ScrewNormalText.SetActive(true);
            ClickBlockUI.SetActive(true);
        }
    }

    public void PushButtonScrew2()
    {
        if (!doeshavedriverplus)
        {
            TextOn();
            script.select_num = -1;
            ScrewNormalText.SetActive(true);
            ClickBlockUI.SetActive(true);
        }
        else if (Screw_count != 3 && DriverPlusNo == script.select_num && doeshavedriverplus)
        {
            TextOn();
            ScrewNotText.SetActive(true);
            ClickBlockUI.SetActive(true);
            script.select_num = -1;
            for (int i = 0; i < 4; i++)
            {
                ButtonScrew[i].SetActive(true);
                Screw_count = 0;
            }
        }
        else if (Screw_count == 3 && DriverPlusNo == script.select_num && doeshavedriverplus)
        {
            audioSource.PlayOneShot(KachaSound);
            ButtonScrew[1].SetActive(false);
            Board.SetActive(false);
            ButtonBlackLight.SetActive(true);
        }
        else if (doeshavedriverplus)
        {
            TextOn();
            ScrewNormalText.SetActive(true);
            ClickBlockUI.SetActive(true);
        }
    }

    public void PushButtonScrew3()
    {
        if (!doeshavedriverplus)
        {
            TextOn();
            script.select_num = -1;
            ScrewNormalText.SetActive(true);
            ClickBlockUI.SetActive(true);
        }
        else if (Screw_count != 0 && DriverPlusNo == script.select_num && doeshavedriverplus)
        {
            TextOn();
            ScrewNotText.SetActive(true);
            ClickBlockUI.SetActive(true);
            script.select_num = -1;
            for (int i = 0; i < 4; i++)
            {
                ButtonScrew[i].SetActive(true);
                Screw_count = 0;
            }
        }
        else if (Screw_count == 0 && DriverPlusNo == script.select_num && doeshavedriverplus)
        {
            audioSource.PlayOneShot(KachaSound);
            ButtonScrew[2].SetActive(false);
            Screw_count++;
        }
        else if (doeshavedriverplus)
        {
            TextOn();
            ScrewNormalText.SetActive(true);
            ClickBlockUI.SetActive(true);
        }
    }

    public void PushButtonScrew4()
    {
        if (!doeshavedriverplus)
        {
            TextOn();
            script.select_num = -1;
            ScrewNormalText.SetActive(true);
            ClickBlockUI.SetActive(true);
        }
        else if (Screw_count != 1 && DriverPlusNo == script.select_num && doeshavedriverplus)
        {
            TextOn();
            ScrewNotText.SetActive(true);
            ClickBlockUI.SetActive(true);
            script.select_num = -1;
            for (int i = 0; i < 4; i++)
            {
                ButtonScrew[i].SetActive(true);
                Screw_count = 0;
            }
        }
        else if (Screw_count == 1 && DriverPlusNo == script.select_num && doeshavedriverplus)
        {
            audioSource.PlayOneShot(KachaSound);
            ButtonScrew[3].SetActive(false);
            Screw_count++;
        }
        else if (doeshavedriverplus)
        {
            TextOn();
            ScrewNormalText.SetActive(true);
            ClickBlockUI.SetActive(true);
        }
    }

    //+ドライバーの先ポップアップ
    public void PushButtonDriverP()
    {
        ButtonDriverPBig.SetActive(true);
        ButtonDriverP.SetActive(false);
    }

    //+ドライバーの先取得
    public void PushButtonDriverPBig()
    {
        if (boxfull)
        {           
            ButtonDriverPBig.SetActive(false);
            Empty[box_count].SetActive(true);
            Empty[box_count].GetComponent<Image>().sprite = DriverPPicture;
            DriverPNo = box_count + 1;
            box_count++;
            script.select_num = -1;
            doeshavedriverp = true;
        }
    }


    //+ドライバー取得
    public void PushButtonDriverPlusBig()
    {
        if (boxfull)
        {
            ResetBox();
            doeshavedriverp = false;
            ButtonDriverPlusBig.SetActive(false);
            Empty[box_count].SetActive(true);
            Empty[box_count].GetComponent<Image>().sprite = DriverPlusPicture;
            DriverPlusNo = box_count + 1;
            box_count++;
            script.select_num = -1;
            doeshavedriverminus = false;           
            Reget();
            doeshavedriverplus = true;
        }
    }


    //チョーク箱Bオープン
    public void PushButtonChokeDoor()
    {
        ButtonDriverP.SetActive(true);
        ImageOpenChokeBox.SetActive(true);
        ImageChokeBoxKey.SetActive(false);
    }


    //チョーク箱キーBポップアップ
    public void PushButtonChorkBox()
    {
        ImageNumberKeyB.SetActive(true);
        ButtonOff.SetActive(true);
    }


    //眼・赤詳しく
    public void PushImageRedEyes()
    {
        if (doeshaveredeyes)
        {
            ButtonRedEyesBig2.SetActive(true);
            ButtonOffUI.SetActive(true);
            RedEyesBigOn = true;           
        }
       
    }

    public void PushButtonRedEyesBig2()
    {
        if (!RedEyesBack)
        {
            ImageRedEyesBig.GetComponent<Image>().sprite = RedEyesNumBigPicture;           
            RedEyesBack = true;
            RedEyesBiged = true;
        }
        else
        {
            ImageRedEyesBig.GetComponent<Image>().sprite = RedEyesBigPicture;
            RedEyesBack = false;
        }

    }


    //スタンドライト切り替え
    public void PushButtonStandLight()
    {
        audioSource.PlayOneShot(LightSound);
        if (!StandLight2nd)
        {
            ButtonStandLight.GetComponent<Image>().sprite = StandLight2Picture;
            ImageShineLight.GetComponent<Image>().sprite = ShineLight2Picture;
            ImageLightCircle.SetActive(true);
            StandLight2nd = true;
        }
        else
        {
            ButtonStandLight.GetComponent<Image>().sprite = StandLightPicture;
            ImageShineLight.GetComponent<Image>().sprite = ShineLightPicture;
            ImageLightCircle.SetActive(false);
            StandLight2nd = false;
        }
    }


    //眼・赤を手に入れる


    //眼・赤取得
    public void PushButtonRedEyesBig()
    {
        ImageRedEyes.GetComponent<Image>().sprite = RedEyesPicture;
        ButtonRedEyesBig.SetActive(false);
        doeshaveredeyes = true;
        Debug.Log("push");
    }


    //眼・赤ポップアップ
    public void PushButtonRedEyes()
    {
        ButtonRedEyes.SetActive(false);
        ButtonRedEyesBig.SetActive(true);
    }


    //天井の物体説明
    public void PushButtonAboveEyes()
    {
        TextOn();
        AboveEyesText.SetActive(true);
        ClickBlockUI.SetActive(true);
        script.select_num = -1;
    }


    //部屋の電気を消す
    public void PushButtonSwich()
    {
        if (!Darked)
        {
            for(int i = 0; i < 4; i++)
            {
                ImageDark[i].SetActive(true);
            }
            ImageOcto.SetActive(false);
            ButtonBlackLightClock.SetActive(true);
            Darked = true;
        }
        else
        {
            for (int i = 0; i < 4; i++)
            {
                ImageDark[i].SetActive(false);
            }
            ImageOcto.SetActive(true);
            ButtonBlackLightClock.SetActive(false);
            ImageBlackLightClock.SetActive(false);
            Darked = false;
        }
    }

    //植物巨大化&説明
    public void PushButtonPlant()
    {
        if (doeshavewaterin && EyesEmptyNo == script.select_num)
        {
            Empty[EyesEmptyNo - 1].GetComponent<Image>().sprite = EyesEmptyPicture;
            doeshaveeyesempty = true;
            doeshavewaterin = false;
            script.select_num = -1;
            ImagePlantBig.SetActive(true);
            PlantGrow = true;
            ImagePlantBig.layer = 0;
            ImageHide.SetActive(true);
            audioSource.PlayOneShot(FireSound);
        }
        else if(!PlantGrow)
        {
            TextOn();
            script.select_num = -1;
            ClickBlockUI.SetActive(true);
            PlantText.SetActive(true);
        }
        else if (PlantGrow)
        {
            TextOn();
            script.select_num = -1;
            ClickBlockUI.SetActive(true);
            PlantGrowedText.SetActive(true);
        }

    }


    //植物巨大化解除
    public void ResetPlant()
    {
        ImagePlantBig.SetActive(false);
        PlantGrow = false;
    }


    //水を容器に入れる


    public void PushButtonWater()
    {
        if (doeshaveeyesempty && EyesEmptyNo == script.select_num && Darked)
        {
            audioSource.PlayOneShot(WaterSound);
            Empty[EyesEmptyNo - 1].GetComponent<Image>().sprite = WaterInPicture;
            doeshaveeyesempty = false;
            doeshavewaterin = true;
        }
        else if(!Darked)
        {
            TextOn();
            script.select_num = -1;
            ClickBlockUI.SetActive(true);
            OctoText.SetActive(true);
        }
        else if (Darked)
        {
            TextOn();
            script.select_num = -1;
            ClickBlockUI.SetActive(true);
            CanWaterText.SetActive(true);
        }

    }


    //眼蒼＆容器を手に入れる


    //眼・蒼取得
    public void PushButtonBlueEyes()
    {
        audioSource.PlayOneShot(ItemGetSound);
        ButtonBlueEyes.SetActive(false);
        ButtonEyesEmpty.SetActive(true);
        ImageBlueEyes.GetComponent<Image>().sprite = BlueEyesPicture;
    }

    public void PushButtonEyesEmpty()
    {     
        if (boxfull)
        {
            script.select_num = -1;
            ResetBox();
            doeshaveblueeyesin = false;
            ButtonEyesEmpty.SetActive(false);
            Empty[box_count].SetActive(true);
            Empty[box_count].GetComponent<Image>().sprite = EyesEmptyPicture;
            EyesEmptyNo = box_count + 1;
            box_count++;
            script.select_num = -1;
            Reget();
            doeshaveeyesempty = true;
            doeshaveblueeyes = true;
        }
    }

    //-ドライバーを手に入れる


    public void PushButtonDriverMinus()
    {
            ResetBox();
            doeshavedriverm = false;
            ButtonDriverMinus.SetActive(false);
            Empty[box_count].SetActive(true);
            Empty[box_count].GetComponent<Image>().sprite = DriverMinusPicture;
            DriverMinusNo = box_count + 1;
            box_count++;
            script.select_num = -1;
            doeshavedrivergrip = false;
            Reget();
            doeshavedriverminus = true;
    }


        //ドライバーの柄を手に入れる


        public void PushButtonDriverGrip()
    {
        ButtonDriverGrip.SetActive(false);
        ButtonDriverGripBig.SetActive(true);
    }

    public void PushButtonDriverGripBig()
    {
        if (boxfull)
        {
            ButtonDriverGripBig.SetActive(false);
            Empty[box_count].SetActive(true);
            Empty[box_count].GetComponent<Image>().sprite = DriverGripPicture;
            DriverGripNo = box_count + 1;
            box_count++;
            script.select_num = -1;
            doeshavedrivergrip = true;
        }
    }


    //-ドライバーの先を手に入れる


    //手すりポップアップ
    public void PushButtonColor()
    {
        ButtonHandrailUp.SetActive(true);
        ButtonOff3.SetActive(true);

        if (scriptwindow.RightColor && !doeshavedriverm && !doeshavedriverminus && !doeshavedriverplus)
        {
            ImageHandrailUp.GetComponent<Image>().sprite = HandrailUpOpenPicture;
            ButtonDriver.SetActive(true);
        }
        else if (doeshavedriverminus || doeshavedriverm || doeshavedriverplus)
        {
            ImageHandrailUp.GetComponent<Image>().sprite = HandrailUpOpenPicture;
        }
        else
        {
            ImageHandrailUp.GetComponent<Image>().sprite = HandrailUpPicture;
        }
    }

    //カラー表ヒントテキスト
    public void PushButtonHandrail()
    {
        if (!scriptwindow.RightColor && !doeshavedriverm)
        {
            TextOn();
            script.select_num = -1;
            ColorText.SetActive(true);
            ClickBlockUI.SetActive(true);
        }
    }

    //マイナスドライバーポップアップ
    public void PushButtonDriver()
    {
        ButtonDriverMBig.SetActive(true);
        ButtonDriver.SetActive(false);
    }

    //マイナスドライバーの先取得
    public void PushButtonDriverMBig()
    {
        if (boxfull)
        {
            ButtonDriverMBig.SetActive(false);
            Empty[box_count].SetActive(true);
            Empty[box_count].GetComponent<Image>().sprite = DriverMPicture;
            DriverMNo = box_count + 1;
            box_count++;
            script.select_num = -1;
            doeshavedriverm = true;
        }
    }


　　//眼・蒼(容器入り)を手に入れる


    //眼蒼容器ポップアップ
    public void PushButtonBlueEyesIn()
    {
        ButtonBlueEyesIn.SetActive(false);
        ButtonBlueEyesInBig.SetActive(true);
    }

    //眼蒼容器取得
    public void PushButtonBlueEyesInBig()
    {
        if (boxfull)
        {
            ResetBox();
            doeshavememowritten = false;
            ButtonBlueEyesInBig.SetActive(false);
            Empty[box_count].SetActive(true);
            Empty[box_count].GetComponent<Image>().sprite = BlueEyesInPicture;
            BlueEyesInNo = box_count + 1;
            box_count++;
            script.select_num = -1;
            Reget();
            doeshaveblueeyesin = true;          
        }
    }

    //ロッカーキーポップアップ
    public void PushButtonNumberKey()
    {
        ImageNumberKey.SetActive(true);
        ButtonOff4.SetActive(true);
        ButtonBlackLightMural.SetActive(false);
    }

    //メモアップオフ
    public void PushButtonMemoUp()
    {
        ButtonMemoUp.SetActive(false);
    }


    //鉛筆を手に入れる


    //椅子を引く
    public void PushButtonSchoolDesk()
    {
        ButtonSchoolDesk.SetActive(false);
        ButtonSchoolDeskOpen.SetActive(true);
    }

    //机アップ
    public void PushButtonSchoolDeskOpen()
    {
        if (SchoolDeskOpened)
        {
            ButtonSchoolDeskUp2.SetActive(true);
            ButtonOff3.SetActive(true);
        }
        else
        {
            ButtonSchoolDeskUp.SetActive(true);
            ButtonOff3.SetActive(true);
        }
    }

    //机照らす
    public void PushButtonSchoolDeskUp()
    {
        if (doeshavelight && LightNo == script.select_num && !script.select)
        {
            ButtonSchoolDeskUp.SetActive(false);
            ButtonSchoolDeskUp2.SetActive(true);
            SchoolDeskOpened = true;
        }
        else
        {
            ClickBlockUI.SetActive(true);
            TextOn();
            script.select_num = -1;
            DarkText.SetActive(true);
        }
    }

    //鉛筆ポップアップ
    public void PushButtonPencil()
    {      
        ButtonPencilBig.SetActive(true);
        ButtonPencil.SetActive(false);       
    }

    //鉛筆取得
    public void PushButtonPencilBig()
    {
        if (boxfull)
        {
            ButtonPencilBig.SetActive(false);
            Empty[box_count].SetActive(true);
            Empty[box_count].GetComponent<Image>().sprite = PencilPicture;
            PencilNo = box_count + 1;
            box_count++;
            script.select_num = -1;
            doeshavepencil = true;
        }
    }


    //懐中電灯を手に入れる


    //教壇アップ
    public void PushButtonDeskTrigger()
    {
        if (DeskOpened)
        {
            ButtonDeskOpen.SetActive(true);
            ButtonDesk.SetActive(false);
            ButtonOff.SetActive(true);
        }
        else
        {
            ButtonDesk.SetActive(true);
            ButtonDeskTrigger.SetActive(false);
            ButtonOff.SetActive(true);
        }
    }

    //教壇オープン+鍵消滅処理
    public void PushButtonDesk()
    {
        if (doeshavekey && KeyNo == script.select_num && !script.select)
        {
            DeskOpened = true;
            ButtonDeskOpen.SetActive(true);
            ButtonDesk.SetActive(false);
            ImageDesk.GetComponent<Image>().sprite = DeskOpenPicture;
            doeshavekey = false;
            script.buttonNo = 0;
            script.select_num = -1;
            ResetBox();
            Reget();
        }
    }

    //ライト取得画面へ
    public void PushButtonDeskOpen()
    {       
        ButtonLight.SetActive(false);
        ButtonLightBig.SetActive(true);
    }

    //ライト取得
    public void PushButtonLightBig()
    {
        if (boxfull)
        {
            ButtonLightBig.SetActive(false);
            Empty[box_count].SetActive(true);
            Empty[box_count].GetComponent<Image>().sprite = LightPicture;
            LightNo = box_count + 1;
            box_count++;
            script.select_num = -1;
            doeshavelight = true;
        }      
    }


    //ハサミを手に入れる


    //ハサミ取得
    public void PushButtonScissors()
    {
        if (boxfull)
        {
            ButtonScissors.SetActive(false);
            ButtonScissorsBig.SetActive(true);

        }
    }

    public void PushButtonScissorsBig()
    {
        if (boxfull)
        {
            ButtonScissorsBig.SetActive(false);
            Empty[box_count].SetActive(true);
            Empty[box_count].GetComponent<Image>().sprite = ScissorsPicture;
            ScissorsNo = box_count + 1;
            box_count++;
            script.select_num = -1;
            doeshavescissors = true;
        }
    }


    //黒板消しを手に入れる


    //黒板消し取得
    public void PushButtonKokubankeshi()
    {
        if (boxfull)
        {
            ButtonKokubankeshi.SetActive(false);
            ButtonKokubankeshiBig.SetActive(true);

        }
    }

    public void PushButtonKokubankeshiBig()
    {
        if (boxfull)
        {
            ButtonKokubankeshiBig.SetActive(false);
            Empty[box_count].SetActive(true);
            Empty[box_count].GetComponent<Image>().sprite = KokubankeshiPicture;
            KokubankeshiNo = box_count + 1;
            box_count++;
            script.select_num = -1;
            doeshavekokubankeshi = true;
        }
    }


    //メモを手に入れる


    //メモ取得
    public void PushButtonMemo()
    {
        if (boxfull)
        {
            ButtonMemo.SetActive(false);
            ButtonMemoBig.SetActive(true);
        }
    }

    public void PushButtonMemoBig()
    {
        if (boxfull)
        {
            ButtonMemoBig.SetActive(false);
            Empty[box_count].SetActive(true);
            Empty[box_count].GetComponent<Image>().sprite = MemoPicture;
            MemoNo = box_count + 1;
            box_count++;
            script.select_num = -1;
            doeshaveMemo = true;
        }
    }


    //合成で手に入るアイテム処理


    //鍵取得
    public void PushButtonKey()
    {
        ResetBox();
        ButtonKey.SetActive(false);
        doeshavekokubankeshi = false;
        doeshavescissors = false;
        Empty[box_count].SetActive(true);
        Empty[box_count].GetComponent<Image>().sprite = KeyPicture;
        KeyNo = box_count + 1;
        box_count++;
        script.select_num = -1;
        Reget();
        doeshavekey = true;
    }

    //書かれたメモ取得
    public void PushButtonMemoWritten()
    {
        ResetBox();
        ButtonMemoWritten.SetActive(false);
        doeshaveMemo = false;
        doeshavepencil = false;
        Empty[box_count].SetActive(true);
        Empty[box_count].GetComponent<Image>().sprite = MemoWrittenPicture;
        MemoWrittenNo = box_count + 1;
        box_count++;
        script.select_num = -1;
        Reget();
        doeshavememowritten = true;
    }


    //システム全体に関わる処理


    //電気消した時の説明
    public void PushDark()
    {
        TextOn();
        RoomDarkText.SetActive(true);
        ClickBlockUI.SetActive(true);
        script.select_num = -1;
    }


    //アイテム説明表示
    public void TextOn()
    {
        Talk.SetActive(true);
        boxes.SetActive(false);
        Item.SetActive(false);
        textone = true;
    }

    //アイテムリセット
    public void ResetBox()
    {
        box_count = 0;
        for (int i = 0; i < 7; i++)
        {
            Empty[i].GetComponent<Image>().sprite = EmptyPicture;
            Empty[i].SetActive(false);
        }
    } 

    //テキストON
    public void TextSet()
    {      
        TextOn();
        ClickBlockUI.SetActive(true);
    }

    //ヒントテキストON
    public void TextHintSet()
    {
        TextOn();
        script.select_num = -1;
        ClickBlockUI.SetActive(true);
        TimerManager.HintCount++;
    }

    //アップ表示オフ
    public void PushButtonOff()
    {
        
        ButtonDesk.SetActive(false);
        ButtonDeskOpen.SetActive(false);
        ButtonDeskTrigger.SetActive(true);

        ButtonSchoolDeskUp.SetActive(false);
        ButtonSchoolDeskUp2.SetActive(false);

        ButtonOffUI.SetActive(false);
        ButtonOff.SetActive(false);
        ButtonOff3.SetActive(false);
        ButtonOff4.SetActive(false);

        ButtonHandrailUp.SetActive(false);
        ButtonDriver.SetActive(false);

        ImageNumberKey.SetActive(false);
        ImageNumberKeyB.SetActive(false);

        ButtonRedEyesBig2.SetActive(false);
        RedEyesBigOn = false;

        ButtonBlackLightMural.SetActive(true);
        ImageBlackLightMural.SetActive(false);

        ImageBlackLightClock.SetActive(false);
        BlackLightClockOn = false;

        ButtonOffClock.SetActive(false);
        ButtonOffMural.SetActive(false);

        SliderSound.SetActive(false);
    }

    //再取得
    public void Reget()
    {
        if (doeshavescissors)
        {
            Empty[box_count].SetActive(true);
            Empty[box_count].GetComponent<Image>().sprite = ScissorsPicture;
            ScissorsNo = box_count + 1;
            box_count++;
        }

        if (doeshavekokubankeshi)
        {
            Empty[box_count].SetActive(true);
            Empty[box_count].GetComponent<Image>().sprite = KokubankeshiPicture;
            KokubankeshiNo = box_count + 1;
            box_count++;
        }

        if (doeshaveMemo)
        {
            Empty[box_count].SetActive(true);
            Empty[box_count].GetComponent<Image>().sprite = MemoPicture;
            MemoNo = box_count + 1;
            box_count++;
        }

        if (doeshavekey)
        {
            Empty[box_count].SetActive(true);
            Empty[box_count].GetComponent<Image>().sprite = KeyPicture;
            KeyNo = box_count + 1;
            box_count++; 
        }

        if (doeshavepencil)
        {
            Empty[box_count].SetActive(true);
            Empty[box_count].GetComponent<Image>().sprite = PencilPicture;
            PencilNo = box_count + 1;
            box_count++;
        }

        if (doeshavelight)
        {
            Empty[box_count].SetActive(true);
            Empty[box_count].GetComponent<Image>().sprite = LightPicture;
            LightNo = box_count + 1;
            box_count++;
        }

        if (doeshaveblueeyesin)
        {
            Empty[box_count].SetActive(true);
            Empty[box_count].GetComponent<Image>().sprite = BlueEyesInPicture;
            BlueEyesInNo = box_count + 1;
            box_count++;
        }

        if (doeshavememowritten)
        {
            Empty[box_count].SetActive(true);
            Empty[box_count].GetComponent<Image>().sprite = MemoWrittenPicture;
            MemoWrittenNo = box_count + 1;
            box_count++; ;
        }

        if (doeshavedriverm)
        {
            Empty[box_count].SetActive(true);
            Empty[box_count].GetComponent<Image>().sprite = DriverMPicture;
            DriverMNo = box_count + 1;
            box_count++;
        }

        if (doeshavedrivergrip)
        {
            Empty[box_count].SetActive(true);
            Empty[box_count].GetComponent<Image>().sprite = DriverGripPicture;
            DriverGripNo = box_count + 1;
            box_count++;
        }

        if (doeshavedriverminus)
        {
            Empty[box_count].SetActive(true);
            Empty[box_count].GetComponent<Image>().sprite = DriverMinusPicture;
            DriverMinusNo = box_count + 1;
            box_count++;
        }

        if (doeshaveeyesempty)
        {
            Empty[box_count].SetActive(true);
            Empty[box_count].GetComponent<Image>().sprite = EyesEmptyPicture;
            EyesEmptyNo = box_count + 1;
            box_count++;
        }

        if (doeshavewaterin)
        {
            Empty[box_count].SetActive(true);
            Empty[box_count].GetComponent<Image>().sprite = WaterInPicture;
            EyesEmptyNo = box_count + 1;
            box_count++;
        }

        if (doeshavedriverp)
        {
            Empty[box_count].SetActive(true);
            Empty[box_count].GetComponent<Image>().sprite = DriverPPicture;
            DriverPNo = box_count + 1;
            box_count++;
        }

        if (doeshavedriverplus)
        {
            Empty[box_count].SetActive(true);
            Empty[box_count].GetComponent<Image>().sprite = DriverPlusPicture;
            DriverPlusNo = box_count + 1;
            box_count++;
        }

        if (doeshaveblacklight)
        {
            Empty[box_count].SetActive(true);
            Empty[box_count].GetComponent<Image>().sprite = BlackLightPicture;
            BlackLightNo = box_count + 1;
            box_count++;
        }

        if (doeshaveblacklight2)
        {
            Empty[box_count].SetActive(true);
            Empty[box_count].GetComponent<Image>().sprite = BlackLight2Picture;
            BlackLight2No = box_count + 1;
            box_count++;
        }

        if (doeshavenekokan)
        {
            Empty[box_count].SetActive(true);
            Empty[box_count].GetComponent<Image>().sprite = NekokanPicture;
            NekokanNo = box_count + 1;
            box_count++;
        }
    }


    //移動
    public void PushButtonRight ()
    {
        wallNo++;
        if (wallNo > WALL_BACK)
        {
            wallNo = WALL_FRONT;
        }
        DisplayWall();
    }

    public void PushButtonLeft ()
    {
        wallNo--;
        if (wallNo < WALL_FRONT)
        {
            wallNo = WALL_BACK;
        }
        DisplayWall();
    }

    //タイトルへ戻る
    public void PushButtonTitleYes()
    {
        FadeManager.Instance.LoadScene("TitleScene", 2.0f);
    }

    public void PushButtonTitleNo()
    {
        Really.SetActive(false);
        ClickBlockUI.SetActive(false);
    }

    public void PushButtonTitleHome()
    {
        Really.SetActive(true);
        ClickBlockUI.SetActive(true);
        script.select_num = -1;
        audioSource.PlayOneShot(ItemGetSound);
    }

    //視点切り替え
    void DisplayWall()
    {
        switch (wallNo)
        {
            case WALL_FRONT:
                penelWalls.transform.localPosition = new Vector3(0.0f, 0.0f, 0.0f);
                Black[0].SetActive(false);
                Black[1].SetActive(true);
                Black[2].SetActive(true);
                Black[3].SetActive(true);
                break;
            case WALL_RIGHT:
                penelWalls.transform.localPosition = new Vector3(-960.0f, 0.0f, 0.0f);
                Black[0].SetActive(true);
                Black[1].SetActive(false);
                Black[2].SetActive(true);
                Black[3].SetActive(true);
                break;
            case WALL_BACK:
                penelWalls.transform.localPosition = new Vector3(-1920.0f, 0.0f, 0.0f);
                Black[0].SetActive(true);
                Black[1].SetActive(true);
                Black[2].SetActive(false);
                Black[3].SetActive(true);
                break;
            case WALL_LEFT:
                penelWalls.transform.localPosition = new Vector3(-2880.0f, 0.0f, 0.0f);
                Black[0].SetActive(true);
                Black[1].SetActive(true);
                Black[2].SetActive(true);
                Black[3].SetActive(false);
                break;
        }
    }

}
