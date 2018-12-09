using Assets._Assets.Scripts.Utility;
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

    public void NextLevel()
    {
        SceneManager.LoadScene("Level" + LevelManager.Instance.currentLevel + 1);
    }

    public void GoHomeButton()
    {
        SceneManager.LoadScene(0);
    }
}
