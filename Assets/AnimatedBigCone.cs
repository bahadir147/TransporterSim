using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG;
using DG.Tweening;

public class AnimatedBigCone : MonoBehaviour
{
public    bool status = true;
    public Transform hareketliKisim;
    public float closedY = -1.02f;

    public float hareketSuresi = 5;

    private BoxCollider boxCollider;
    void Start()
    {
        boxCollider = GetComponent<BoxCollider>();

        if (!status)
        {
            hareketliKisim.DOLocalMoveY(closedY, 1);
        }
        boxCollider.enabled = status;

        StartCoroutine(HareketEt());
    }

    IEnumerator HareketEt()
    {
        yield return new WaitForSeconds(hareketSuresi);

        if (status)
            hareketliKisim.DOLocalMoveY(closedY, 1);
        else
            hareketliKisim.DOLocalMoveY(0, 1);

        status = !status;
        boxCollider.enabled = status;
        

        StartCoroutine(HareketEt());
    }
}
