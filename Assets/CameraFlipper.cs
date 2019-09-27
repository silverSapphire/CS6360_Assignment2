using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFlipper : MonoBehaviour {

    int factor = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if(factor == 1)
            transform.rotation = transform.rotation * Quaternion.Euler(0, 180.0f, 0);

        //Flip the user 180 degrees.
        if (Input.GetKeyDown("f"))
        {
            factor = Mathf.Abs(1 - factor);
        }
	}
}
