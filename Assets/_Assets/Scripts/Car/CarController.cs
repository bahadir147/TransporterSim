using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    public List<AxleInfo> axleInfos;
    public float maxMotorTorque;
    public float maxSteeringAngle;
    public float brakeTorque;
    public float decelerationForce;

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
    private float currentSpeed = 0;
    private float pitch = 0;
    public AudioSource motorAudioSource;

    [Space]
    public GameObject backLights;
    public AudioSource backupAudioSource;


    [Space]
    public Transform SteeringWheel;

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
        Vector3 position;
        Quaternion rotation;
        axleInfo.leftWheelCollider.GetWorldPose(out position, out rotation);
        axleInfo.leftWheelMesh.transform.position = position;
        axleInfo.leftWheelMesh.transform.rotation = rotation;
        axleInfo.rightWheelCollider.GetWorldPose(out position, out rotation);
        axleInfo.rightWheelMesh.transform.position = position;
        axleInfo.rightWheelMesh.transform.rotation = rotation;
    }
    void FixedUpdate()
    {
        UIManager.Instance.ChangeSpeedText(currentSpeed);
        currentSpeed = transform.GetComponent<Rigidbody>().velocity.magnitude * 3.6f;
        pitch = (currentSpeed / topSpeed) + 0.85f;

        motorAudioSource.pitch = pitch;

        if (Input.GetKeyDown(KeyCode.G)) ChangeGearStatus();

        float motor = maxMotorTorque * InputManager.Instance.GetVerticalAxis();
        float steering = maxSteeringAngle * InputManager.Instance.GetSteeringValue() * -1;

        SteeringWheel.localEulerAngles = Vector3.back * steering*2;


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
            if (Input.GetKey(KeyCode.Space) && axleInfos[i].motor)
            {
                Brake(axleInfos[i]);
            }

            ApplyLocalPositionToVisuals(axleInfos[i]);
        }
    }
    private void Acceleration(AxleInfo axleInfo, float motor)
    {
        if (motor > 0f &&
                currentSpeed <= topSpeed)
        {
            axleInfo.leftWheelCollider.brakeTorque = 0;
            axleInfo.rightWheelCollider.brakeTorque = 0;
            axleInfo.leftWheelCollider.motorTorque = motor * (int)gearStatus;
            axleInfo.rightWheelCollider.motorTorque = motor * (int)gearStatus;
        }
        else
        {
            Deceleration(axleInfo);
        }
    }
    private void Deceleration(AxleInfo axleInfo)
    {
        axleInfo.leftWheelCollider.brakeTorque = decelerationForce;
        axleInfo.rightWheelCollider.brakeTorque = decelerationForce;
    }
    private void Steering(AxleInfo axleInfo, float steering)
    {
        axleInfo.leftWheelCollider.steerAngle = steering;
        axleInfo.rightWheelCollider.steerAngle = steering;
    }
    private void Brake(AxleInfo axleInfo)
    {
        axleInfo.leftWheelCollider.brakeTorque = brakeTorque;
        axleInfo.rightWheelCollider.brakeTorque = brakeTorque;
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