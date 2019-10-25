using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Artwork : MonoBehaviour {

	public Sprite sprite;
	public int noOfLikes = 0;
	public string title = "Artwork Title";
	public string author = "Artwork Author";
	public string description = "Artwork Description Text Artwork Description Text Artwork Description Text Artwork Description Text Artwork Description Text Artwork Description Text Artwork Description Text Artwork Description Text Artwork Description Text Artwork Description Text Artwork Description Text Artwork Description Text ";
	public string price = "$300";

	public bool hasBeenLiked = false;

	// Start is called before the first frame update
	void Start()
    {
		if (transform.childCount != 0) { // This is a dodgy workaround, if it has children it is a physical artwork in the gallery, if not it's a UI button in the wishlist.
			sprite = transform.GetChild(0).GetComponent<SpriteRenderer>().sprite;
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
