using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class VbScaleOut : MonoBehaviour, IVirtualButtonEventHandler
{
    public GameObject planet;
    public VirtualButtonBehaviour Vb;
    private Color vbDefaultColor;
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
        Debug.Log("VbScaleOut OnButtonPressed");

        // store the default color
        vbDefaultColor = vb.transform.GetChild(0).GetComponent<Renderer>().material.color;
        // change color of the button on press
        vb.transform.GetChild(0).GetComponent<Renderer>().material.color = Color.red;

        _ZoomOut = true;
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        Debug.Log("VbScaleOut OnButtonReleased");

        vb.transform.GetChild(0).GetComponent<Renderer>().material.color = vbDefaultColor;

        _ZoomOut = false;
    }
}
