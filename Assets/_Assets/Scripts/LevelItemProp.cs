using Assets._Assets.Scripts.Utility;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelItemProp : MonoBehaviour
{

    public TextMeshProUGUI levelNameText;
    public GameObject playText;
    public GameObject LockObj;

    public Button PlayButton;

    public GameObject[] starts;

    private LevelItem _item;

    public void Init(LevelItem item)
    {

        if (item == null)
        {
            Destroy(this.gameObject);
        }

        this._item = item;
        levelNameText.text = item.LevelName.ToString();

        if (item.status == LevelStatus.locked)
        {
            LockObj.SetActive(true);
            playText.SetActive(false);
            starts[0].transform.parent.parent.gameObject.SetActive(false);
        }
        else
        {
            LockObj.SetActive(false);
            playText.SetActive(true);

            if (item.status == LevelStatus.Perfect)
            {
                starts[2].SetActive(true);
                starts[1].SetActive(true);
                starts[0].SetActive(true);
            }
            else if (item.status == LevelStatus.Good)
            {
                starts[1].SetActive(true);
                starts[0].SetActive(true);
            }
            else if (item.status == LevelStatus.NotBad)
            {
                starts[0].SetActive(true);
            }
        }

        PlayButton.onClick.AddListener(() => PlayLevel());
    }

    public void PlayLevel()
    {
        if (_item.status != LevelStatus.locked)
            SceneManager.LoadScene("Level" + _item.LevelName);
    }


}
