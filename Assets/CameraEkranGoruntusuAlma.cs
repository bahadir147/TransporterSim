using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraEkranGoruntusuAlma : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }
    int i = 0;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F12))
        {
            var guid = DateTime.Now.Millisecond;
            i++;
            ScreenCapture.CaptureScreenshot(@"C:\Users\Bahadir\Desktop\ProjectXTrapsort\ScreenShoots\" + i.ToString() + guid.ToString() + "Loading.png", 2);

        }
    }
}
