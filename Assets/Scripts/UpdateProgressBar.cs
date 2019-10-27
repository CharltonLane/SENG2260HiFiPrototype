using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateProgressBar : MonoBehaviour {


	private int maxArtworkIndex = 10; // So 11 artworks, 0-10
	private int fullWidth = 80;

    // Start is called before the first frame update
    void Start()
    {
        
    }


	public void UpdateProgressBarWidth(int index) {
		GetComponent<UnityEngine.UI.Image>().rectTransform.sizeDelta = new Vector2(fullWidth * ((float)index / (float)maxArtworkIndex), 100);
	}

}
