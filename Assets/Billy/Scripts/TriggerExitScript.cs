using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class TriggerExitScript : MonoBehaviour {
    [SerializeField]
    private Animator animator;
    public UnityEvent unityEvent;
    private void OnTriggerExit(Collider other) {
        if (other.CompareTag("Player")) {
            animator.SetTrigger("Close");
            unityEvent.Invoke();
        }
    }

    public void loadGlitchedMenu() {
        SceneManager.LoadScene("GlitchedMainMenu");
    }
}