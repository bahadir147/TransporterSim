using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Burst;
using UnityEngine;
using UnityEngine.SceneManagement;

[BurstCompile]
public class CustomSceneManager : MonoBehaviour
{
    #region SINGLETON PATTERN
    static CustomSceneManager _instance;
    public static CustomSceneManager Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = GameObject.FindObjectOfType<CustomSceneManager>();
            }

            return _instance;
        }
    }
    #endregion

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


    AsyncOperation asyncLoad;

    public Scene nextScene;
    public Scene currentScene;

    private void Start()
    {

        SceneManager.sceneLoaded += SceneManager_sceneLoaded;
        StartCoroutine(LoadYourAsyncScene("LoadScreen"));
        asyncLoad.allowSceneActivation = false;
    }

    private void SceneManager_sceneLoaded(Scene arg0, LoadSceneMode arg1)
    {
        if (arg0.name == "LoadScreen") return;

        asyncLoad.allowSceneActivation = false;
        StartCoroutine(LoadYourAsyncScene("LoadScreen"));

        currentScene = SceneManager.GetActiveScene();
    }

    public void LoadScene(int index)
    {
        LoadScene(SceneManager.GetSceneAt(index).name);
    }


    public void LoadScene(string index)
    {
        ReklamManager.instance.ShowInterstitial();

        asyncLoad.allowSceneActivation = true;
        nextScene = SceneManager.GetSceneByName(index);
        StartCoroutine(LoadYourAsyncScene(index, true));
    }

    IEnumerator LoadYourAsyncScene(string sceneName, bool autoChangeScreen = false)
    {
        asyncLoad = SceneManager.LoadSceneAsync(sceneName);
        asyncLoad.allowSceneActivation = false;
        yield return new WaitForSeconds(1);
        asyncLoad.allowSceneActivation = autoChangeScreen;


        while (!asyncLoad.isDone)
        {
            yield return null;
        }
    }
}
