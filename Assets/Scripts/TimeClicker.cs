﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class TimeClicker : MonoBehaviour
{
    public Image ImgCirculo;
    public UnityEvent GVRClick;
    public float totalTime = 2;
    bool gvrStatus;
    public float gvrTimer;


    // Update is called once per frame
    void Update()
    {
        if (gvrStatus)
        {
            gvrTimer += Time.deltaTime;
            ImgCirculo.fillAmount = gvrTimer / totalTime;
        }
        if(gvrTimer > totalTime)
        {
            GVRClick.Invoke();
        }
        
    }

    public void GvrOn()
    {
        gvrStatus = true;
    }
    public void GvrOff()
    {
        gvrStatus = false;
        gvrTimer = 0;
        ImgCirculo.fillAmount = 0;

    }
}
