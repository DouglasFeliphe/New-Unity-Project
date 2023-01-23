using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class VbShowHideText : MonoBehaviour, IVirtualButtonEventHandler
{
    public GameObject text;
    public VirtualButtonBehaviour Vb;
    private Color vbDefaultColor;

    // Start is called before the first frame update
    void Start()
    {
        text.SetActive(false);
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        Debug.Log("VbShowHideText OnButtonPressed");  
        
        // store the default color
        vbDefaultColor = vb.transform.GetChild(0).GetComponent<Renderer>().material.color;
        // change color of the button on press
        vb.transform.GetChild(0).GetComponent<Renderer>().material.color = Color.red;


        text.SetActive(true);
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        Debug.Log("VbShowHideText OnButtonReleased");

        vb.transform.GetChild(0).GetComponent<Renderer>().material.color = vbDefaultColor;

        text.SetActive(false);
    }
}
