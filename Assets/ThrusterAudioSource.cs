using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrusterAudioSource : MonoBehaviour
{
    public AudioClip[] rocketThruster;
    public AudioSource source;
    public SpaceShipMove spaceShipMove;
    public bool coolThrusters = false;
    public bool justReleased = false;
    private float originalVolume = 1f;

    private void Start()
    {
        source = GetComponent<AudioSource>();
        source.clip = rocketThruster[0];
        source.volume = 0f;
        source.Play();
        source.Pause();
        source.loop = true;
    }

    private void Update()
    {
        if (spaceShipMove.MovementType == "Rocket")
        {
            HandleThrusterInput();
        }
    }

    private void HandleThrusterInput()
    {
        bool thrusting = Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.DownArrow);
        
        if(thrusting)
        {
            source.volume = originalVolume;
        }

        if(thrusting && !source.isPlaying)
        {
            justReleased = true;
            coolThrusters = false;
            RocketThruster(true);
        }
        else if (!thrusting)
        {
            HandleThrusterCooling(thrusting);
        }
    }

    private void HandleThrusterCooling(bool thrusting)
    {
        coolThrusters = !thrusting;

        if(coolThrusters && justReleased)
        {
            source.volume -= 0.02f;
            if(source.volume <= 0.03f)
            {
                source.Pause();
                justReleased = false;
                source.volume = originalVolume;
                coolThrusters = false;
            }
        }
        else
        {
            source.volume = originalVolume;
        }
    }

    private void RocketThruster(bool thrust)
    {
        if(thrust)
        {
            source.volume = originalVolume;
            source.UnPause();
        }
        else
        {
            source.Pause();
        }
    }
}
