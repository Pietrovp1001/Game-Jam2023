using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.SceneManagement;
public class FInalCutscene : MonoBehaviour
{
    public PlayableDirector StartFINAL;
    public string LevelName; 
    void Start()
    {
        
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("CINEMATIC");
            StartFINAL.Play();
        }
    }
    
    public void FinalCutscene()
    {
        SceneManager.LoadScene(LevelName);
    }
}
