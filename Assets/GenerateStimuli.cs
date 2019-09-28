using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateStimuli : MonoBehaviour
{
    bool activated = false;
    public Transform red_sphere;
    public Transform blue_one;
    public Transform blue_two;
    public float z;
    public float z1;
    public float z2;


    // Start is called before the first frame update
    void Start()
    {

        Transform[] ts = transform.GetComponentsInChildren<Transform>();

        foreach(Transform t in ts)
        {
            if (t.name == "Red")
                red_sphere = t;
            else if (t.name == "Blue_one")
                blue_one = t;
            else if (t.name == "Blue_two")
                blue_two = t;
        }
    }

    // Update is called once per frame
    void Update()
    {
        return;
        if (Input.GetKeyDown("s"))
        {
            activated = true;
        }

        if (!activated)
            return;

        Debug.Log("Calculating");
        z = Vector3.Magnitude(Camera.main.transform.position - red_sphere.position);
        z1 = Vector3.Magnitude(Camera.main.transform.position - blue_one.position);
        z2 = Vector3.Magnitude(Camera.main.transform.position - blue_two.position);

        blue_one.localScale = red_sphere.localScale * z1 / z;
        blue_two.localScale = red_sphere.localScale * z2 / z;
    }
}
