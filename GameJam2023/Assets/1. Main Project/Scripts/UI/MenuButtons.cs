using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.EventSystems; 

public class MenuButtons : MonoBehaviour
{
    public CanvasGroup SectionACanvas;
    public CanvasGroup SectionBCanvas;
    public GameObject SectionA;
    public GameObject SectionB;
    public GameObject MenuFirstButton; 

    public void HideSection()
    {
        
        SectionBCanvas.interactable = false; 
        SectionBCanvas.alpha = 0f; 
        SectionB.SetActive(true);
        
        StartCoroutine(Fadeout());
    }
    IEnumerator Fadeout()
    {
        SectionACanvas.DOFade(0f,0.5f).SetEase(Ease.InQuint);
        SectionACanvas.interactable = false; 
        yield return new WaitForSeconds(0.5f);
        SectionBCanvas.interactable = true;
        var eventSystem = EventSystem.current;
        eventSystem.SetSelectedGameObject(MenuFirstButton, new BaseEventData(eventSystem));
        SectionA.SetActive(false);
        SectionBCanvas.DOFade(1f, 0.5f).SetEase(Ease.InQuint);
    }

    public void ExitGame()
    {
        Debug.Log("Juego finalizado"); 
        Application.Quit();
    }
    
}
