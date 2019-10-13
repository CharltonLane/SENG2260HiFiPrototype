using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/* This script is attached to the wrist UI and will store the 
 * artwork that the user is currently standing close to
 * 
 * 
 * 
 * Created 03/10/2019 by Charlton Lane
*/


public class UpdateUIWhenNearArtwork : MonoBehaviour {

	GameObject artwork; // The artwork the user is standing close to. This is the GO named Artwork in the artwork prefab
	GameObject infoPanel; // This is the opened info panel with the painting's details.
	GameObject hiddenInfoPanel; // This is the single i icon, shown when the info panel isn't open.

	public GameObject homeMenu; // The references to these are set in the editor.
	public GameObject infoMenu;


	private void OnTriggerEnter(Collider other) {
		// We've entered an artworks trigger so lets remember it so we can enable the info panel if needed.
		EnableIButton();
		artwork = other.transform.parent.gameObject; // This gets the GO named "Artwork" in the artwork prefab.
		infoPanel = artwork.transform.GetChild(2).GetChild(1).gameObject; // The first GetChild(2) gets the "Canvas" GO's transform and the second GetChild(1) gets the InfoPanel GO's transform.
		hiddenInfoPanel = artwork.transform.GetChild(2).GetChild(0).gameObject;
	}

	private void OnTriggerExit(Collider other) {
		// We have left an artwork's trigge so lets close the info panel if it's open.
		if (infoPanel.activeSelf) {
			HideInfoPanel();
			// Also need to switch the menu back to the home menu.
			homeMenu.SetActive(true);
			infoMenu.SetActive(false);
		}

		// Make it 'forget' the last painting;
		artwork = null;
		infoPanel = null;
		hiddenInfoPanel = null;

		DisableIButton();
	}

	public void EnableIButton() {
		// Enables the I button on the home menu so it can be clicked.
		homeMenu.transform.GetChild(0).GetComponent<Button>().interactable = true;
	}

	public void DisableIButton() {
		homeMenu.transform.GetChild(0).GetComponent<Button>().interactable = false;
	}

	public void HideInfoPanel() {
		// Disable the info panel and show only the i icon.
		hiddenInfoPanel.SetActive(true);
		infoPanel.SetActive(false);
	}

	public void DisplayInfoPanel() {
		// Enables the info panel of the current painting.
		infoPanel.SetActive(true);
		hiddenInfoPanel.SetActive(false);
		
	}


}
