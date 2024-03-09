using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class EventManager : MonoBehaviour
{
    public static event Action OnStartDroneAnimation;
    public static event Action OnActivateDroneVideo;
    public static event Action OnActivateJohnCollider;

    public static void StartDroneAnimation()
    {
        OnStartDroneAnimation?.Invoke();
        Debug.Log("Drone animation started.");
    }

    public static void ActivateDroneVideo()
    {
        OnActivateDroneVideo?.Invoke();
        Debug.Log("Drone video activated.");
    }

    public static void ActivateJohnCollider()
    {
        OnActivateJohnCollider?.Invoke();
        Debug.Log("John's collider activated.");
    }
}
