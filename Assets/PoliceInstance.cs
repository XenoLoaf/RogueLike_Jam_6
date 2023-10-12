using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoliceInstance : MonoBehaviour
{
    public GameObject PoliceShip;
    float btwShip;

    void Update()
    {
        btwShip -= Time.deltaTime;

        if (btwShip <= 0)
        {
            Instantiate(PoliceShip, transform.position, transform.rotation);
            btwShip = 6;
        }
    }
}
