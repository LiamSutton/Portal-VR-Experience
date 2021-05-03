using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretController : MonoBehaviour
{
    public AudioClip[] voiceLines;
    public Animator animator;
    public float timer = 3.0f;
    public bool played = false;

    // removed the playing logic for now as I will add triggers later on

    private void Awake() => StartCoroutine("Deploy");
    public void PlayVoiceLine()
    {
        int idx = Random.Range(0, voiceLines.Length);
        AudioSource.PlayClipAtPoint(voiceLines[idx], transform.position);
    }

    public IEnumerator Deploy()
    {
        played = true;
        PlayVoiceLine();
        animator.Play("Base Layer.Turret_Deploy");
        yield return new WaitForSeconds(2f);
        played = false;
        timer = 3.0f;
    }
}
