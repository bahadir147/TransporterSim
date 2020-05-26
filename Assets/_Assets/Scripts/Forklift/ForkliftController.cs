using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Burst;
using UnityEngine;

[BurstCompile]
public class ForkliftController : MonoBehaviour
{

    public float maxLiftPos;
    public float minLiftPos;
    public GameObject LiftModel;
    private Animator liftAnim;
    private float currentLiftPos;
    public float liftMoveSpeed = 2;

    public AudioSource liftEngineSource;
    private float liftVolume = 0;

    public Transform liftRayPos;
    public float liftRayDistance = 1;

    private void Start()
    {
        liftAnim = LiftModel.GetComponent<Animator>();
        currentLiftPos = LiftModel.transform.position.y;
    }

    private void Update()
    {
        LiftModel.transform.localPosition = new Vector3(0.2010001f, LiftModel.transform.localPosition.y, 0);
    }

    private void FixedUpdate()
    {
        liftAnim.speed = liftMoveSpeed;

        RaycastHit hit;
        bool liftHitUp = false;
        if (Physics.Raycast(liftRayPos.position, transform.TransformDirection(Vector3.up) * -1, out hit, liftRayDistance))
        {
            Debug.DrawRay(liftRayPos.position, transform.TransformDirection(Vector3.up) * hit.distance * -1, Color.yellow);
            liftHitUp = true;
        }




        if (LiftModel.transform.localPosition.y >= maxLiftPos)
        {
            LiftIdle();
            currentLiftPos = maxLiftPos;
            LiftModel.transform.localPosition = new Vector3(LiftModel.transform.localPosition.x, currentLiftPos, LiftModel.transform.localPosition.z);

        }

        if (LiftModel.transform.localPosition.y <= minLiftPos)
        {
            LiftIdle();
            currentLiftPos = minLiftPos;
            LiftModel.transform.localPosition = new Vector3(LiftModel.transform.localPosition.x, currentLiftPos, LiftModel.transform.localPosition.z);

        }

        if (Input.GetKey(KeyCode.R) || InputManager.Instance.ForkliftLiftControl() == 1)
        {
            LiftUp();
        }
        else if ((Input.GetKey(KeyCode.F) && !liftHitUp) || (InputManager.Instance.ForkliftLiftControl() == -1 && !liftHitUp))
        {
            LiftDown();
        }
        else
        {
            liftVolume = Mathf.Lerp(liftVolume, 0, 0.7f);
            LiftIdle();

        }


        liftEngineSource.volume = liftVolume;
        liftVolume = Mathf.Clamp(liftVolume, 0, 1);

    }

    private void LiftIdle()
    {
        liftAnim.SetBool("Up", false);
        liftAnim.SetBool("Down", false);
        liftAnim.SetBool("Idle", true);
    }

    public void LiftUp()
    {

        currentLiftPos = LiftModel.transform.localPosition.y;
        if (currentLiftPos >= maxLiftPos) return;

        liftAnim.SetBool("Up", true);
        liftAnim.SetBool("Down", false);
        liftAnim.SetBool("Idle", false);
        liftVolume = Mathf.Lerp(liftVolume, 1, 0.7f);
        //LiftModel.transform.position = Vector3.MoveTowards(LiftModel.transform.position, new Vector3(LiftModel.transform.position.x,
        //    maxLiftPos,
        //    LiftModel.transform.position.z)
        //    , liftMoveSpeed * Time.fixedDeltaTime);

    }
    public void LiftDown()
    {
        currentLiftPos = LiftModel.transform.localPosition.y;
        if (currentLiftPos <= minLiftPos) return;

        liftAnim.SetBool("Up", false);
        liftAnim.SetBool("Down", true);
        liftAnim.SetBool("Idle", false);
        liftVolume = Mathf.Lerp(liftVolume, 1, 0.7f);
        // LiftModel.transform.position = Vector3.MoveTowards(LiftModel.transform.position, new Vector3(LiftModel.transform.position.x,
        //minLiftPos,
        //LiftModel.transform.position.z)
        //, liftMoveSpeed * Time.fixedDeltaTime);
    }


}
