
using AppodealAds.Unity.Api;
using AppodealAds.Unity.Common;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuColorManager : MonoBehaviour
{

    private GameObject setObj;

    CarBodyMaterialManager manager;

    private void Awake()
    {
        manager = FindObjectOfType<CarBodyMaterialManager>();
    }

    public void ChangeColor(GameObject g)
    {
        try
        {
            if (g == null)
            {
                return;
            }
            setObj = g;

#if UNITY_EDITOR
            onRewardedVideoFinished();
#endif

            if (int.Parse(g.name) != 0)
                ReklamManager.instance.ShowRewareded(onRewardedVideoFinished);

            else onRewardedVideoFinished();

        }
        catch (Exception ex)
        {
            Debug.LogError(ex.Message);
            onRewardedVideoFinished();
        }
    }

    public void onRewardedVideoFinished()
    {
        print("Rewarede video fnished!!!!");
        PlayerPrefs.SetInt("CarMat", int.Parse(setObj.name));

        if (manager == null) return;

        manager.ChangeMaterial();
    }
}
