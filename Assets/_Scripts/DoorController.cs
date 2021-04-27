using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    public GameObject LeftDoor;
    public GameObject RightDoor;
    public Transform LeftDoorEndPoint;
    public Transform RightDoorEndPoint;
    private bool shouldHide = false;
    public float doorMoveSpeed;

    private void Update()
    {
        if (shouldHide)
        {
            OpenDoor();
        }
    }

    private void OpenDoor()
    {
        float step = doorMoveSpeed * Time.deltaTime;

        LeftDoor.transform.position = Vector3.MoveTowards(LeftDoor.transform.position, LeftDoorEndPoint.transform.position, step);
        RightDoor.transform.position = Vector3.MoveTowards(RightDoor.transform.position, RightDoorEndPoint.transform.position, step);
    }

    public void TriggerHide()
    {
        shouldHide = true;
    }
}
