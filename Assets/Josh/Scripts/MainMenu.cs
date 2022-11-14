using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class MainMenu : MonoBehaviour {
    public void StartButton() {
        // Load Level One Scene 
        SceneManager.LoadScene(2);
        Debug.Log("hsua");
    }
    public void OptionsButton() {
        // Load Option Menu Scene 
        SceneManager.LoadScene(1);
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
