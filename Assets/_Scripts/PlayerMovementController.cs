using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementController : MonoBehaviour
{
    public CharacterController characterController;
    public Transform camera;

    public bool previouslyLookingForward = false;
    public bool lookingForward = false;
    public bool isMoving = false;

    bool toggleForwardMotion;
    bool startLookingForward;

    public float speed = 1.0f;
    public float toggleAngle = 30.0f;


    private void Update()
    {
        previouslyLookingForward = lookingForward;

        if (camera.transform.eulerAngles.x >=15 && camera.transform.eulerAngles.x < 100) {
            lookingForward = false;
        }
        else {
            lookingForward = true;
        }

        if (lookingForward == true && previouslyLookingForward == false) {
            startLookingForward = true;
        }

        if (startLookingForward) {
            toggleForwardMotion = !toggleForwardMotion;
        }

        isMoving = lookingForward && toggleForwardMotion;

        if (isMoving) {
            Vector3 forward = camera.TransformDirection(Vector3.forward);
            characterController.SimpleMove(forward * speed);
        }
    }
}
