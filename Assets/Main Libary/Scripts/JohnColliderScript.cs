using UnityEngine;

public class ActivateCapsuleCollider : MonoBehaviour
{
    [SerializeField]
    private GameObject _CapsuleCollider_2;

    // Subscribe to the event in the EventManager when the script is enabled
    private void OnEnable()
    {
        EventManager.OnActivateJohnCollider += ActivateJohnCollider;
    }

    // Unsubscribe from the event in the EventManager when the script is disabled
    private void OnDisable()
    {
        EventManager.OnActivateJohnCollider -= ActivateJohnCollider;
    }

    // This method is invoked when the OnActivateJohnCollider event is triggered
    private void ActivateJohnCollider()
    {
        // Ensure the CapsuleCollider_2 reference is not null
        if (_CapsuleCollider_2 != null)
        {
            // Activate the CapsuleCollider_2 game object
            _CapsuleCollider_2.SetActive(true);
            Debug.Log("CapsuleCollider_2 activated.");
        }
        else
        {
            Debug.LogError("_CapsuleCollider_2 is null. Please assign it from the inspector.");
        }
    }
}
