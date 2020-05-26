using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{


    public GameObject[] Vcameras;

    private int currentIndex;
    private GameObject currentCamera;

    public GameObject FreeHandCam;
    private Transform playerTransform;
    // Use this for initialization
    void Start()
    {
        var player = GameObject.FindGameObjectWithTag("Player");
        if (player != null)
        {
            playerTransform = player.transform;

            foreach (CinemachineVirtualCamera item in Resources.FindObjectsOfTypeAll(typeof(CinemachineVirtualCamera)))
            {
                item.GetComponent<CinemachineVirtualCamera>().Follow = playerTransform;
                item.GetComponent<CinemachineVirtualCamera>().LookAt = playerTransform;
            }
        }

        if (Vcameras.Length <= 0) return;

        if (currentCamera == null)
            currentCamera = Vcameras[0];

        currentIndex = 0;
        ClearOthersCamera();


    }


    public void ChangeCamera()
    {
        currentIndex++;
        if (currentIndex >= Vcameras.Length)
        {
            currentIndex = 0;
        }

        currentCamera = Vcameras[currentIndex];
        ClearOthersCamera();
    }

    private void ClearOthersCamera()
    {
        foreach (var item in Vcameras)
        {
            if (item == null) continue;

            if (item == currentCamera)
            {
                item.SetActive(true);
            }
            else item.SetActive(false);
        }
    }


    public void ChangeFreeCamera()
    {
        currentCamera = FreeHandCam;
        currentCamera.SetActive(true);
        ClearOthersCamera();
    }
}
