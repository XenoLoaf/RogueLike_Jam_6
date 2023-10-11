using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoliceInstance : MonoBehaviour
{
    public GameObject PoliceShip;
    float btwShip;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
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
