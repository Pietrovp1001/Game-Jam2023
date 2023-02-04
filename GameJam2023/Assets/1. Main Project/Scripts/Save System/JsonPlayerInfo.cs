using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class JsonPlayerInfo
{

    public int firstTime;
    public int fpsFrameRate;
    public int ddvFrames;

    public JsonPlayerInfo()
    {
        
        firstTime = 0;
        fpsFrameRate = -1;
        ddvFrames = 0;

    }
}
