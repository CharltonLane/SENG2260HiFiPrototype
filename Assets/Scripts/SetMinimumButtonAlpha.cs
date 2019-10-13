using UnityEngine;
using System.Collections;
using UnityEngine.UI; // Required when Using UI elements.

public class SetMinimumButtonAlpha : MonoBehaviour {

	private Image button;

	// Use this for initialization
	void Start() {
		button = GetComponent<Image>();
		button.alphaHitTestMinimumThreshold = 0.1f;
	}
}