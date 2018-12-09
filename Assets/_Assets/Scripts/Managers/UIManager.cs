using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{


    #region SINGLETON PATTERN
    static UIManager _instance;
    public static UIManager Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = GameObject.FindObjectOfType<UIManager>();
            }

            return _instance;
        }
    }
    #endregion

    public TextMeshProUGUI speedText;
    public Animator gearUIAnim;

    public void ChangeSpeedText(float speed)
    {
        if (speedText == null) return;
        speedText.text = string.Format("{0:00}mph", speed);
    }

    public void GearChange(GearStatus currentGear)
    {
        if (gearUIAnim == null) return;
        gearUIAnim.SetInteger("Gear", (int)currentGear);
    }
}
