﻿/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class VbInteractions : MonoBehaviour, IVirtualButtonEventHandler
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

    public void OnButtonReLeased(VirtualButtonBehaviour vb)
    {
        earthAnim.Play("none");
        Debug.Log("Btn Pressed");
    }


}
*/
