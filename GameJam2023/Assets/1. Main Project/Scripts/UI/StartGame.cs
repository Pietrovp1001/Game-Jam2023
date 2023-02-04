using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEditor.Animations;
using UnityEngine.Playables;

public class StartGame : MonoBehaviour
{
    public CanvasGroup SectionACanvas;
    public GameObject SectionA;
    public PlayableDirector StartCinematic;
    public Animator Music01;
    public void GameStart()
    {
        SectionACanvas.interactable = false; 
        StartCoroutine(Fadeout());
    }
    IEnumerator Fadeout()
    {
        
        SectionACanvas.DOFade(0f,0.5f).SetEase(Ease.InQuint);
        Music01.SetTrigger("FadeOutMusic");
        SectionACanvas.interactable = false; 
        yield return new WaitForSeconds(0.6f);
       
        StartCinematic.Play();
        
    }
    
    
}
