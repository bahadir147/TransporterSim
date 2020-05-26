using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarBodyMaterialManager : MonoBehaviour
{

    public List<MeshRenderer> Bodys;
    public List<Material> mats;

    public void Start()
    {
        ChangeMaterial();
    }

    public void ChangeMaterial()
    {
        int currentMate = PlayerPrefs.GetInt("CarMat", 0);
        Material mat = mats[currentMate];

        if (mat == null) return;

        foreach (var item in Bodys)
        {
            item.material = mat;
        }
    }
}
