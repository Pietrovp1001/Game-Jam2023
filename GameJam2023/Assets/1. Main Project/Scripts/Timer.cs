using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class Timer : MonoBehaviour
{
        
    public TextMeshProUGUI timerText;
    public float startTime;
    public bool isRunning = false;
    
    private void Update()
    {

        if (isRunning)
        {
            float t = Time.time - startTime;
            string minutes = ((int) t / 60).ToString();
            string seconds = (t % 60).ToString("f2");
            timerText.text = minutes + ":" + seconds; 
        }

    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            isRunning = true;
            startTime = Time.time;
        }
    }
    

}
