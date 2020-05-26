using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrashIconInit : MonoBehaviour
{

    void Start()
    {
        transform.LookAt(Camera.main.transform);
        Invoke("Kill", 2);
    }

    void Kill()
    {
        Destroy(this.gameObject);
    }

}
