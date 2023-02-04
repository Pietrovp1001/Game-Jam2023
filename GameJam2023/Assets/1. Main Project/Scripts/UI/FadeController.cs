using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class FadeController : MonoBehaviour
{
    public CanvasGroup FadePanel; 
    void Start()
    {
        FadePanel.alpha = 1f; 
        FadePanel.DOFade(0f, 2f).SetEase(Ease.InQuint);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
