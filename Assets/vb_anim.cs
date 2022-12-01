using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class vb_anim : MonoBehaviour, IVirtualButtonEventHandler
{

    public GameObject vbBtnObj;
    public Animator earthAnim;

    void Start()
    {
        vbBtnObj = GameObject.Find("BotaoVirtual");
        vbBtnObj.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        earthAnim.GetComponent<Animator>();
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        earthAnim.Play("zoom_earth");
        Debug.Log("Btn Pressed");
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        earthAnim.Play("unzoom_earth");
        Debug.Log("Btn Released");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
