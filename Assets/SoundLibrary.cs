using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundLibrary : MonoBehaviour
{
    public AudioClip[] Sfx;
    public AudioClip[] rocketThruster;
    public AudioClip[] laserShot;
    public AudioClip[] explosion;
    public AudioSource Source;

    public void StopSound()
    {

    }

    public void Play(int Sound)
    {
        Source.PlayOneShot(Sfx[Sound], 0.75f);
    }

    public void LaserShot(int Sound)
    {
        Source.PlayOneShot(laserShot[Sound], 0.75f);
    }

    public void Explosion(int Sound)
    {
        Source.PlayOneShot(explosion[Sound], 0.75f);
    }
}
