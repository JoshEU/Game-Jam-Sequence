using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorAnimationScript : MonoBehaviour {
    [SerializeField]
    private Animator animator;

    private void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Player")) {
            animator.SetTrigger("Open");
        }
    }

    private void OnTriggerExit(Collider other) {
        if (other.CompareTag("Player")) {
            animator.SetTrigger("Close");
        }
    }
}