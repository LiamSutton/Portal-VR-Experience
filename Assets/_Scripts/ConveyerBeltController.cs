using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConveyerBeltController : MonoBehaviour
{
    public BoxCollider deployTrigger;


    public void OnTriggerEnter(Collider other)
    {
        print("HIT");
        if (other.gameObject.CompareTag("Turret"))
        {
            other.gameObject.GetComponent<TurretController>().Deploy();
        }
    }
}
