using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RelaxButton : MonoBehaviour
{

    public AudioSource audioSource;
    public Slider slider;
    public bool RelaxButtonClicked = false;

    public void AddVol()
    {
        audioSource.volume += 0.003f;
        slider.value = audioSource.volume;
        RelaxButtonClicked = true;
    }

    public void AddingVol()
    {
        if(RelaxButtonClicked == true && audioSource.volume <= 0.75f)
        {
            audioSource.volume += 0.003f;
            slider.value = audioSource.volume;
            if(audioSource.volume >= 0.75f)
            {
                RelaxButtonClicked = false;
            }
        }

    }

    public void Update()
    {
        AddingVol();
    }
}
