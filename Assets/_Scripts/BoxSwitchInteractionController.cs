using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxSwitchInteractionController : MonoBehaviour
{
    public GameObject boxDropper;
    public Animator animator;
    public AudioClip buttonPressSoundEffect;
    private float buttonDelay = 0.2f;
    private BoxDropperController BoxDropperController;

    public void Awake()
    {
        BoxDropperController = boxDropper.GetComponent<BoxDropperController>();
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
        BoxDropperController.DropBox();
    }
}
