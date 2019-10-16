using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleWishlistMenu : MonoBehaviour {

    // THIS CLASS IS UNUSED ATM.


    private bool isActive = false;

    // Start is called before the first frame update
    void Start() {
        
    }

    // Update is called once per frame
    void Update() {
        
    }

    public void EnableWishlistMenu() {
        if (!gameObject.activeSelf) {
            gameObject.SetActive(true);
            isActive = true;
        }
    }

    public void DisableWishlistMenu() {
        if (gameObject.activeSelf) {
            gameObject.SetActive(false);
            isActive = false;
        }
    }


}
