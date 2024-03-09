using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

[RequireComponent(typeof(VideoPlayer))]
public class DroneScreenScript : MonoBehaviour
{
    private VideoPlayer videoPlayer;

    void Start()
    {
        videoPlayer = GetComponentInChildren<VideoPlayer>();

        // Subscribe to the ActivateDroneVideo event
        EventManager.OnActivateDroneVideo += PlayDroneVideo;
    }

    void PlayDroneVideo()
    {
        videoPlayer.Play();
        Debug.Log("Drone video is playing.");
    }

    // Other methods and logic for the drone screen script...
}
