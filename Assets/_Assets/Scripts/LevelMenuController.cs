using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets._Assets.Scripts.Utility;
using System;

public class LevelMenuController : MonoBehaviour
{

    private List<LevelItem> Levels;
    public GameObject LevelContent;

    public GameObject levelitemPrefab;
    // Use this for initialization

    private void Awake()
    {
        Levels = LevelManager.Instance.Levels;
    }
    void Start()
    {

        foreach (var item in Levels)
        {

            GameObject levelItem = Instantiate(levelitemPrefab, LevelContent.transform);
            levelItem.name = item.LevelName.ToString();

            item.status = LevelManager.Instance.GetLevelStatus(item.LevelName);

            if (item.LevelName == 1 && item.status == LevelStatus.locked) item.status = LevelStatus.unlock;

            LevelItemProp prop = levelItem.GetComponent<LevelItemProp>();
            if (prop != null)
                levelItem.GetComponent<LevelItemProp>().Init(item);
        }
    }
}

[Serializable]
public class LevelItem
{
    public int LevelName;
    public LevelStatus status;
}