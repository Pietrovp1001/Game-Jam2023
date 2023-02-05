using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class FadeController2 : MonoBehaviour
{
    public CanvasGroup FadePanel; 
    void Start()
    {
        FadePanel.alpha = 0f; 
        FadePanel.DOFade(1f, 2f).SetEase(Ease.InQuint);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
