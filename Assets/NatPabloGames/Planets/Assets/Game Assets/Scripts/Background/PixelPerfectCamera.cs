﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PixelPerfectCamera : MonoBehaviour
{
    /*
    // Script to figure out the display of the screen and accomodate so that everything scales accordingly
    public static float pixelsToUnits = 1f;
    public static float scale = 1f;

    public Vector2 nativeResolution = new Vector2 (1920, 1080);
    
    void Awake()
    {
        var camera = GetComponent<Camera>();

        if(camera.orthographic)
        {
            scale = Screen.height / nativeResolution.y;
            pixelsToUnits *= scale;
            camera.orthographicSize = (Screen.height / 2.0f) / pixelsToUnits;
        }
    }

    */
}