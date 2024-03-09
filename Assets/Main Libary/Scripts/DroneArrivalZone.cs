using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DroneArrivalZone : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Trigger entered by: " + other.gameObject.name);

        // Check if the collider belongs to the drone
        if (other.CompareTag("Drone"))
        {
            // Trigger the events in the EventManager
            EventManager.ActivateDroneVideo();
            EventManager.ActivateJohnCollider();
        }
    }
}

