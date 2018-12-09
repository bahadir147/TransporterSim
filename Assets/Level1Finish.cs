using Assets._Assets.Scripts.Utility;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level1Finish : MonoBehaviour
{
    public float LevelMaxTime;
    public float LevelMoney;
    private LevelStatus status;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
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
}
