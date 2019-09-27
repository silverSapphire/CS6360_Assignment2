using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraReset : MonoBehaviour {
    public Vector3 offset;
	// Use this for initialization
	void Start () {
        offset = new Vector3(0, 0, 0);
	}
	
	// Update is called once per frame
	void Update () {
		
        if(Input.GetKeyDown("tab"))
        {
            Debug.Log("Tab was pressed!");

            offset -= Camera.main.transform.position;
        }
        Camera.main.transform.position += offset;
    }
}
