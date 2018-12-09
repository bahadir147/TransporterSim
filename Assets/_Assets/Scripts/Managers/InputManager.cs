using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{

    #region SINGLETON PATTERN
    static InputManager _instance;
    public static InputManager Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = GameObject.FindObjectOfType<InputManager>();
            }

            return _instance;
        }
    }
    #endregion


    private float _VerticalAxis = 0;
    private bool brake;
    private bool gas = false;



    private SteeringWheel steeringWheel;

    private ForkliftController forklift;
    private int forkliftpos = 0;


    private void Update()
    {
        GasControl();
        ForkliftLiftControl();
    }

    public int ForkliftLiftControl()
    {
        if (forklift == null) return 0;

        if (forkliftpos == 1)
        {
            return 1;
        }
        else if (forkliftpos == -1)
        {
            return -1;
        }
        else return 0;
    }

    private void Start()
    {
        steeringWheel = GetComponent<SteeringWheel>();
        forklift = FindObjectOfType<ForkliftController>();
    }
    public void ChangeGear()
    {
        CarController currentCar = FindObjectOfType<CarController>();
        if (currentCar == null) return;
        currentCar.ChangeGearStatus();
    }

    public float GetSteeringValue()
    {
        if (steeringWheel == null) return 0;
        if (Mathf.Abs(Input.GetAxis("Horizontal")) > 0) return Input.GetAxis("Horizontal");
        return steeringWheel.GetClampedValue();
    }

    public void GasChange(bool value)
    {
        gas = value;
    }
    public void BrakeCHange(bool value)
    {
        brake = value;
    }
    public float GetVerticalAxis()
    {
        if (Mathf.Abs(Input.GetAxis("Vertical")) > 0) return Input.GetAxis("Vertical");
        return _VerticalAxis;
    }
    private void GasControl()
    {
        if (gas)
        {
            _VerticalAxis += Time.deltaTime;
        }
        else if (brake)
        {
            _VerticalAxis -= Time.deltaTime;
        }
        else
        {
            _VerticalAxis = 0;
        }

        _VerticalAxis = Mathf.Clamp(_VerticalAxis, -1, 1);
    }


    public void ForliftLifChange(int pos)
    {
        forkliftpos = pos;
    }



}
