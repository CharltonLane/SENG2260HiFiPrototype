using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TourGuideLogic : MonoBehaviour
{

    public GameObject[] artworks = new GameObject[11];
    public bool pausedTour = false;
    public int artworkIndex = 0;

	public GameObject progressBar;

	public TourMenuButtons buttons;


    // Start is called before the first frame update
    void Start()
    {
        artworkIndex = 0;
        gameObject.transform.position = artworks[artworkIndex].transform.GetChild(3).transform.position;
    }


    public void moveToNextArtwork()
    {
        if (!pausedTour)
        {
            artworkIndex++;
			if (artworkIndex > 0) {
				buttons.InteractablePreviousArtworkButton(true);
			}

            if (artworkIndex == artworks.Length - 1) {
				// Now we are on the last painting in the tour.
				// Disable the next button and enable the finish tour button.
				buttons.SetActiveNextPaintingButton(false);
				buttons.SetActiveFinishTourButton(true);
				

                //artworkIndex = 0;
            } 
            gameObject.transform.position = artworks[artworkIndex].transform.GetChild(3).transform.position;
			progressBar.GetComponent<UpdateProgressBar>().UpdateProgressBarWidth(artworkIndex);
        }
       
    }

    public void moveToPrevArtwork()
    {
        if (!pausedTour)
        {
            artworkIndex--;
            if (artworkIndex <= 0)
            {
				//artworkIndex = artworks.Length - 1;
				artworkIndex = 0;
				buttons.InteractablePreviousArtworkButton(false);
			}
			if (artworkIndex <= artworks.Length -1) {
				
				buttons.SetActiveNextPaintingButton(true);
				buttons.SetActiveFinishTourButton(false);
				
			}


            gameObject.transform.position = artworks[artworkIndex].transform.GetChild(3).transform.position;
			progressBar.GetComponent<UpdateProgressBar>().UpdateProgressBarWidth(artworkIndex);
		}
      
    }
    

    public void cancelTour()
    {
        artworkIndex = 0;  // When a tour is cancelled, the tour guide position is reset to first artwork.
        gameObject.transform.position = artworks[artworkIndex].transform.GetChild(3).transform.position;
		progressBar.GetComponent<UpdateProgressBar>().UpdateProgressBarWidth(artworkIndex);

		buttons.InteractablePreviousArtworkButton(false);
		buttons.SetActiveNextPaintingButton(true);
		buttons.SetActiveFinishTourButton(false);

		gameObject.SetActive(false);
	}

    public void pauseTour()
    {
        if (pausedTour)
        {
            pausedTour = false;
        } else
        {
            
            pausedTour = true;
        }
    }

    
}
