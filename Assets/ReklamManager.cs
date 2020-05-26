using AppodealAds.Unity.Api;
using AppodealAds.Unity.Common;
using System;
using UnityEngine;

public class ReklamManager : MonoBehaviour, IPermissionGrantedListener, IRewardedVideoAdListener
{
    public static ReklamManager instance = null;

    public string AndroidappKey = "7480f3fd516afc0a8166ed83ae8f0012406f2e2705be242e";
    public string IosappKey = "7480f3fd516afc0a8166ed83ae8f0012406f2e2705be242e";

    private string appKey;
    int timesTriedToShowInterstitial = 0;

    public bool test = false;
    Action rewarededAction = null;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this);
        }
        else if (this != instance)
            Destroy(this);

#if UNITY_ANDROID
        appKey = AndroidappKey;
#else
             appKey = IosappKey;

#endif

        Appodeal.requestAndroidMPermissions(this);
        Appodeal.setTesting(test);
        var gdpr = PlayerPrefs.GetInt("result_gdpr_sdk", 0);
        Debug.Log("result_gdpr_sdk: " + gdpr);
        Appodeal.initialize(appKey, Appodeal.INTERSTITIAL | Appodeal.REWARDED_VIDEO | Appodeal.BANNER, gdpr == 1);
        Appodeal.setRewardedVideoCallbacks(this);
    }

    public void ShowBanner()
    {
        if (Appodeal.isLoaded(Appodeal.BANNER))
            Appodeal.show(Appodeal.BANNER_HORIZONTAL_SMART);
    }
    public void HideBanner()
    {
        Appodeal.hide(Appodeal.BANNER);
    }

    public void ShowInterstitial()
    {
        timesTriedToShowInterstitial++;
        if (Appodeal.isLoaded(Appodeal.INTERSTITIAL))
            Appodeal.show(Appodeal.INTERSTITIAL);
    }

    public bool ShowRewareded(Action callBack)
    {
        rewarededAction = null;
        if (Appodeal.isLoaded(Appodeal.REWARDED_VIDEO))
        {
            Appodeal.show(Appodeal.REWARDED_VIDEO);
            rewarededAction = callBack;
            return true;
        }
        else return false;
    }


    public void writeExternalStorageResponse(int result)
    {
        Debug.Log(result == 0
            ? "WRITE_EXTERNAL_STORAGE permission granted"
            : "WRITE_EXTERNAL_STORAGE permission grant refused");
    }

    public void accessCoarseLocationResponse(int result)
    {
        Debug.Log(result == 0
            ? "ACCESS_COARSE_LOCATION permission granted"
            : "ACCESS_COARSE_LOCATION permission grant refused");
    }

    public void onRewardedVideoLoaded(bool precache)
    {
    }

    public void onRewardedVideoFailedToLoad()
    {
    }

    public void onRewardedVideoShowFailed()
    {
    }

    public void onRewardedVideoShown()
    {
    }

    public void onRewardedVideoFinished(double amount, string name)
    {
        if (rewarededAction != null)
            rewarededAction.Invoke();
    }

    public void onRewardedVideoClosed(bool finished)
    {
    }

    public void onRewardedVideoExpired()
    {
    }

    public void onRewardedVideoClicked()
    {
    }
}
