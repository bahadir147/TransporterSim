using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Experimental.Rendering.LightweightPipeline;
using UnityEngine.UI;

public class MenuSettingsManager : MonoBehaviour
{

    private float currentVolume = 0;
    private int currentQuality = 5;
    private bool currentShadows = true;
    private bool currentvSync = true;

    public Slider volumeSlider;
    public TMP_Dropdown qualityDropdown;
    public Toggle shadowsToggle;
    public Toggle vsyncToggle;

    public LightweightPipelineAsset pipe;

    private void Awake()
    {
        currentVolume = PlayerPrefs.GetFloat("GeneralSound", 1);
        AudioListener.volume = currentVolume;
        volumeSlider.value = currentVolume;

        currentQuality = QualitySettings.GetQualityLevel();
        qualityDropdown.value = currentQuality;
        qualityDropdown.RefreshShownValue();


        currentvSync = PlayerPrefs.GetInt("GeneralvSync", 1) > 0 ? true : false;
        vsyncToggle.isOn = currentvSync;
        if (currentvSync)
        {
            QualitySettings.vSyncCount = 2;
        }
        else
        {
            QualitySettings.vSyncCount = 0;
        }



        currentShadows = PlayerPrefs.GetInt("GeneralShadows", 1) > 0 ? true : false;
        shadowsToggle.isOn = currentShadows;
        if (currentShadows)
        {
            pipe.supportsDirectionalShadows = true;
        }
        else
        {
            pipe.supportsDirectionalShadows = false;
        }
    }

    public void SetVolumeValue(float value)
    {
        AudioListener.volume = value;
        PlayerPrefs.SetFloat("GeneralSound", value);
        currentVolume = value;
    }

    public void SetQualityValue(int value)
    {
        currentQuality = value;
        PlayerPrefs.SetInt("GeneralQuality", value);
        QualitySettings.SetQualityLevel(currentQuality);
    }

    public void SetShadow(bool isValue)
    {
        currentShadows = isValue;
        PlayerPrefs.SetInt("GeneralShadows", currentShadows ? 1 : 0);
        shadowsToggle.isOn = currentShadows;
        if (isValue)
        {
            pipe.supportsDirectionalShadows = true;
        }
        else
        {
            pipe.supportsDirectionalShadows = false;
        }
    }

    public void SetvSync(bool isValue)
    {
        currentvSync = isValue;
        PlayerPrefs.SetInt("GeneralvSync", currentvSync ? 1 : 0);
        if (currentvSync)
        {
            QualitySettings.vSyncCount = 2;
        }
        else
        {
            QualitySettings.vSyncCount = 0;
        }
    }
}
