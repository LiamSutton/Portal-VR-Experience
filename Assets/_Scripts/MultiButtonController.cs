using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiButtonController : MonoBehaviour
{
    public MultiButtonDoorController parent;
    public AudioClip buttonHitSoundEffect;
    public bool isActive = false;

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Cube"))
        {
            Activate();
        }
    }
    private void Activate()
    {
        isActive = true;
        AudioSource.PlayClipAtPoint(buttonHitSoundEffect, transform.position);
        parent.ChildActivated(this.gameObject);
    }
}
