using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarBodyMaterialManager : MonoBehaviour
{

    public List<MeshRenderer> Bodys;


    public void Start()
    {
        ChangeMaterial();
    }

    public void ChangeMaterial()
    {
        int currentMate = PlayerPrefs.GetInt("CarMat", 0);
        Material mat = Resources.Load("ForkliftMats/Mat" + currentMate) as Material;

        if (mat == null) return;

        foreach (var item in Bodys)
        {
            item.material = mat;
        }
    }
}
