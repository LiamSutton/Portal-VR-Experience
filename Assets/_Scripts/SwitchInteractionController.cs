using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchInteractionController : MonoBehaviour
{
    public GameObject door;
    private DoorController doorController;

    public void Awake()
    {
        doorController = door.GetComponent<DoorController>();
    }

    public void Activate()
    {
        doorController.TriggerHide();
    }
}
