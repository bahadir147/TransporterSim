using AppodealAds.Unity.Api;
using AppodealAds.Unity.Common;
using Assets._Assets.Scripts.Utility;
using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelFinishCanvas : MonoBehaviour
{

    private Animator anim;

    public GameObject notbad;
    public GameObject good;
    public GameObject perfect;

    public TextMeshProUGUI MoneyText;
    private bool crash = false;
    // Use this for initialization

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    public void OpenFinishPanel(LevelStatus status, float money)
    {
        Camera.main.GetComponent<AudioListener>().enabled = false;

        if (status == LevelStatus.Perfect)
        {
            anim.SetTrigger("perfect");
        }
        else if (status == LevelStatus.Good)
        {
            anim.SetTrigger("good");
        }
        else if (status == LevelStatus.NotBad)
        {
            anim.SetTrigger("notbad");
        }

        MoneyText.text = "$" + money;

    }

    public void OpenFinishPanel(bool crash)
    {
        foreach (var item in FindObjectsOfType<AudioSource>())
        {
            item.volume = 0;
        }

        Time.timeScale = 0;
        Camera.main.GetComponent<AudioListener>().enabled = false;
        anim.SetTrigger("bad");
        MoneyText.text = "LEVEL FAILED";
        this.crash = crash;
    }

    public void NextLevel()
    {
        Time.timeScale = 1;
        if (crash == true)
        {
            if (!ReklamManager.instance.ShowRewareded(onRewardedVideoFinished))
            {
                Time.timeScale = 0;
            }
        }
        else
            CustomSceneManager.Instance.LoadScene("Level" + (LevelManager.Instance.currentLevel + 1));
    }


    public void GoHomeButton()
    {
        Time.timeScale = 1;
        CustomSceneManager.Instance.LoadScene("Menu");
    }

    public void RefreshLevel()
    {
        Time.timeScale = 1;
        CustomSceneManager.Instance.LoadScene("Level" + (LevelManager.Instance.currentLevel));
    }


    public void onRewardedVideoFinished()
    {
        crash = false;
        CustomSceneManager.Instance.LoadScene("Level" + (LevelManager.Instance.currentLevel + 1));
    }

}
