using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level3GorevAlani : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "MissionObject")
            GetComponent<MissionState>().isComplated = true;
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "MissionObject")
            GetComponent<MissionState>().isComplated = false;
    }
}
