using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;

public class AnimationStateController : MonoBehaviour
{
    private Animator animator;
    private bool isDying = false;

    // Change this to the button you want to use on your VR controller
    public InputHelpers.Button vrInputButton = InputHelpers.Button.Trigger;

    // Change this to the key you want to use on the keyboard
    public KeyCode keyboardKey = KeyCode.G;

    void Start()
    {
        // Get the Animator component on the character GameObject
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        // Check for VR controller or keyboard input to trigger the transition to Dying Backwards
        if ((CheckVRControllerInput() || CheckKeyboardInput()) && !isDying)
        {
            StartDying();
        }
    }

    bool CheckVRControllerInput()
    {
        // Check if the specified button on the VR controller is pressed
        return InputHelpers.IsPressed(InputDevices.GetDeviceAtXRNode(XRNode.RightHand), vrInputButton, out _, 0.1f);
    }

    bool CheckKeyboardInput()
    {
        // Check if the specified key on the keyboard is pressed using the new Input System
        return Keyboard.current != null && Keyboard.current[Key.G].wasPressedThisFrame;
    }

    void StartDying()
    {
        // Set the trigger parameter to initiate the transition to Dying Backwards
        animator.SetTrigger("StartDying");

        // Set the flag to prevent repeated triggering
        isDying = true;
    }
}
