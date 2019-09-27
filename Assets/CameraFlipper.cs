using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFlipper : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
        //Flip the user 180 degrees.
        if(Input.GetKeyDown("F"))
        {
            transform.rotation = Quaternion.Euler(0, 180.0f, 0);
        }
	}
}
