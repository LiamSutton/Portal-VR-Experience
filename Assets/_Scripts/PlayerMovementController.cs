using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementController : MonoBehaviour
{
    public float speed = 2.5f;
    public Transform camera;
    public CharacterController characterController;
    private bool isMoving = false;
    private void Update()
    {
        HandleInput();
        if (isMoving)
        {
            HandleMovement();
        }
    }
    private void HandleInput()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            isMoving = !isMoving;
        }
    }

    private void HandleMovement()
    {
        Vector3 forward = camera.TransformDirection(Vector3.forward);
        characterController.SimpleMove(forward * speed);
    }
}
