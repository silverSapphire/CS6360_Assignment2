using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class ToggleTracking : MonoBehaviour
{

    public bool trackRotation = true;
    public bool trackPosition = true;

    Vector3 lastPosition;

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
        }

        if(!trackRotation)
        {
            transform.rotation = Quaternion.Inverse(InputTracking.GetLocalRotation(XRNode.CenterEye));
        }

        if(Input.GetKeyDown("p"))
        {
            trackPosition = !trackPosition;
            lastPosition = transform.localPosition;
            //InputTracking.disablePositionalTracking = !trackPosition;
        }

        if (!trackPosition)
        {
            transform.localPosition = lastPosition - Camera.main.transform.localPosition;
            //transform.position = -InputTracking.GetLocalPosition(XRNode.CenterEye);
        }
    }
}
