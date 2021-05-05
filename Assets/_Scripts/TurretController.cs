using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretController : MonoBehaviour
{
    public AudioClip[] voiceLines;
    public GameObject[] positions;
    public Animator animator;

    private int currentTargetIndex = 0;
    private GameObject currentTarget;
    private float speed = 2.5f;

    private void Awake()
    {
        currentTarget = positions[0];
    }

    private void Update()
    {
        if (transform.position == currentTarget.transform.position)
        {
            PickNewTarget();
        }
        MoveToTarget();
    }
    public void PlayVoiceLine()
    {
        int idx = Random.Range(0, voiceLines.Length);
        AudioSource.PlayClipAtPoint(voiceLines[idx], transform.position);
    }

    public void Deploy()
    {
        PlayVoiceLine();
        animator.Play("Base Layer.Turret_Deploy");
    }

    public void MoveToTarget()
    {
        float step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, currentTarget.transform.position, step);
    }

    public void PickNewTarget()
    {
        currentTargetIndex++;

        if (currentTargetIndex >= positions.Length)
        {
            currentTargetIndex = 0;
            currentTarget = positions[currentTargetIndex];
            transform.position = positions[0].transform.position;
        }
        else
        {
            currentTarget = positions[currentTargetIndex];
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("TurretDeploy"))
        {
            Deploy();
        }
    }
}
