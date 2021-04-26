using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementController : MonoBehaviour
{
    /*
    Movement: Movement is toggled by looking directly down
    */

    public float speed = 2.5f;
    public CharacterController characterController;
    public Transform camera;

    private bool isMoving = false;

    private void Update()
    {
        Ray ray = new Ray(camera.position, camera.rotation * Vector3.forward);
        RaycastHit hit;

        if (Input.GetButtonDown("Fire1"))
        {
            isMoving = !isMoving;
        }

        if (isMoving)
        {
            Vector3 forward = camera.TransformDirection(Vector3.forward);
            characterController.SimpleMove(forward * speed);
        }
    }
}
