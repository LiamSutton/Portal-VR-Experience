using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiButtonDoorController : MonoBehaviour
{
    public DoorController doorController;
    public GameObject[] buttonGameObjects;
    private MultiButtonController[] buttonControllers;
    private bool[] buttonsActive;
    private void awake()
    {
        for (int i = 0; i < buttonGameObjects.Length; i++)
        {
            buttonControllers[i] = buttonGameObjects[i].GetComponent<MultiButtonController>();
        }
    }

    public void ChildActivated(GameObject child)
    {
        int idx = System.Array.IndexOf(buttonGameObjects, child);
        buttonsActive[idx] = true;
        bool shouldOpenDoor = CheckAllChildren();

        if (shouldOpenDoor)
        {
            Activate();
        }
    }

    private bool CheckAllChildren()
    {
        for (int i = 0; i < buttonGameObjects.Length; i++)
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
