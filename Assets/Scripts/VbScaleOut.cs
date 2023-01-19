using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class VbScaleOut : MonoBehaviour, IVirtualButtonEventHandler
{
    public GameObject planet;
    public VirtualButtonBehaviour Vb;
    public float planetScale = 0.001f;
    private bool _ZoomOut = false;

    void Start()
    {
        Vb.RegisterEventHandler(this);
        _ZoomOut = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (_ZoomOut)
        {
            //make a bigger object
            planet.transform.localScale -= new Vector3(planetScale, planetScale, planetScale);
        }
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        Debug.Log("OnButtonPressed");
        _ZoomOut = true;
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        Debug.Log("OnButtonReleased");
        _ZoomOut = false;
    }
}
