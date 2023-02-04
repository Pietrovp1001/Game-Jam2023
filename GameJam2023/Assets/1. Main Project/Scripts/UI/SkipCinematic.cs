using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SkipCinematic : MonoBehaviour
{
    private bool isPaused = false;
    public GameObject pausePanel; 
    public string sceneName; 
    private void Start()
    {
        isPaused = false; 
    }

    void Update()
    {
        if (isPaused = false) ; 
        {
            if (Input.GetKeyDown("escape"))
            {
                pausePanel.SetActive(true);
                isPaused = true; 
                Time.timeScale = 0f;
                Debug.Log("¿Saltar cinematica?"); 
            }

        }
        
    }
    public void NoSkip()
    {
        pausePanel.SetActive(false);
        isPaused = false; 
        Time.timeScale = 1f; 
    }
    public void SkipCutscene()
    {
        SceneManager.LoadScene(sceneName); 
    }
    
}
