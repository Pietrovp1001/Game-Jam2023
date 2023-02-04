using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
public class FpsLimit : MonoBehaviour
{
    [SerializeField] private TMP_Dropdown dropdown;
    void Start()
    {
        JsonSaveLoadSystem.Instance.Load();
        dropdown.value = JsonSaveLoadSystem.Instance.JsonPlayerInfo.ddvFrames;
        AjustarFps();
    }
    public void AjustarFps()
    {
        FPS();
        Application.targetFrameRate = JsonSaveLoadSystem.Instance.JsonPlayerInfo.fpsFrameRate;
    }
    public void FPS()
    {
        if(dropdown.value == 0)
        {
            JsonSaveLoadSystem.Instance.JsonPlayerInfo.ddvFrames = 0;
            JsonSaveLoadSystem.Instance.JsonPlayerInfo.fpsFrameRate = -1;
        }
        if (dropdown.value == 1)
        {
            JsonSaveLoadSystem.Instance.JsonPlayerInfo.ddvFrames = 1;
            JsonSaveLoadSystem.Instance.JsonPlayerInfo.fpsFrameRate = 60;
        }
        if (dropdown.value == 2)
        {
            JsonSaveLoadSystem.Instance.JsonPlayerInfo.ddvFrames = 2;
            JsonSaveLoadSystem.Instance.JsonPlayerInfo.fpsFrameRate = 30;
        }
        JsonSaveLoadSystem.Instance.Save();
    }
}
