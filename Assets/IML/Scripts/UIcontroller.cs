using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using OVR;
using UnityEngine.UI;
public class UIcontroller : MonoBehaviour
{
    [SerializeField] private GameObject Canvas;
    [SerializeField] private GameObject GazePointer;
    //Below will enable/ disable the canvas (true = enable)
    [SerializeField] private bool EnableMenuCanvas;

    // Start is called before the first frame update
    void Start()
    {
        //Hide the Canvas UI and UI selecter by default
        Canvas.SetActive(false);
        GazePointer.SetActive(false);
    }

   public void ToggleUI()
    {
        if (Canvas.activeSelf)
        {
            Canvas.SetActive(false);
            GazePointer.SetActive(false);
        }
        else
        {
            Canvas.SetActive(true);
        }
    }

    
    // Update is called once per frame
    void Update()
    {
        //Use Button Two (B) to show or hide Canvas UI, will close if open or open is closed
        if (EnableMenuCanvas==true)
        {

        
        if (OVRInput.GetUp(OVRInput.Button.Two))
        {
            ToggleUI();
        }
        }
    }

  
}
