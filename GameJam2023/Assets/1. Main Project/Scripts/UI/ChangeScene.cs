using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ChangeScene : MonoBehaviour
{
    public GameObject skipCinematic;
    public string sceneName;
    void Start()
    {
        Time.timeScale = 1f; 
        skipCinematic.SetActive(false);
        SceneManager.LoadScene(sceneName); 
        
    }
    
}
