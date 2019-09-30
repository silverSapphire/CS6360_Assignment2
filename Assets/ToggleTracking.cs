using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class ToggleTracking : MonoBehaviour
{

    public bool trackRotation = true;
    public bool trackPosition = true;

    Vector3 lastPosition;
    Quaternion lastRotation;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("r"))
        {
            trackRotation = !trackRotation;
            lastRotation = Camera.main.transform.rotation;

            if (!trackPosition && !trackRotation)
                transform.localScale = Vector3.zero;
            else
                transform.localScale = Vector3.one;
        }

        if (!trackRotation)
        {
            transform.rotation = lastRotation * Quaternion.Inverse(Camera.main.transform.localRotation);

            //transform.Translate(-Camera.main.transform.position);
            //transform.Rotate(Quaternion.Inverse(Camera.main.transform.rotation).eulerAngles, Space.World);
            //transform.Rotate(Quaternion.Inverse(transform.rotation).eulerAngles, Space.World);
            //transform.Rotate(Quaternion.Inverse(Camera.main.transform.localRotation).eulerAngles, Space.World);
            //transform.Rotate(lastRotation.eulerAngles, Space.World);
            //transform.Rotate(Camera.main.transform.rotation.eulerAngles, Space.World);
            //transform.Translate(Camera.main.transform.position);
        }

        if (Input.GetKeyDown("p"))
        {
            trackPosition = !trackPosition;
            lastPosition = Camera.main.transform.position;
            //InputTracking.disablePositionalTracking = !trackPosition;
            if (!trackPosition && !trackRotation)
                transform.localScale = Vector3.zero;
            else
                transform.localScale = Vector3.one;
        }

        if (!trackPosition && trackRotation)
        {
            transform.localPosition = lastPosition - Camera.main.transform.localPosition;
            //transform.Translate(lastPosition-Camera.main.transform.localPosition-transform.localPosition,Space.World);
        }
    }
}
