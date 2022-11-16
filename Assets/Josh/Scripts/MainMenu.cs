using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {
    [SerializeField]
    private InputActionReference enterInput;
    [SerializeField]
    private GameObject MainMenuObj;
    [SerializeField]
    private GameObject CreditsObj;

    private float enterValue;
    private void Awake() {
        enterInput.action.performed += context => enterValue = context.action.ReadValue<float>();
    }
    private void Update() {
        if (Keyboard.current.enterKey.isPressed) {
            CreditsObj.SetActive(false);
            MainMenuObj.SetActive(true);
        }
    }
    public void StartButton() {
        Time.timeScale = 1;
        // Load Level One Scene 
        SceneManager.LoadScene("Level");
    }
    public void OptionsButton() {
        // Load Option Menu Scene 
        SceneManager.LoadScene("OptionsMenu");
    }
    public void QuitButton() {
        Application.Quit();
    }
}
