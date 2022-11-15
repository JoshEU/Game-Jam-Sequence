using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;
using StarterAssets;

public class PauseMenu : MonoBehaviour {
    [SerializeField]
    private GameObject pauseMenuObj;
    [SerializeField]
    private FirstPersonController firstPersonController;
    private void Start() {
        Cursor.lockState = CursorLockMode.Locked;
    }
    // Update is called once per frame
    void Update() {
        if (Keyboard.current.escapeKey.isPressed) {
            Time.timeScale = 0;
            firstPersonController.enabled = false;
            pauseMenuObj.SetActive(true);
            Cursor.lockState = CursorLockMode.Confined;
        }
    }
    public void ResumeButton() {
        Time.timeScale = 1;
        firstPersonController.enabled = true;
        pauseMenuObj.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
    }
    public void OptionsButton() {
        // Loads Options Menu Scene
        SceneManager.LoadScene("OptionsMenu");
    }
    public void MenuButton() {
        SceneManager.LoadScene("MainMenu");
    } 
    public void QuitButton() {
        // REMOVE LATER
        UnityEditor.EditorApplication.isPlaying = false;
        // KEEP LATER
        Application.Quit();
    }
}
