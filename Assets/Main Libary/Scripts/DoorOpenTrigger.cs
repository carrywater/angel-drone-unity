using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpenTrigger : MonoBehaviour
{
    private bool isOpen = false;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Trigger entered by: " + other.gameObject.name);  // Debug statement

        // Check if the door is not already open and the trigger is activated by the DoorOpenZone
        if (!isOpen && other.CompareTag("DoorOpenZone"))
        {
            isOpen = true;

            // Trigger the event to start the drone animation
            EventManager.StartDroneAnimation();

            // Debug statement
            Debug.Log("Door entered the DoorOpenZone");
        }
    }
}

