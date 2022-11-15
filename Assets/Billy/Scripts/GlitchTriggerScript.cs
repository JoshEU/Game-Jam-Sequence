using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GlitchTriggerScript : MonoBehaviour {
    public UnityEvent glitchEnter;
    public UnityEvent glitchExit;

    private void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Player")) {
            glitchEnter.Invoke();
        }
    }

    private void OnTriggerExit(Collider other) {
        if (other.CompareTag("Player")) {
            glitchExit.Invoke();
        }
    }
}