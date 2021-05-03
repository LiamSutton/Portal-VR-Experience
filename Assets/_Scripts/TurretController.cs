using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretController : MonoBehaviour
{
    public AudioClip[] voiceLines;
    public Animator animator;

    public void PlayVoiceLine()
    {
        int idx = Random.Range(0, voiceLines.Length);
        AudioSource.PlayClipAtPoint(voiceLines[idx], transform.position);
    }
}
