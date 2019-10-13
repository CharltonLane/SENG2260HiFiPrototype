using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggleWristUI : MonoBehaviour {
	// Start is called before the first frame update
	GameObject wristUI;

    public void Start() {
		wristUI = transform.GetChild(0).gameObject; // Get the WristUI GameObject which is the only child to this GO.
    }

    // Update is called once per frame
    public void Update() {

		// Toggle the active state of the wrist UI when the assigned button is pressed.
        if (Input.GetButtonDown("ToggleUI")) {
            if (wristUI.activeSelf) {
				wristUI.SetActive(false);
            } else {
				wristUI.SetActive(true);
            }
        }


    }



}
