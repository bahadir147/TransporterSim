using Assets._Assets.Scripts.Utility;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelFinish : MonoBehaviour
{
    public float LevelMaxTime;
    public float LevelMoney;
    private LevelStatus status;

    private bool isFinish = false;

    private void OnTriggerStay(Collider other)
    {
        if (!isFinish)
        {
            if (other.tag == "Player")
            {
                var states = FindObjectsOfType<MissionState>();

                foreach (var item in states)
                {
                    if (!item.isComplated)
                        return;
                }

                Invoke("FinishLevel", 2);
                isFinish = true;
            }
        }
    }

    private void FinishLevel()
    {

        FindObjectOfType<CameraController>().ChangeFreeCamera();
        FindObjectOfType<CarController>().enabled = false;
        FindObjectOfType<CarController>().gameObject.GetComponent<Rigidbody>().isKinematic = true;
        var sounds = FindObjectsOfType<AudioSource>();
        foreach (var item in sounds)
        {
            item.volume = 0;
        }

        if (LevelManager.Instance.currentTimer < LevelMaxTime)
            status = LevelStatus.Perfect;
        else if (LevelManager.Instance.currentTimer <= LevelMaxTime + (LevelMaxTime / 2))
            status = LevelStatus.Good;
        else
            status = LevelStatus.NotBad;

        LevelManager.Instance.LevelFinish(status, LevelMoney);
    }
}
