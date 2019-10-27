using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wishlist : MonoBehaviour {

	public LinkedList<GameObject> artworkWishlist = new LinkedList<GameObject>();

	public GameObject wishlistArtworkButtonPrefab;

	public GameObject scrollViewContent;

	public GameObject artworkInfoPanel;

	public GameObject currentArt;

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
		for (int i = 0; i < scrollViewContent.transform.childCount; i++) {
			Destroy(scrollViewContent.transform.GetChild(i).gameObject);
		}

		ResetWishlistInfoPanel();

		// Reset the width of the scroll view content to 0, it get's widened every time you add a button below.
		scrollViewContent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 300);

		if (artworkWishlist.Count > 0) {

			//artworkInfoPanel.transform.GetChild(5).gameObject.SetActive(true);
			//artworkInfoPanel.transform.GetChild(6).gameObject.SetActive(true);
			artworkInfoPanel.transform.GetChild(7).gameObject.SetActive(false);

			// Create the buttons for the artwork currently in the wishlist.
			foreach (GameObject artwork in artworkWishlist) {
				GameObject newButton = Instantiate(wishlistArtworkButtonPrefab, scrollViewContent.transform);
				newButton.GetComponent<UnityEngine.UI.Image>().sprite = artwork.transform.GetChild(0).GetComponent<SpriteRenderer>().sprite;
				Artwork buttonArt = newButton.GetComponent<Artwork>();
				Artwork artworkArt = artwork.GetComponent<Artwork>();
				buttonArt.sprite = artworkArt.sprite;
				buttonArt.title = artworkArt.title;
				buttonArt.author = artworkArt.author;
				buttonArt.description = artworkArt.description;
				buttonArt.price = artworkArt.price;
				buttonArt.noOfLikes = artworkArt.noOfLikes;
				newButton.GetComponent<UpdateInfoPanel>().wishlist = this;
				newButton.GetComponent<UpdateInfoPanel>().art = artwork;

				newButton.GetComponent<UpdateInfoPanel>().artworkInfoPanel = artworkInfoPanel;

				scrollViewContent.GetComponent<RectTransform>().sizeDelta = new Vector2(scrollViewContent.GetComponent<RectTransform>().sizeDelta.x+40, 300);
				//print("Set the info panel to: " + artworkInfoPanel);
			}
		} else {
			// Wishlist is empty so hide the sample text and display the info message.

			
			artworkInfoPanel.transform.GetChild(7).gameObject.SetActive(true);
		}

	}

	private void ResetWishlistInfoPanel() {
		artworkInfoPanel.transform.GetChild(1).GetComponent<TMPro.TextMeshProUGUI>().text = "";
		artworkInfoPanel.transform.GetChild(2).GetComponent<TMPro.TextMeshProUGUI>().text = "";
		artworkInfoPanel.transform.GetChild(3).GetComponent<TMPro.TextMeshProUGUI>().text = "";
		artworkInfoPanel.transform.GetChild(4).GetComponent<TMPro.TextMeshProUGUI>().text = "";
		artworkInfoPanel.transform.GetChild(5).gameObject.SetActive(false);
		artworkInfoPanel.transform.GetChild(6).gameObject.SetActive(false);
	}

	public void AddArtworkToWishlist(GameObject artwork) {
		//print("Added to wishlist");
		artworkWishlist.AddLast(artwork);
	}

	public void RemoveArtworkFromWishlist(GameObject artwork) {
		//print("Removed Art From wishlist");
		//print("wishlist is " + artworkWishlist.Count + " long");
		artworkWishlist.Remove(artwork);
		//print("wishlist is " + artworkWishlist.Count + " long");
	}

	public void DeleteFromWishlistButton() {
		RemoveArtworkFromWishlist(currentArt);
		RefreshUI();
	}

}
