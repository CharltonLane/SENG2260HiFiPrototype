using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateInfoPanel : MonoBehaviour {

	Artwork artwork;

	public GameObject artworkInfoPanel;

    // Start is called before the first frame update
    void Start() {
		artwork = GetComponent<Artwork>();
    }


	public void UpdateArtworkInfoPanel() {
		//print("Here the pos of the art: " + artwork.transform.position + " with " + artwork.transform.childCount + " children");
		artworkInfoPanel.transform.GetChild(1).GetComponent<TMPro.TextMeshProUGUI>().text = artwork.title;
		artworkInfoPanel.transform.GetChild(2).GetComponent<TMPro.TextMeshProUGUI>().text = artwork.author;
		artworkInfoPanel.transform.GetChild(3).GetComponent<TMPro.TextMeshProUGUI>().text = artwork.description;
		artworkInfoPanel.transform.GetChild(4).GetComponent<TMPro.TextMeshProUGUI>().text = artwork.price;
		artworkInfoPanel.transform.GetChild(5).GetComponent<UnityEngine.UI.Image>().sprite = artwork.sprite;

	}
}
