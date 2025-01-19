using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuHandler : MonoBehaviour
{
    // Load the Pong game scene
    public void PlayGame()
    {
        SceneManager.LoadScene("SampleScene"); 
    }

    // Quit the application
    public void QuitGame()
    {
        Debug.Log("Quit Game"); // This will show in the console for testing in the Unity editor
        Application.Quit();     // Quits the application (only works in a built application, not the editor)
    }
}
