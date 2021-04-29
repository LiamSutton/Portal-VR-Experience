using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonController : MonoBehaviour
{
    public AudioClip buttonHitSoundEffect;
    public DoorController doorController;
    private bool isActive = false;
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Cube"))
        {
            Activate();
        }
    }

    public void Activate()
    {
        isActive = true;
        AudioSource.PlayClipAtPoint(buttonHitSoundEffect, transform.transform.position);
        doorController.TriggerHide();
    }
}
