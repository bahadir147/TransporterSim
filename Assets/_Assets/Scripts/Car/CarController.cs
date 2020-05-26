using System.Collections;
using System.Collections.Generic;
using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Jobs;

[BurstCompile]
public class CarController : MonoBehaviour
{
    public List<AxleInfo> axleInfos;
    public float maxMotorTorque;
    public float lowestSteerAtSpeed = 50;
    public float lowSpeedSteerAngel = 25;
    public float highSpeedSteerAngel = 1;
    public float brakeTorque;
    public float decelerationForce;

    //private float currentMotorTorque;
    public float motorTorqueHizlanma = 0.5f;
    public float motorTorqueYavaslama = 2;
    [Space]
    public Transform centerOfMass;
    Rigidbody rg;

    /// <summary>
    /// 1 İleri
    /// -1 Geri
    /// </summary>
    public GearStatus gearStatus = (GearStatus)1;


    [Space]
    public float topSpeed = 30; // km per hour
    public float currentSpeed = 0;
    private float pitch = 0;
    public AudioSource motorAudioSource;

    [Space]
    public GameObject backLights;
    public AudioSource backupAudioSource;
    public GameObject brakeLights;


    [Space]
    public Transform SteeringWheel;
    public float currentSteerAngle;

    public bool useJob = true;

    private void Start()
    {
        rg = GetComponent<Rigidbody>();
        if (rg != null)
        {
            //rg.centerOfMass = centerOfMass.position;
        }
    }

    public void ApplyLocalPositionToVisuals(AxleInfo axleInfo)
    {
        if (!useJob)
        {
            Vector3 position;
            Quaternion rotation;
            axleInfo.leftWheelCollider.GetWorldPose(out position, out rotation);
            axleInfo.leftWheelMesh.transform.position = position;
            axleInfo.leftWheelMesh.transform.rotation = rotation;
            axleInfo.rightWheelCollider.GetWorldPose(out position, out rotation);
            axleInfo.rightWheelMesh.transform.position = position;
            axleInfo.rightWheelMesh.transform.rotation = rotation;
        }
        else
        {
            Transform[] _transforms = new Transform[2];

            _transforms[0] = axleInfo.leftWheelMesh.transform;
            _transforms[1] = axleInfo.rightWheelMesh.transform;
            var transAccessArray = new TransformAccessArray(_transforms);


            Vector3[] pos = new Vector3[2];
            Quaternion[] rot = new Quaternion[2];

            Vector3 position;
            Quaternion rotation;
            axleInfo.leftWheelCollider.GetWorldPose(out position, out rotation);
            pos[0] = position;
            rot[0] = rotation;

            axleInfo.rightWheelCollider.GetWorldPose(out position, out rotation);
            pos[1] = position;
            rot[1] = rotation;


            var posArray = new NativeArray<Vector3>(pos, Allocator.TempJob);
            var rotateArray = new NativeArray<Quaternion>(rot, Allocator.TempJob);

            ApplyLocalPositionJob job0 = new ApplyLocalPositionJob()
            {
                position = posArray,
                rotation = rotateArray
            };

            JobHandle handle0 = job0.Schedule(transAccessArray);
            transAccessArray.Dispose();
            rotateArray.Dispose();
            posArray.Dispose();
        }
    }


    void FixedUpdate()
    {
        UIManager.Instance.ChangeSpeedText(currentSpeed);
        currentSpeed = rg.velocity.magnitude * 3.6f;
        pitch = (currentSpeed / (topSpeed + 10)) + 0.85f;
        motorAudioSource.pitch = pitch;

        if (Input.GetKeyDown(KeyCode.G)) ChangeGearStatus();

        float motor = maxMotorTorque * InputManager.Instance.GetVerticalAxis();
        // float steering = maxSteeringAngle * InputManager.Instance.GetSteeringValue() * -1;
        float steering = InputManager.Instance.GetSteeringValue() * -1;

        SteeringWheel.localEulerAngles = Vector3.back * steering * 2;


        for (int i = 0; i < axleInfos.Count; i++)
        {
            if (axleInfos[i].steering)
            {
                Steering(axleInfos[i], steering);
            }
            if (axleInfos[i].motor)
            {
                Acceleration(axleInfos[i], motor);
            }
            if ((Input.GetKey(KeyCode.Space) || motor < 0) && axleInfos[i].motor)
            {
                Brake(axleInfos[i]);
            }

            ApplyLocalPositionToVisuals(axleInfos[i]);
        }
    }

    private void Acceleration(AxleInfo axleInfo, float motor)
    {
        brakeLights.SetActive(false);
        if (motor > 0f &&
                currentSpeed <= topSpeed)
        {

            axleInfo.leftWheelCollider.brakeTorque = 0;
            axleInfo.rightWheelCollider.brakeTorque = 0;
            axleInfo.leftWheelCollider.motorTorque = motor * (int)gearStatus;
            axleInfo.rightWheelCollider.motorTorque = motor * (int)gearStatus;
            brakeLights.SetActive(false);
        }
        else
        {
            Deceleration(axleInfo);
            //brakeLights.SetActive(true);
        }
    }
    private void Deceleration(AxleInfo axleInfo)
    {
        axleInfo.leftWheelCollider.brakeTorque = decelerationForce;
        axleInfo.rightWheelCollider.brakeTorque = decelerationForce;

        axleInfo.leftWheelCollider.motorTorque = 0;
        axleInfo.rightWheelCollider.motorTorque = 0;
    }
    private void Steering(AxleInfo axleInfo, float steering)
    {
        var speedFactor = (rg.velocity.magnitude * 1.1f) / lowestSteerAtSpeed;
        currentSteerAngle = Mathf.Lerp(lowSpeedSteerAngel, highSpeedSteerAngel, speedFactor);
        currentSteerAngle *= steering;
        axleInfo.leftWheelCollider.steerAngle = currentSteerAngle;
        axleInfo.rightWheelCollider.steerAngle = currentSteerAngle;
    }
    private void Brake(AxleInfo axleInfo)
    {
        axleInfo.leftWheelCollider.brakeTorque = brakeTorque;
        axleInfo.rightWheelCollider.brakeTorque = brakeTorque;
        brakeLights.SetActive(true);
    }
    internal void ChangeGearStatus()
    {
        if (gearStatus == GearStatus.Forward)
        {
            gearStatus = GearStatus.Back;
            backLights.SetActive(true);
            backupAudioSource.Play();
        }
        else
        {
            gearStatus = GearStatus.Forward;
            backLights.SetActive(false);
            backupAudioSource.Stop();
        }

        UIManager.Instance.GearChange(gearStatus);
    }
}


public enum GearStatus
{
    Forward = 1,
    Back = -1
}


[BurstCompile]
public struct ApplyLocalPositionJob : IJobParallelForTransform
{
    public NativeArray<Vector3> position;
    public NativeArray<Quaternion> rotation;
    public void Execute(int index, TransformAccess transform)
    {
        transform.position = position[index];
        transform.rotation = rotation[index];
    }

}