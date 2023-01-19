using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class CameraFollower : MonoBehaviour, IVirtualButtonEventHandler
{
    public VirtualButtonBehaviour Vb;
    public Transform target;
    public float smoothSpeed = 0.125f;
    private bool wasVbPressed;

    void Start()
    {
        Vb.RegisterEventHandler(this);
        //planet.SetActive(false);
        wasVbPressed = false;
    }

    private void Update()
    {
        if (wasVbPressed)
        {
            Debug.Log("camera is following");
            Vector3 desiredPosition = target.position;
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
            transform.position = smoothedPosition;
        }
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        Debug.Log("OnButtonPressed");
        wasVbPressed = true;
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        Debug.Log("OnButtonReleased");
        wasVbPressed = false;
    }
}
