using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrusterAudioSource : MonoBehaviour
{
    public AudioClip[] rocketThruster;
    public AudioSource Source;
    public SpaceShipMove SpaceShipMove;

    public void Start()
    {
        Source = this.gameObject.GetComponent<AudioSource>();
        Source.clip = rocketThruster[0];
    }

    public void RocketThruster(bool Thrust)
    {
        if(Thrust == true)
        {
            Source.PlayOneShot(rocketThruster[0], 0.75f);
        }
        
        if(Thrust == false)
        {
            Source.Stop();
        } 
    }

    public void Update()
    {
        if(SpaceShipMove.MovementType == "Rocket")
        {
            if(Input.GetKey(KeyCode.UpArrow) && !Source.isPlaying)
            {
                RocketThruster(true);
            }

            if(Input.GetKey(KeyCode.DownArrow) && !Source.isPlaying)
            {
                RocketThruster(true);
            }

            if (Input.GetKeyUp(KeyCode.UpArrow))
            {
                RocketThruster(false);
            }

            if (Input.GetKeyUp(KeyCode.DownArrow))
            {
                RocketThruster(false);
            }
        }
    }
}
