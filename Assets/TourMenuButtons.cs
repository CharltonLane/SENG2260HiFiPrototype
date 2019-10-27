using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TourMenuButtons : MonoBehaviour {

	public Button prevButton;
	public GameObject nextButton;
	public GameObject finishButton;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

	public void SetActiveFinishTourButton(bool active) {
		finishButton.SetActive(active);
	
	}

	public void SetActiveNextPaintingButton(bool active) {
		finishButton.SetActive(active);
	}



	public void InteractablePreviousArtworkButton(bool canBeInteracted) {
		// Makes this button clickable/unclickable.
		prevButton.interactable = canBeInteracted;
	}
}
