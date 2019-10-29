using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtPlayer : MonoBehaviour {

	public GameObject target;

    public bool lockUpDownRotation = false;

    // Update is called once per frame
    void Update() {
        if (lockUpDownRotation) {
            Vector3 targetPostition = new Vector3(target.transform.position.x, this.transform.position.y, target.transform.position.z);
            this.transform.LookAt(targetPostition);
        } else {
            transform.LookAt(target.transform);
        }
        transform.Rotate(0, 180, 0);

        
	}
}
