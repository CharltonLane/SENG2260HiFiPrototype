using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TourGuideLogic : MonoBehaviour
{

    public GameObject[] artworks = new GameObject[11];
    public bool pausedTour = false;
    public int artworkIndex = 0;


    // Start is called before the first frame update
    void Start()
    {
        artworkIndex = 0;
        gameObject.transform.position = artworks[artworkIndex].transform.GetChild(3).transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void moveToNextArtwork()
    {
        if (!pausedTour)
        {
            artworkIndex++;
            if (artworkIndex >= artworks.Length)
            {
                artworkIndex = 0;
            }
            gameObject.transform.position = artworks[artworkIndex].transform.GetChild(3).transform.position;
        }
       
    }

    public void moveToPrevArtwork()
    {
        if (!pausedTour)
        {
            artworkIndex--;
            if (artworkIndex < 0)
            {
                artworkIndex = artworks.Length - 1;
            }
            gameObject.transform.position = artworks[artworkIndex].transform.GetChild(3).transform.position;
        }
      
    }
    

    public void cancelTour()
    {
        artworkIndex = 0;  // When a tour is cancelled, the tour guide position is reset to first artwork.
        gameObject.transform.position = artworks[artworkIndex].transform.GetChild(3).transform.position;
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
