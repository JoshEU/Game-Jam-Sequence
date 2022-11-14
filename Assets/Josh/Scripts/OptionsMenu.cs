using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class OptionsMenu : MonoBehaviour {
    [SerializeField]
    private Slider masterVolumeSlider;

    // Assigns default value for master volume if no previous saved data can be found
    private void Start() {
        if (!PlayerPrefs.HasKey("masterVolume")) {
            // Sets the deafault masterVolume to 75% if there is no previously saved volume data
            PlayerPrefs.SetFloat("masterVolume", 0.75f);
            SetMasterVolume();
        } else {
            GetMasterVolume();
        }
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
    public void BackButton() {
        // Load MainMenu Scene
        SceneManager.LoadScene(0);
    }
}
