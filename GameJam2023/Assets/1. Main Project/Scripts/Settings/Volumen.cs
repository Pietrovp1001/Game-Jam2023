using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Volumen : MonoBehaviour
{
    [SerializeField] private Slider slider;
    [SerializeField] private float sliderValue;
    [SerializeField] private Image muteImage;
    void Start()
    {
        slider.value = PlayerPrefs.GetFloat("volumen", 0.5f);
        AudioListener.volume = slider.value;
        IfMuted();
    }
    public void ChangeSlider(float valor)
    {
        sliderValue = valor;
        PlayerPrefs.SetFloat("volumen", sliderValue);
        AudioListener.volume = sliderValue;
        IfMuted();
    }
    public void IfMuted()
    {
        if (sliderValue == 0)
        {
            muteImage.enabled = true;
        }
        else
        {
            muteImage.enabled = false;
        }
    }
}
