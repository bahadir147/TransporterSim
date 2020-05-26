using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForkliftCollisionDetector : MonoBehaviour
{
    public string tagName = "Barriers";

    private Vector3 lastHitPos;


    public AudioClip crashClip;
    private AudioSource audioSource;

    public GameObject crashObj;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        var parent = other.gameObject.transform.parent;

        if (other.gameObject.tag == tagName || (parent != null && parent.tag == tagName))
        {
            var currentContact = other.ClosestPoint(this.transform.position);
            if (other.transform != transform && lastHitPos.x != currentContact.x &&
                lastHitPos.y != currentContact.y &&
                lastHitPos.z != currentContact.z)
            {

                if (LevelManager.Instance != null)
                    LevelManager.Instance.CrashForklift();

                audioSource.clip = crashClip;
                audioSource.Play();

                Instantiate(crashObj, other.ClosestPoint(this.transform.position), Quaternion.identity);
                Debug.Log("Kaza");
            }
        }

        lastHitPos = other.ClosestPoint(this.transform.position);

    }
}
