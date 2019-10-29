using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Artwork : MonoBehaviour {

	public Sprite sprite;
	public int noOfLikes = 0;
	public string title = "Artwork Title";
	public string author = "Artwork Author";
	public string description = "Artwork Description Text Artwork Description Text Artwork Description Text Artwork Description Text Artwork Description Text Artwork Description Text Artwork Description Text Artwork Description Text Artwork Description Text Artwork Description Text Artwork Description Text Artwork Description Text ";
	public string price = "$300";

	public bool hasBeenLiked = false;

	public GameObject infoPanel;

	// Start is called before the first frame update
	void Start()
    {
		if (transform.childCount != 0) { // This is a dodgy workaround, if it has children it is a physical artwork in the gallery, if not it's a UI button in the wishlist.
			sprite = transform.GetChild(0).GetComponent<SpriteRenderer>().sprite;

			// Now update the info panel text.
			infoPanel.transform.GetChild(0).GetComponent<TMPro.TextMeshProUGUI>().text = title;
			infoPanel.transform.GetChild(1).GetComponent<TMPro.TextMeshProUGUI>().text = author;
			infoPanel.transform.GetChild(2).GetComponent<TMPro.TextMeshProUGUI>().text = description;
			infoPanel.transform.GetChild(3).GetComponent<TMPro.TextMeshProUGUI>().text = price;
            infoPanel.transform.GetChild(4).GetComponent<TMPro.TextMeshProUGUI>().text = "Likes: " + noOfLikes.ToString();
		}

		
	}

    // Update is called once per frame
    void Update()
    {
        
    }

	public void LikeArtwork() {
		noOfLikes++;
		hasBeenLiked = true;
	}

	public void UnlikeArtwork() {
		noOfLikes--;
		hasBeenLiked = false;
	}
}
