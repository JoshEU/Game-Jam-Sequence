using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.InputSystem;

public class PickupSystemScript : MonoBehaviour {
    [SerializeField]
    private TMP_Text interactionText;
    [SerializeField]
    private GameObject pickedObject;
    [SerializeField]
    private GameObject player;
    [SerializeField]
    private GameObject carryPoint;
    [SerializeField]
    private InputActionReference eInput;
    private float eValue;
    private bool eBool;

    private void Awake() {
        eInput.action.performed += context => eValue = context.action.ReadValue<float>(); 
    }

    private void Update() {
        if (eValue == 1) {
            if (eBool == false) {
                EPressed();
            }
        } else if(eValue == 0) {
            eBool = false;
        }
    }

    private void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Player")) {
            interactionText.gameObject.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other) {
        if (other.CompareTag("Player")) {
            interactionText.gameObject.SetActive(false);
        }
    }

    private void EPressed() {
        eBool = false;
        pickedObject.transform.position = carryPoint.transform.position;
    }
}