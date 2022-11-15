using UnityEngine;

namespace Kino {
    public class GlitchedMenu : MonoBehaviour {
        [SerializeField]
        private DigitalGlitch digitalGlitch;
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
        public void GlitchedOptions() {
            // DO Next
        }
        public void GlitchedCredits() {

        }
        public void GlitchedQuit() {

        }
    }
}

