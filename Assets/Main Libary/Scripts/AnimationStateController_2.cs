using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterController : MonoBehaviour
{
    private Animator animator;
    private bool isDying = false;

    void Start()
    {
        // Get the Animator component on the character GameObject
        animator = GetComponent<Animator>();

        // Get the button component on the character GameObject
        Button button = GetComponent<Button>();

        // Add a listener to the button click event
        button.onClick.AddListener(StartDying);
    }

    // Function to handle button click
    void StartDying()
    {
        // Check if the character is not already dying
        if (!isDying)
        {
            // Set the trigger parameter to initiate the transition to Dying Backwards
            animator.SetTrigger("StartDying");

            // Set the flag to prevent repeated triggering
            isDying = true;
        }
    }
}
