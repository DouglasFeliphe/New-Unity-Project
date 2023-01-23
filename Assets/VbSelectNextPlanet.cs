using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class VbSelectNextPlanet : MonoBehaviour, IVirtualButtonEventHandler
{
    public VirtualButtonBehaviour Vb;
    private Color vbDefaultColor; // reference to the virtual button
    private GameObject planetList; // reference to the array of planets with the "Planets" tag
    public int currentPlanet = 0; // the index of the currently selected planet
    private int maxPlanet; // the total number of planets in the list

    private void Start()
    {
        // register event handler
        Vb.RegisterEventHandler(this);
        //get the list of planets from the tag
        planetList = GameObject.Find("Planets");
        maxPlanet = planetList.transform.childCount;
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {

        // store the default color
        vbDefaultColor = vb.transform.GetChild(0).GetComponent<Renderer>().material.color;
        // change color of the button on press
        vb.transform.GetChild(0).GetComponent<Renderer>().material.color = Color.red;

        // deactivate the current planet
        planetList.transform.GetChild(currentPlanet).gameObject.GetComponent<PlanetSpin>().isSelected = false;
        // increment the current planet index
        currentPlanet++;
        if (currentPlanet >= maxPlanet)
        {
            currentPlanet = 0;
        }
        // activate the next planet
        planetList.transform.GetChild(currentPlanet).gameObject.GetComponent<PlanetSpin>().isSelected = true;
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        // restore the default color
        vb.transform.GetChild(0).GetComponent<Renderer>().material.color = vbDefaultColor;
    }
}
