using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeTriggerScript : MonoBehaviour {
    [SerializeField]
    private Animator animator;
    [SerializeField]
    private GameObject glitchWall;

    private void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Cube")) {
            animator.SetTrigger("Open");
            glitchWall.GetComponent<MeshRenderer>().enabled = false;
        }
    }
}