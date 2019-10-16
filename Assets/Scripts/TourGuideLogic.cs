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
        while (onTour)
        {
            
        }
    }

    public void moveToNextArtwork()
    {
        gameObject.transform.position = artworks[artworkIndex+1].transform.GetChild(3).transform.position;
    }

    public void moveToPrevArtwork()
    {

    }
    

    public void cancelTour()
    {

    }

    public void pauseTour()
    {

    }
}
