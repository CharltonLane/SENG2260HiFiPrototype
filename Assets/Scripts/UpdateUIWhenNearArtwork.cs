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
    Collider ARtZone; //the collider that represents the area of the 3D art zone

	public GameObject homeMenu; // The references to these are set in the editor.
	public GameObject infoMenu;
    public GameObject ARtMenu;

	public Wishlist wishlist;

    void Start()
    {
        ARtZone = GameObject.Find("ARtZone").GetComponent<BoxCollider>();
        InstantiateObjects();   //this will create new objects for the artwork elements to go into
    }

	public void DisplayIMenu() {
		// Enables the I menu with the correct buttons showing (Like/Unlike and Add/Remove from wishlist).
		infoMenu.SetActive(true);
		if (wishlist.artworkWishlist.Contains(artwork)) {
			//print("This painting is in the wishg,ist");
			infoMenu.transform.Find("AddToWishlistButton").gameObject.SetActive(false);
			infoMenu.transform.Find("RemoveFromWishlistButton").gameObject.SetActive(true);
		} else {
			infoMenu.transform.Find("AddToWishlistButton").gameObject.SetActive(true);
			infoMenu.transform.Find("RemoveFromWishlistButton").gameObject.SetActive(false);
		}

		if (artwork.GetComponent<Artwork>().hasBeenLiked) {
			//print("This painting has been liked");
			infoMenu.transform.Find("UnlikeButton").gameObject.SetActive(true);
			infoMenu.transform.Find("LikeButton").gameObject.SetActive(false);
		} else {
			infoMenu.transform.Find("UnlikeButton").gameObject.SetActive(false);
			infoMenu.transform.Find("LikeButton").gameObject.SetActive(true);
		}
	}

	private void OnTriggerEnter(Collider other) {
       
        //Checking that the collider that was triggered was the ARt Zone
        if (other.Equals(ARtZone))
        {
            Debug.Log("User entered ARt Zone");
            //Ask which hand they want the UI to be on
            //ChangeUI here
            DisplayARtMenu();
        }
        else
        {   
            //If collider wasnt ARt Zone, then it must be an artwork
            // We've entered an artworks trigger so lets remember it so we can enable the info panel if needed.
            EnableIButton();
            artwork = other.transform.parent.gameObject; // This gets the GO named "Artwork" in the artwork prefab.
            infoPanel = artwork.transform.GetChild(2).GetChild(1).gameObject; // The first GetChild(2) gets the "Canvas" GO's transform and the second GetChild(1) gets the InfoPanel GO's transform.
            hiddenInfoPanel = artwork.transform.GetChild(2).GetChild(0).gameObject;
        }
	}

	private void OnTriggerExit(Collider other) {
        
        if (other.Equals(ARtZone))
        {
            Debug.Log("User exited ARt Zone");
            HideARtMenu();
        }
        else if (infoPanel.activeSelf) {
            // We have left an artwork's trigger so lets close the info panel if it's open.
            HideInfoPanel();
			// Also need to switch the menu back to the home menu.
			homeMenu.SetActive(true);
			infoMenu.SetActive(false);
		}

        // Make it 'forget' the last painting by creating new artwork objects
        InstantiateObjects();

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

    private void DisplayARtMenu()
    {
        homeMenu.SetActive(false);
        ARtMenu.SetActive(true);
    }

    private void HideARtMenu()
    {
        homeMenu.SetActive(true);
        ARtMenu.SetActive(false);
    }

    private void InstantiateObjects()
    {
        artwork = null;
        infoPanel = null;
        hiddenInfoPanel = null;
    }

	public void AddArtworkToWishlist() {
		wishlist.AddArtworkToWishlist(artwork);
	}

	public void RemoveArtworkFromWishlist() {
		wishlist.RemoveArtworkFromWishlist(artwork);
	}


	public void LikeArtwork() {
		artwork.GetComponent<Artwork>().LikeArtwork();
	}

	public void UnlikeArtwork() {
		artwork.GetComponent<Artwork>().UnlikeArtwork();
	}
}
