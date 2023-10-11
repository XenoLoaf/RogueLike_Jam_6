using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootPlayer : MonoBehaviour
{
    public GameObject[] Attacks;
    public float BtwShoot;
    public SpaceShipMove ShipMove;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        BtwShoot -= Time.deltaTime;
        if (Input.GetKey("a") && BtwShoot <= 0 && ShipMove.MovementType == "Rocket")
        {
            Instantiate(Attacks[0], transform.position, transform.rotation);
            BtwShoot = 0.25f;
        }
        else if (Input.GetKey("a") && BtwShoot <= 0 && ShipMove.MovementType == "Landed")
        {
            Instantiate(Attacks[1], transform.position, transform.rotation);
            BtwShoot = 0.8f;
        }
    }
}
