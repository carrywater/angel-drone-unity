using UnityEngine;

public class SetInitialHeight : MonoBehaviour
{
    public float initialHeight = 1.3f;

    void Start()
    {
        // Set the initial height of the Camera Offset object
        Vector3 newPosition = transform.localPosition;
        newPosition.y = initialHeight;
        transform.localPosition = newPosition;
    }
}
