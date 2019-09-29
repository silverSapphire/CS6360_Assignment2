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
            transform.localRotation = Quaternion.Inverse(InputTracking.GetLocalRotation(XRNode.CenterEye));
        }

        if(Input.GetKeyDown("p"))
        {
            trackPosition = !trackPosition;
            
            if (trackPosition)
                transform.localScale = Vector3.one;
            else
                transform.localScale = Vector3.zero;

        }

        if (!trackPosition)
        {
            //Debug.Log("Not tracking position!");
            //Vector3 deltaPosition = lastPosition - Camera.main.transform.position;
            //Camera.main.transform.SetPositionAndRotation(Camera.main.transform.position + deltaPosition,
            //    Camera.main.transform.rotation);
            //Camera.main.transform.position += deltaPosition ;
            //transform.localPosition = lastPosition - Camera.main.transform.localPosition;
            //transform.position = -InputTracking.GetLocalPosition(XRNode.CenterEye);

            //Matrix4x4 m = Matrix4x4.TRS(new Vector3(0, -1000, 0), Quaternion.identity, new Vector3(1, 1, -1));
            //Camera.main.worldToCameraMatrix = m * Camera.main.transform.worldToLocalMatrix;
        }

        //lastPosition = Camera.main.transform.position;
    }
}
