using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootPlayer : MonoBehaviour
{
    public GameObject[] Attacks;
    public float BtwShoot;
    public SpaceShipMove ShipMove;
    public SoundLibary SoundLibary;
    // Start is called before the first frame update
    void Start()
    {
        SoundLibary = GameObject.Find("SoundLibary").GetComponent<SoundLibary>();
    }

    // Update is called once per frame
    void Update()
    {
        BtwShoot -= Time.deltaTime;
        if (Input.GetKey("a") && BtwShoot <= 0 && ShipMove.MovementType == "Rocket")
        {
            Instantiate(Attacks[0], transform.position, transform.rotation);
            BtwShoot = 0.25f;
            SoundLibary.SoundToPlay = 0;
            SoundLibary.Play();
        }
        else if (Input.GetKey("a") && BtwShoot <= 0 && ShipMove.MovementType == "Landed")
        {
            Instantiate(Attacks[1], transform.position, transform.rotation);
            BtwShoot = 0.8f;
            SoundLibary.SoundToPlay = 1;
            SoundLibary.Play();
        }
    }
}
