using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeTriggerScript : MonoBehaviour {
    [SerializeField]
    private Animator animator;

    private void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Cube")) {
            animator.SetTrigger("Open");
        }
    }

    private void OnTriggerExit(Collider other) {
        if (other.CompareTag("Cube")) {
            animator.SetTrigger("Close");
        }
    }
}