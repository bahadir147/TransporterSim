using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelSlipping : MonoBehaviour
{

    public WheelCollider[] wheels;


    // Update is called once per frame
    void Update()
    {

        foreach (var item in wheels)
        {
            WheelHit hit;
            if (item.GetGroundHit(out hit))
            {
                if (hit.forwardSlip < 0.5f)

                    Debug.Log(item.name + " " + hit.forwardSlip);
            }
        }
    }
}
