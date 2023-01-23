using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class VbScaleIn : MonoBehaviour, IVirtualButtonEventHandler
{
    //public GameObject planet;
    public VirtualButtonBehaviour Vb;
    private Color vbDefaultColor;
    public float planetScale = 0.001f;
    private bool _ZoomIn = false;
    private GameObject planets;


    // Start is called before the first frame update
    void Start()
    {
        Vb.RegisterEventHandler(this);
        _ZoomIn = false;

        //get the list of planets from the tag
        planets = GameObject.Find("Planets");
    }

    // Update is called once per frame
    void Update()
    {
        if (_ZoomIn)
        {


            for (int i = 0; i < planets.transform.childCount; i++)
            {
                //verify if the planet is selected
                if (planets.transform.GetChild(i).GetComponent<PlanetSpin>().isSelected)
                {
                    //make a bigger object
                    planets.transform.GetChild(i).localScale += new Vector3(planetScale, planetScale, planetScale);
                }
            }

        }      
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        Debug.Log("VbScaleIn OnButtonPressed");

        // store the default color
        vbDefaultColor = vb.transform.GetChild(0).GetComponent<Renderer>().material.color;
        // change color of the button on press
        vb.transform.GetChild(0).GetComponent<Renderer>().material.color = Color.red;

        _ZoomIn = true;
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        Debug.Log("VbScaleIn OnButtonReleased");

        vb.transform.GetChild(0).GetComponent<Renderer>().material.color = vbDefaultColor;

        _ZoomIn = false;
    }
}
