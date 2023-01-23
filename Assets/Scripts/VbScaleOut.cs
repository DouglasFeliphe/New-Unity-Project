using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class VbScaleOut : MonoBehaviour, IVirtualButtonEventHandler
{
    public VirtualButtonBehaviour Vb;
    private Color vbDefaultColor;
    public float planetScale = 0.001f;
    private bool _ZoomOut = false;
    private GameObject planets;

    void Start()
    {
        Vb.RegisterEventHandler(this);
        _ZoomOut = false;
        //get the list of planets by name
        planets = GameObject.Find("Planets");
    }

    // Update is called once per frame
    void Update()
    {
        if (_ZoomOut)
        {
            for (int i = 0; i < planets.transform.childCount; i++)
            {
                //verify if the planet is selected
                if (planets.transform.GetChild(i).GetComponent<PlanetSpin>().isSelected)
                {
                    //make a bigger object
                    planets.transform.GetChild(i).localScale -= new Vector3(planetScale, planetScale, planetScale);
                }
            }
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
