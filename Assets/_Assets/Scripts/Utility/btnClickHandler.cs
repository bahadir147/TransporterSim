using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class btnClickHandler : MonoBehaviour, IPointerClickHandler
{
    public AudioClip clip;

    public void OnPointerClick(PointerEventData eventData)
    {
        var source = GetComponent<AudioSource>();
        if (source == null) source = this.gameObject.AddComponent<AudioSource>();

        if (clip == null)
        {
            clip = Resources.Load("Sounds/btnClick") as AudioClip;
        }

        if (clip != null)
            source.PlayOneShot(clip);
    }

}
