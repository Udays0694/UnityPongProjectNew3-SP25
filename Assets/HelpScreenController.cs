using UnityEngine;

public class HelpScreenController : MonoBehaviour
{
    public GameObject helpCanvas; // Assign the HelpCanvas in the Inspector
    private bool isHelpOpen = false;

    void Start()
    {
        // Ensure the HelpCanvas is disabled at the start of the game
        if (helpCanvas != null)
        {
            helpCanvas.SetActive(false);
        }
        isHelpOpen = false; // Set the initial state of the help screen
    }

    void Update()
    {
        // Toggle the help screen with the H key
        if (Input.GetKeyDown(KeyCode.H))
        {
            ToggleHelp();
        }
    }

    public void ToggleHelp()
    {
        // Toggle the help screen's visibility
        isHelpOpen = !isHelpOpen;

        if (helpCanvas != null)
        {
            helpCanvas.SetActive(isHelpOpen);
        }

        // Pause or resume the game based on the help screen state
        Time.timeScale = isHelpOpen ? 0 : 1;
    }

    public void CloseHelp()
    {
        // Explicitly close the help screen
        isHelpOpen = false;

        if (helpCanvas != null)
        {
            helpCanvas.SetActive(false);
        }

        // Resume the game
        Time.timeScale = 1;
    }
}


