using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wishlist : MonoBehaviour {

	LinkedList<GameObject> artworkWishlist = new LinkedList<GameObject>();

	public GameObject wishlistArtowrkButtonPrefab;

	public GameObject scrollViewContent;

	public GameObject artworkInfoPanel;

    // Start is called before the first frame update
    void Start() {
        
    }

    // Update is called once per frame
    void Update() {
        
    }

	private void OnEnable() {
		RefreshUI();
	}

	private void RefreshUI() {



		// Delete any buttons in the wishlist scroll view.
		for (int i=0; i < scrollViewContent.transform.childCount; i++) {
			Destroy(scrollViewContent.transform.GetChild(i).gameObject);
		}

		// Create the buttons for the artwork currently in the wishlist.
		foreach (GameObject artwork in artworkWishlist) {
			GameObject newButton = Instantiate(wishlistArtowrkButtonPrefab, scrollViewContent.transform);
			newButton.GetComponent<UnityEngine.UI.Image>().sprite = artwork.transform.GetChild(0).GetComponent<SpriteRenderer>().sprite;
			Artwork buttonArt = newButton.GetComponent<Artwork>();
			Artwork artworkArt = artwork.GetComponent<Artwork>();
			buttonArt.sprite = artworkArt.sprite;
			buttonArt.name = artworkArt.name;
			buttonArt.author = artworkArt.author;
			buttonArt.description = artworkArt.description;
			buttonArt.price = artworkArt.price;
			buttonArt.noOfLikes = artworkArt.noOfLikes;

			newButton.GetComponent<UpdateInfoPanel>().artworkInfoPanel = artworkInfoPanel;
			print("Set the info panel to: " + artworkInfoPanel);
		}
	}

	public void AddArtworkToWishlist(GameObject artwork) {
		print("Added to wishlist");
		artworkWishlist.AddLast(artwork);
	}

	public void RemoveArtworkFromWishlist(GameObject artwork) {
		print("Removed Art From wishlist");
		artworkWishlist.Remove(artwork);
	}
}
