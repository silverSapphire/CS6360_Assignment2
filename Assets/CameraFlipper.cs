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
        if (Input.GetKeyDown("f"))
        {
            Vector3 rot = transform.rotation.eulerAngles;
            rot = new Vector3(rot.x, rot.y + 180.0f, rot.z);
            this.transform.localRotation = Quaternion.Euler(rot);
        }
	}
}
