using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {
    public void StartButton() {
        Time.timeScale = 1;
        // Load Level One Scene 
        SceneManager.LoadScene("Level");
    }
    public void OptionsButton() {
        // Load Option Menu Scene 
        SceneManager.LoadScene("OptionsMenu");
    }
    public void CreditsButton() {

    }
    public void QuitButton() {
        // Delete this line later!!!!
        UnityEditor.EditorApplication.isPlaying = false;
        // Keep this
        Application.Quit();
    }
}
