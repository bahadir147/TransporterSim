using Assets._Assets.Scripts.Utility;
using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    #region SINGLETON PATTERN
    static LevelManager _instance;
    public static LevelManager Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = GameObject.FindObjectOfType<LevelManager>();
            }

            return _instance;
        }
    }
    #endregion

    public List<LevelItem> Levels;


    [SerializeField]
    public int currentLevel;


    public float currentTimer;
    private Coroutine coroutine;

    private TextMeshProUGUI timerText;

    void Awake()
    {

        if (_instance != null && _instance != this)
        {
            Destroy(this.gameObject);
            return;
        }

        _instance = this;
        DontDestroyOnLoad(this.gameObject);
    }

    public LevelStatus GetLevelStatus(int level)
    {
        return (LevelStatus)PlayerPrefs.GetInt("Level" + level, -1);
    }

    public void SaveLevel(int level, LevelStatus status)
    {
        PlayerPrefs.SetInt("Level" + level, (int)status);
    }

    public void SaveMoney(float money)
    {
        PlayerPrefs.SetFloat("Money", PlayerPrefs.GetFloat("Money", 0) + money);
    }

    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        if (coroutine != null)
            StopCoroutine(coroutine);

        try
        {
            currentTimer = 0;
            currentLevel = int.Parse(scene.name.Substring(5));
            coroutine = StartCoroutine(LevelMethod());
            var TimerObj = GameObject.Find("TimerText");
            if (TimerObj != null)
                timerText = TimerObj.GetComponent<TextMeshProUGUI>();
        }
        catch (System.Exception)
        {
            currentLevel = -1;
        }
    }

    IEnumerator LevelMethod()
    {
        while (true)
        {
            currentTimer += Time.deltaTime;

            if (timerText != null)
                timerText.text = Mathf.Floor((currentTimer / 60)).ToString("00") + ":" + (currentTimer % 60).ToString("00");
            yield return null;
        }
    }

    public void LevelFinish(LevelStatus status, float money)
    {
        SaveLevel(currentLevel, status);
        SaveMoney(money);

        if (coroutine != null)
            StopCoroutine(coroutine);

        Resources.FindObjectsOfTypeAll<LevelFinishCanvas>()[0].OpenFinishPanel(status, money);

    }

    void OnEnable()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }
    void OnDisable()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }
}

