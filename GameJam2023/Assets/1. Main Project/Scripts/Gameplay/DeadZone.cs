using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Playables;

public class DeadZone : MonoBehaviour
{
    public PlayableDirector restart;
    public GameObject restartButton; 
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("CINEMATIC");
            restart.Play();
        }
    }
}
