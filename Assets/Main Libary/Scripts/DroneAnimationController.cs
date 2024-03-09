using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DroneAnimationController : MonoBehaviour
{
    private Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();

        // Subscribe to the event triggered by DoorOpenTrigger
        EventManager.OnStartDroneAnimation += PlayAnimation;
    }

    private void OnDestroy()
    {
        // Unsubscribe to prevent memory leaks
        EventManager.OnStartDroneAnimation -= PlayAnimation;
    }

    private void PlayAnimation()
    {
        // Trigger the drone animation
        animator.SetTrigger("AnimateDrone");

        // Debug statement
        Debug.Log("Drone animation triggered");
    }
}
