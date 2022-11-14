using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorAnimationScript : MonoBehaviour {
    private void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Player")) {

        }
    }
}