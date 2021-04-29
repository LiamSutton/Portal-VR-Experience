using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FunnelCubeController : MonoBehaviour
{
    public GameObject[] positions;
    public GameObject currentTarget;

    private int positionsLength;
    private int currentTargetIndex = 0;
    private float speed = 2.5f;

    public void Awake()
    {
        currentTarget = positions[0];
        positionsLength = positions.Length;
    }

    public void Update()
    {
        if (transform.position == currentTarget.transform.position)
        {
            // pick a new target
            PickNewTarget();
        }
        MoveToTarget();
    }

    public void MoveToTarget()
    {
        float step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, currentTarget.transform.position, step);
    }

    private void PickNewTarget()
    {
        currentTargetIndex++; // increment target idx

        // Perform bounds check
        if (currentTargetIndex >= positionsLength)
        {
            // Move cube to beggining of funnel
            currentTargetIndex = 0;
            currentTarget = positions[currentTargetIndex];
            transform.position = positions[0].transform.position;
        }
        else
        {
            currentTarget = positions[currentTargetIndex];
        }
    }
}
