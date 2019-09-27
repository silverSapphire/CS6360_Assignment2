using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VRMirror : MonoBehaviour {

    //True = mirror
    //False = matching
    bool mirroring;

    Vector3 lastPosition;
    Quaternion lastRotation;
    public GameObject cube;

	// Use this for initialization
	void Start () {

        lastPosition = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		
        if(Input.GetKeyDown("M"))
        {
            mirroring = !mirroring;
        }

        if (mirroring)
            mirror();
        else
            match();

        lastPosition = this.transform.position;
        lastRotation = this.transform.rotation;
	}

    void mirror()
    {

        //Position.
        Vector3 deltaPosition = this.transform.position - lastPosition;
        Vector3 v = cube.transform.position - this.transform.position;
        v = v.normalized;

        cube.transform.position =
            cube.transform.position + deltaPosition - Vector3.Dot(deltaPosition, v) * v * 2;

        //Rotation.
        Quaternion deltaRotation = this.transform.rotation * Quaternion.Inverse(lastRotation); //-?

    }

    void match()
    {
        Vector3 deltaPosition = this.transform.position - lastPosition;
        Quaternion deltaRotation = this.transform.rotation * Quaternion.Inverse(lastRotation); //-?

        cube.transform.position = cube.transform.position + deltaPosition;
        cube.transform.rotation = cube.transform.rotation * deltaRotation;
    }
}
