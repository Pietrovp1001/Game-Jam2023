using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.SceneManagement;

public class RestartScene: MonoBehaviour
{
    public PlayableDirector restart; 
    void Update()
    {
        if (Input.GetKeyDown("r"))
        {
            TimelineCaller(); 
        }
    }
    public void TimelineCaller()
    {
       restart.Play();
    }
    
    public void RestartLevel()
    {
        SceneManager.LoadScene("Player Test");
    }
}
