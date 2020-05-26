using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseController : MonoBehaviour
{


    public void GoHomeButton()
    {
        CustomSceneManager.Instance.LoadScene("Menu");
    }

    public void RefreshLevel()
    {
        CustomSceneManager.Instance.LoadScene("Level" + (LevelManager.Instance.currentLevel));
    }
}
