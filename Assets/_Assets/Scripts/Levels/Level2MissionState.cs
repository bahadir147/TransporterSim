using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level2MissionState : MonoBehaviour
{

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "MissionObject")
        {
            GetComponent<MissionState>().isComplated = true;
        }
    }
}
