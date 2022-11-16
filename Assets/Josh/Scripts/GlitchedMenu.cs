using UnityEngine;
using UnityEngine.InputSystem;
using System.Collections;

namespace Kino {
    public class GlitchedMenu : MonoBehaviour {
        [SerializeField]
        private DigitalGlitch digitalGlitch;
        [SerializeField]
        private GameObject errorObj;
        [SerializeField]
        private GameObject glitchedCreditsObj;
        [SerializeField]
        private GameObject glitchedMainMenuObj; 
        [SerializeField]
        private GameObject glitchedStartObj;
        // Start is called before the first frame update
        void Start() {
            Cursor.lockState = CursorLockMode.None;
            if (PlayerPrefs.GetInt("intenseStrobes") == 1) {
                // Intense
                digitalGlitch.intensity = 0.25f;
            } else {
                // Not Intense
                digitalGlitch.intensity = 0.025f;
            }
        }
        IEnumerator startFlicker() {
            for (int i = 0; i < 10; i++) {
                glitchedStartObj.SetActive(true);
                yield return new WaitForSeconds(0.25f);
                glitchedStartObj.SetActive(false);
                yield return new WaitForSeconds(0.25f);
            }
        }
        public void GlitchedStart() {
            StartCoroutine(startFlicker());
        }
        public void GlitchedOptions() {
            // DO Next
        }
        public void GlitchedCredits() {
            glitchedCreditsObj.SetActive(true);
        }
        private void Update() {
            if (Keyboard.current.enterKey.isPressed) {
                glitchedCreditsObj.SetActive(false);
                glitchedMainMenuObj.SetActive(true);
            }
        }
        private IEnumerator errorDelay() {
            yield return new WaitForSeconds(1.5f);
            errorObj.SetActive(false);
      }
      public void GlitchedQuit() {
            errorObj.SetActive(true);
            StartCoroutine(errorDelay());
      }
    }
}

