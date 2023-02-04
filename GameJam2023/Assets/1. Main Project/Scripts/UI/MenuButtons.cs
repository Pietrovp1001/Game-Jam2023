using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuButtons : MonoBehaviour
{
    
    public void ExitGame()
    {
        Debug.Log("Juego finalizado"); 
        Application.Quit();
    }
    
}
