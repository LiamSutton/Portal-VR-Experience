using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicTriggerController : MonoBehaviour
{
    public AudioClip audioClip;
    public AudioSource audioSource;

    public BoxCollider boxCollider;

    public void Awake()
    {
        audioSource.clip = audioClip;
    }
    public void OnTriggerEnter(Collider other)
    {
        audioSource.Play();

        // Prevent audio clip from being triggered again
        boxCollider.enabled = false;
    }
}
