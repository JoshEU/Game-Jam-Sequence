using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerExitScript : MonoBehaviour {
    [SerializeField]
    private Animator animator;
    private void OnTriggerExit(Collider other) {
        if (other.CompareTag("Player")) {
            animator.SetTrigger("Close");
        }
    }
}