using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiButtonDoorController : MonoBehaviour
{
    public DoorController doorController;
    public MultiButtonController[] buttonControllers;


    // Recieve a report from a child stating they have a cube on them
    public void ChildActivated(GameObject child)
    {
        bool shouldOpenDoor = CheckAllChildren();

        if (shouldOpenDoor)
        {
            Activate();
        }
    }

    // Check if all children have buttons on them
    private bool CheckAllChildren()
    {
        for (int i = 0; i < buttonControllers.Length; i++)
        {
            if (!buttonControllers[i].isActive)
            {
                return false;
            }
        }

        return true;
    }

    private void Activate()
    {
        // Open Door
        doorController.TriggerHide();
    }
}
