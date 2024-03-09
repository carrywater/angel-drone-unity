using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject welcomeScreen;
    public GameObject resetSwitchSceneScreen;
    public GameObject screenSpaceInterface; // Updated variable name

    void Start()
    {
        // Disable screens on start
        welcomeScreen.SetActive(false);
        resetSwitchSceneScreen.SetActive(false);
        screenSpaceInterface.SetActive(false); // Updated variable name
    }

    // Call this function when the reset/switch scene button is clicked
    public void OnResetSwitchSceneButtonClick()
    {
        // Implement your logic here for resetting or switching scenes
    }
}

