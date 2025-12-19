using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;
using UnityEngine.SceneManagement;

public class AdsManager : MonoBehaviour, IUnityAdsLoadListener, IUnityAdsShowListener, IUnityAdsInitializationListener
{
    private string gameIDGoogleplay = "4804479"/* , gameIDAppstore = "3817246" */;
    private static readonly string VIDEO_PLACEMENT_ID = "Rewarded_Android";

    public GameObject SuperHintReady;

    GameManager script;

    void Start()
    {
        script = GameObject.Find("GameManager").GetComponent<GameManager>();
        //Advertisement.AddListener(this);
        Advertisement.Initialize(gameIDGoogleplay, false, this);
    }

    void Update()
    {
       

    }

    public void PushButtonSuperHint()
    {
        SuperHintReady.SetActive(true);
        LoadAd();
    }

    public void ShowMovieAd()
    {
        ////広告全体の準備が出来ているかチェック
        //if (!Advertisement.OnUnityAdsAdLoaded())
        //{
        //    Debug.LogWarning("動画広告の準備が出来ていません");
        //    return;
        //}

        ////表示したい広告の準備が出来ているかチェック
        //var state = Advertisement.GetPlacementState(VIDEO_PLACEMENT_ID);
        //if (state != PlacementState.Ready)
        //{
        //    Debug.LogWarning($"{VIDEO_PLACEMENT_ID}の準備が出来ていません。現在の状態 : {state}");
        //    return; ;
        //}

        //広告表示
        ShowAd();
    }

    public void LoadAd()
    {
        // IMPORTANT! Only load content AFTER initialization (in this example, initialization is handled in a different script).
        Debug.Log("Loading Ad: " + VIDEO_PLACEMENT_ID);
        Advertisement.Load(VIDEO_PLACEMENT_ID, this);
    }

    // Show the loaded content in the Ad Unit:
    public void ShowAd()
    {
        // Note that if the ad content wasn't previously loaded, this method will fail
        Debug.Log("Showing Ad: " + VIDEO_PLACEMENT_ID);
        Advertisement.Show(VIDEO_PLACEMENT_ID, this);
    }

    // Implement Load Listener and Show Listener interface methods: 
    public void OnUnityAdsAdLoaded(string adUnitId)
    {
        Debug.Log("Loaded Ad: " + gameIDGoogleplay);
        // Optionally execute code if the Ad Unit successfully loads content.
    }

    public void OnUnityAdsFailedToLoad(string gameIDGoogleplay, UnityAdsLoadError error, string message)
    {
        Debug.Log($"Error loading Ad Unit: {gameIDGoogleplay} - {error.ToString()} - {message}");
        // Optionally execute code if the Ad Unit fails to load, such as attempting to try again.
    }

    public void OnUnityAdsShowFailure(string gameIDGoogleplay, UnityAdsShowError error, string message)
    {
        Debug.Log($"Error showing Ad Unit {gameIDGoogleplay}: {error.ToString()} - {message}");
        // Optionally execute code if the Ad Unit fails to show, such as loading another ad.
    }

    public void OnUnityAdsShowStart(string gameIDGoogleplay) { }
    public void OnUnityAdsShowClick(string gameIDGoogleplay) { }
    public void OnUnityAdsShowComplete(string gameIDGoogleplay, UnityAdsShowCompletionState showCompletionState) 
    {
        if (showCompletionState == UnityAdsShowCompletionState.COMPLETED)
        {
            SuperHintReady.SetActive(false);
            script.PushSuperHintText();

            // SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        else if (showCompletionState == UnityAdsShowCompletionState.SKIPPED)
        {
            SuperHintReady.SetActive(false);
            script.PushSuperHintText();
        }
        else if (showCompletionState == UnityAdsShowCompletionState.UNKNOWN)
        {
            SuperHintReady.SetActive(false);
        }
    }

    //public void OnUnityAdsDidFinish(string placementId, ShowResult showResult)
    //{
    //    // Define conditional logic for each ad completion status:
    //    if (showResult == ShowResult.Finished)
    //    {
    //        SuperHintReady.SetActive(false);
    //        script.PushSuperHintText();

    //        // SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    //    }
    //    else if (showResult == ShowResult.Skipped)
    //    {
    //        SuperHintReady.SetActive(false);
    //        script.PushSuperHintText();
    //    }
    //    else if (showResult == ShowResult.Failed)
    //    {
    //        SuperHintReady.SetActive(false);
    //    }
    //}

    //public void OnUnityAdsReady(string placementId)
    //{
    //    if (placementId != gameIDGoogleplay) return;
    //}

    //public void OnUnityAdsDidError(string message)
    //{
    //    // Log the error.
    //}

    //public void OnUnityAdsDidStart(string placementId)
    //{
    //    // Optional actions to take when the end-users triggers an ad.
    //}

    public void OnInitializationComplete()
    {
        Debug.Log("Unity Ads initialization complete.");
    }

    public void OnInitializationFailed(UnityAdsInitializationError error, string message)
    {
        Debug.Log($"Unity Ads Initialization Failed: {error.ToString()} - {message}");
    }

}
