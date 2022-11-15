using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class OptionsMenu : MonoBehaviour {
    [SerializeField]
    private Slider masterVolumeSlider;
    [SerializeField]
    private TMP_Dropdown windowModeDropdown;
    [SerializeField]
    private Toggle intenseStrobesToggle;

    public static bool intensityState;

    private void Start() {    
        // Assigns default value for master volume if no previous saved data can be found
        if (!PlayerPrefs.HasKey("masterVolume")) {
            // Sets the deafault masterVolume to 75% if there is no previously saved volume data
            PlayerPrefs.SetFloat("masterVolume", 0.75f);
            SetMasterVolume();
        } else {
            GetMasterVolume();
        }
        if (!PlayerPrefs.HasKey("windowMode")) {
            // Sets the deafault windowMode to ExclusiveFullscreen if there is no previously saved windowMode data.
            PlayerPrefs.SetInt("windowMode", 3);
            SetWindowMode();
        } else {
            GetWindowMode();
        }
        bool isToggledOn = false;
        if (PlayerPrefs.GetInt("intenseStrobes") == 1) {
            isToggledOn = true;
            SetIntenseStrobes();
        } else {
            isToggledOn = false;
            SetIntenseStrobes();
        }
        // Set the state of the toggle to the bool value
       intenseStrobesToggle.isOn = isToggledOn;
    }
    // Loads Master volume data
    public void GetMasterVolume() {
        masterVolumeSlider.value = PlayerPrefs.GetFloat("masterVolume");
    }
    // Saves Master volume data
    public void SetMasterVolume() {
        PlayerPrefs.SetFloat("masterVolume", masterVolumeSlider.value);
    }
    // This function will save the Master Volume slider's value to the Player preferences once it has been changed in run-time.
    public void ChangeMasterVolume() {
        // The volume of the game will be equal to the slider value.
        AudioListener.volume = masterVolumeSlider.value;
        SetMasterVolume();
    }
    public void GetWindowMode() {
        windowModeDropdown.value = PlayerPrefs.GetInt("windowMode");
    }
    // This function will save the WindowMode in Players preferences.
    public void SetWindowMode() {
        PlayerPrefs.SetInt("windowMode", windowModeDropdown.value);
    }
    // This function will change the window type of the game depending on the option selected in the dropdown menu.
    public void ChangeWindowMode() {
        Resolution currentResolution = Screen.currentResolution;
        switch (windowModeDropdown.value) {
            case 0:
                Screen.fullScreenMode = FullScreenMode.Windowed;
                break;
            case 1:
                Screen.fullScreenMode = FullScreenMode.MaximizedWindow;
                break;
            case 2:
                Screen.fullScreenMode = FullScreenMode.FullScreenWindow;
                break;
            case 3:
                Screen.fullScreenMode = FullScreenMode.ExclusiveFullScreen;
                break;
            default:
                // Do Nothing
                break;
        }
        SetWindowMode();
    }
    public void GetIntenseStrobes() {
        PlayerPrefs.GetInt("intenseStrobes");
       // intenseStrobesToggle.isOn = isToggledOn;
    }
    public void SetIntenseStrobes() {
        // Saves toggle state as either true or false
        if (intenseStrobesToggle.isOn == true) {
            PlayerPrefs.SetInt("intenseStrobes", 1);
            //intenseStrobesToggle.isOn = true;
        } else {
            PlayerPrefs.SetInt("intenseStrobes", 0);
            //intenseStrobesToggle.isOn = false;
        }
    }
    public void ChangeIntenseStrobes() {
        //intenseStrobesToggle.isOn = isToggledOn;
        SetIntenseStrobes();
    }
    public void BackButton() {
        // Load MainMenu Scene
        SceneManager.LoadScene(0);
    }
}
