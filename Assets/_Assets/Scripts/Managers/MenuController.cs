using AppodealAds.Unity.Api;
using AppodealAds.Unity.Common;
using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.Burst;
using UnityEngine;
[BurstCompile]
public class MenuController : MonoBehaviour
{
    public Animator CompanyInputAnim;
    public TMP_InputField CompanyInput;
    public TextMeshProUGUI CompanyInfoText;
    public TextMeshProUGUI CompanyMoneyText;



    private string CompanyName;
    private void Start()
    {
        CompanyName = PlayerPrefs.GetString("CompanyName", "");
        if (string.IsNullOrEmpty(CompanyName))
        {
            CompanyInputAnim.SetTrigger("isOpen");
        }
        else
            CompanyInfoText.text = CompanyName;

        CompanyMoneyText.text = PlayerPrefs.GetFloat("Money", 0).ToString();
    }

    public void EnterCompanyName()
    {
        string value = CompanyInput.text;
        if (string.IsNullOrEmpty(value.Trim())) return;
        PlayerPrefs.SetString("CompanyName", value);
        CompanyInputAnim.SetTrigger("isClose");
        CompanyInfoText.text = value;
    }


    public void Exit()
    {
        Application.Quit();
    }

    public void GetRandomName()
    {
        CompanyInput.text = NameList.getRandomName();
        CompanyInput.ForceLabelUpdate();
    }

    public void AddMoney()
    {
        try
        {
            ReklamManager.instance.ShowRewareded(onRewardedVideoFinished);
        }
        catch (Exception ex)
        {
            Debug.LogError(ex.Message);
            LevelManager.Instance.SaveMoney(2000);

        }

    }

    public void onRewardedVideoFinished()
    {
        print("Appodeal. Video reward finishh...");
        LevelManager.Instance.SaveMoney(2000);
        CompanyMoneyText.text = PlayerPrefs.GetFloat("Money", 0).ToString();
    }
}


public static class NameList
{
    public static string getRandomName()
    {
        var names = Resources.Load("names");
        string values = names.ToString();
        values = values.Replace("[", string.Empty);
        values = values.Replace("]", string.Empty);
        values = values.Replace("\"", string.Empty);
        string[] array = values.Split(',');
        return array[UnityEngine.Random.Range(0, array.Length)].Trim();
    }
}