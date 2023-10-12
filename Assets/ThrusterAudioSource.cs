using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrusterAudioSource : MonoBehaviour
{
    public AudioClip[] rocketThruster;
    public AudioSource source;
    public SpaceShipMove spaceShipMove;
    public bool coolThrusters = false;
    private float originalVolume = 1f;

    private void Start()
    {
        source = GetComponent<AudioSource>();
        source.clip = rocketThruster[0];
        originalVolume = source.volume;
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

        if (thrusting && !source.isPlaying)
        {
            source.volume = 1f;
            RocketThruster(true);
            coolThrusters = false;
        }
        else if (!thrusting)
        {
            HandleThrusterCooling();
            source.Stop();
        }
    }

    private void HandleThrusterCooling()
    {
        if (coolThrusters)
        {
            Cooldown();
        }
        else
        {
            source.volume = originalVolume;
        }
    }

    private void RocketThruster(bool thrust)
    {
        if (thrust)
        {
            source.PlayOneShot(rocketThruster[0], 1f);
        }
        else
        {
            source.Stop();
        }
    }

    private void Cooldown()
    {
        if (source.volume >= 0.3f && source.volume <= 0.9f)
        {
            source.volume -= 0.02f;
        }
        else
        {
            source.volume = originalVolume;
        }
    }
}
