using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    public float openAngle = 90f; // Set the angle by which the door should open

    private HingeJoint hingeJoint;
    private JointLimits originalLimits;

    void Start()
    {
        // Get the HingeJoint component
        hingeJoint = GetComponent<HingeJoint>();

        // Store the original joint limits for later restoration
        originalLimits = hingeJoint.limits;
    }

    void Update()
    {
        // Example: Open the door when the 'E' key is pressed
        if (Input.GetKeyDown(KeyCode.E))
        {
            OpenDoor();
        }
    }

    void OpenDoor()
    {
        // Set new joint limits for the door to open
        JointLimits newLimits = hingeJoint.limits;
        newLimits.max = openAngle;
        hingeJoint.limits = newLimits;

        // Apply the changes to the HingeJoint
        hingeJoint.useLimits = true;
    }

    // Optionally, you can add a method to close the door
    void CloseDoor()
    {
        // Restore the original joint limits
        hingeJoint.limits = originalLimits;

        // Apply the changes to the HingeJoint
        hingeJoint.useLimits = true;
    }
}
