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

    public void TakeDamage()
    {
        Source.PlayOneShot(Sfx[0], 0.75f);
    }

    public void LaserShot()
    {
        int LaserSound = Random.Range(0,2);
        Source.PlayOneShot(laserShot[LaserSound], 1f);
    }
    public void LaserShot(int sound)
    {
        Source.PlayOneShot(laserShot[sound], 0.75f);
    }

    public void Explosion()
    {
        Source.PlayOneShot(explosion[0], 0.75f);
    }
}
