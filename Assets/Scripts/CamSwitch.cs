using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CamSwitch : MonoBehaviour
{
    public Camera cam1;
    public Camera cam2;
    public bool switchCam = false;
    private Camera activeCamera;
    public void SwitchCamera()
    {
        if(!switchCam)
        {
            cam2.gameObject.SetActive(true);
            cam1.gameObject.SetActive(false);
            switchCam = true;
        }
        else
        {
            cam1.gameObject.SetActive(true);
            cam2.gameObject.SetActive(false);
            switchCam = false;
        }
    }
}
