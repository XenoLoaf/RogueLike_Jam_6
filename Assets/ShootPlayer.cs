using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootPlayer : MonoBehaviour
{
    public GameObject[] Attacks;
    public float BtwShoot;
    public SpaceShipMove ShipMove;
    public SoundLibrary SoundLibrary;

    void Start()
    {
        SoundLibrary = GameObject.Find("SoundLibrary").GetComponent<SoundLibrary>();
    }

    void Update()
    {
        BtwShoot -= Time.deltaTime;
        if(Input.GetKey("a") && BtwShoot <= 0 && ShipMove.MovementType == "Rocket")
        {
            Instantiate(Attacks[0], transform.position, transform.rotation);
            BtwShoot = 0.25f;
            SoundLibrary.LaserShot();
        }
        else if(Input.GetKey("a") && BtwShoot <= 0 && ShipMove.MovementType == "Landed")
        {
            Instantiate(Attacks[1], transform.position, transform.rotation);
            BtwShoot = 0.8f;
            SoundLibrary.LaserShot(3);
        }
    }
}
