using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VolumeControl : MonoBehaviour
{
    public GameObject VolumeSlider;
    private AudioSource m_AudioSource;
    public float VolumeLevel;

    void Start()
    {
        m_AudioSource = this.gameObject.GetComponent<AudioSource>();
        VolumeLevel = m_AudioSource.volume;
    }
}
