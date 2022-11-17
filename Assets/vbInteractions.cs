using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class VbInteractions : MonoBehaviour
{

    VirtualButtonBehaviour[] virtualButtonBehaviours;

    string vbName;

    public GameObject low_poly_earth, SecondPlanet, cube, cylinder;

    // Start is called before the first frame update
    void Start()
    {
        virtualButtonBehaviours = GetComponentsInParent<VirtualButtonBehaviour>();

        for (int i=0; i < virtualButtonBehaviours.Length;i++)
        {
            virtualButtonBehaviours[i].RegisterEventHandler(this);
        }
    }

    public void onButtonPressed(VirtualButtonBehaviour vb)
    {
        vbName = vb.VirtualButtonName;

        if (vbName == "VirtualButton1")
        {
            low_poly_earth.SetActive(true);
        }

        if (vbName == "VirtualButton2")
        {
            low_poly_earth.SetActive(false);
        }
    }

}
