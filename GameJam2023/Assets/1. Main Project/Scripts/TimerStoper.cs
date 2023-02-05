using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerStoper : MonoBehaviour
{
    public Timer timer;
    
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            timer.isRunning = false;
        }
    }
    
}
