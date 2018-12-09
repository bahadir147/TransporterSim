using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuColorManager : MonoBehaviour
{

    public void ChangeColor(GameObject g)
    {
        if (g == null)
        {
            return;
        }

        PlayerPrefs.SetInt("CarMat", int.Parse(g.name));

        CarBodyMaterialManager manager = FindObjectOfType<CarBodyMaterialManager>();
        if (manager == null) return;

        manager.ChangeMaterial();
    }
}
