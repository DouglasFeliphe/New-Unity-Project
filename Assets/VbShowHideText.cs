using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class VbShowHideText : MonoBehaviour, IVirtualButtonEventHandler
{
    public GameObject text;
    public VirtualButtonBehaviour Vb;
    // Start is called before the first frame update
    void Start()
    {
        text.SetActive(false);
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        Debug.Log("VbShowHideText OnButtonPressed");
        text.SetActive(true);
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        Debug.Log("VbShowHideText OnButtonReleased");
        text.SetActive(false);
    }
}
