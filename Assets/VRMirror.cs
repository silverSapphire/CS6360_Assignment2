using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VRMirror : MonoBehaviour {

    //True = mirror
    //False = matching
    public bool mirroring;

    Vector3 lastPosition;
    Quaternion lastRotation;
    public GameObject cube;

	// Use this for initialization
	void Start () {
        lastPosition = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		
        if(Input.GetKeyDown("m"))
        {
            mirroring = !mirroring;
        }

        if (mirroring)
            mirror();
        else
            match();

        lastPosition = Camera.main.transform.position;
        lastRotation = Camera.main.transform.rotation;
	}

    void mirror()
    {
        //Position.
        Vector3 deltaPosition = Camera.main.transform.position - lastPosition;
        cube.transform.position = cube.transform.position + new Vector3(deltaPosition.x, deltaPosition.y, -deltaPosition.z);
        //Rotation.
        Vector3 deltaRotation = Camera.main.transform.rotation.eulerAngles - lastRotation.eulerAngles;
        cube.transform.rotation = Quaternion.Euler(cube.transform.rotation.eulerAngles + new Vector3(-deltaRotation.x,
            -deltaRotation.y, deltaRotation.z));
    }

    void match()
    {
        //Position.
        Vector3 deltaPosition = Camera.main.transform.position - lastPosition;
        cube.transform.position = cube.transform.position + deltaPosition;
        //Rotation.
        cube.transform.rotation = Camera.main.transform.rotation;
    }
}
