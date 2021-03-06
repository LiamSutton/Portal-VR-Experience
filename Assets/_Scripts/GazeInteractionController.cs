using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GazeInteractionController : MonoBehaviour
{
    public Transform camera;
    public float baseFuseTimerLength = 0.5f;
    private float fuseTimer = 0.5f;
    private float rayDistance = 5f;
    void Update()
    {
        Ray ray;
        RaycastHit hit;
        GameObject hitObject;

        ray = new Ray(camera.position, camera.rotation * Vector3.forward);

        if (Physics.Raycast(ray, out hit, rayDistance))
        {
            hitObject = hit.collider.gameObject;

            if (hitObject.CompareTag("Door Switch"))
            {
                if (fuseTimer <= 0)
                {
                    // Click the button and trigger interaction
                    hitObject.SendMessage("Activate");
                    fuseTimer = baseFuseTimerLength;
                }
                else
                {
                    fuseTimer -= Time.deltaTime;
                }
            }
            else if (hitObject.CompareTag("Box Switch"))
            {
                if (fuseTimer <= 0)
                {
                    hitObject.SendMessage("Activate");
                    fuseTimer = baseFuseTimerLength;
                }
                else
                {
                    fuseTimer -= Time.deltaTime;
                }
            }
            else if (hitObject.CompareTag("Transporter"))
            {
                if (fuseTimer <= 0)
                {
                    hitObject.SendMessage("ChangeScene");
                }
                else
                {
                    fuseTimer -= Time.deltaTime;
                }
            }
            else
            {
                fuseTimer = baseFuseTimerLength;
            }
        }
    }
}
