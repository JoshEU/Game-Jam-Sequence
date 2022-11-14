using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarryTriggerScript : MonoBehaviour {
    [SerializeField]
    private Animator animator;

    private void OnTriggerEnter(Collider other) {
        if (other.CompareTag("CarryingObject")) {
            animator.SetTrigger("Open");
        }
    }
}