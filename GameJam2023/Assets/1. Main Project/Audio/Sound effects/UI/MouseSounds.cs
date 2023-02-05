using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseSounds : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip hoverSFX;
    public AudioClip clickSFX; 
    
    public void HoverSound()
    {
        audioSource.PlayOneShot(hoverSFX);
    }
    public void ClickSound()
    {
        audioSource.PlayOneShot(clickSFX);
    }
    
}
