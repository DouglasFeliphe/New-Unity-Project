using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class VbScaleIn : MonoBehaviour, IVirtualButtonEventHandler
{
    public GameObject planet;
    public VirtualButtonBehaviour Vb;
    public float planetScale = 0.001f;
    private bool _ZoomIn = false;
   

    // Start is called before the first frame update
    void Start()
    {
        Vb.RegisterEventHandler(this);        
        _ZoomIn = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (_ZoomIn)
        {
            //make a bigger object
            planet.transform.localScale += new Vector3(planetScale, planetScale, planetScale);
        }      
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        Debug.Log("OnButtonPressed");   
         _ZoomIn = true;
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        Debug.Log("OnButtonReleased");     
         _ZoomIn = false;
    }
}
