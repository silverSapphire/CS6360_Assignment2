﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraReset : MonoBehaviour {

    // Use this for initialization
	void Start () {
 	}
	
	// Update is called once per frame
	void Update () {
		
        if(Input.GetKeyDown("tab"))
        {
            //Camera.main.transform.SetPositionAndRotation(Vector3.zero, Quaternion.identity);
            //UnityEngine.XR.InputTracking.Recenter();
            this.transform.localPosition = -Camera.main.transform.localPosition;
        }
    }
}
