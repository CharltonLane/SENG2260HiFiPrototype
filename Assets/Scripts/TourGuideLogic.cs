using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TourGuideLogic : MonoBehaviour
{

    public GameObject[] artworks = new GameObject[11];
    public bool onTour = false;
    public int artworkIndex = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position = artworks[artworkIndex].transform.GetChild(3).transform.position;
    }

    public void moveToNextArtwork()
    {
        artworkIndex++;
        if (artworkIndex >= artworks.Length)
        {
            artworkIndex = 0;
        }
       
    }

    public void moveToPrevArtwork()
    {
        artworkIndex--;
        if (artworkIndex < 0)
        {
            artworkIndex = artworks.Length-1;
        }
      
    }
    

    public void cancelTour()
    {

    }

    public void pauseTour()
    {

    }
}
