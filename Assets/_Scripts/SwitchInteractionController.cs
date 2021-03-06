using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchInteractionController : MonoBehaviour
{
    public GameObject door;
    public Animator animator;
    public AudioClip buttonPressSoundEffect;
    private float buttonDelay = 0.2f;
    private DoorController doorController;

    public void Awake()
    {
        doorController = door.GetComponent<DoorController>();
    }

    public void Activate()
    {
        StartCoroutine("PlayButtonPressAnimation");
    }

    private IEnumerator PlayButtonPressAnimation()
    {
        AudioSource.PlayClipAtPoint(buttonPressSoundEffect, transform.position);
        animator.Play("Base Layer.Switch_Down");
        yield return new WaitForSeconds(buttonDelay);
        animator.Play("Base Layer.Switch_Up");
        doorController.TriggerHide();
    }
}
