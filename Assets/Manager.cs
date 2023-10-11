using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public int WantedLevel;
    public bool Battling;
    public float SpeedGrounded;
    public float Hp;
    public float BulletSize;
    public float BulletSpeed;
    public float DamageInvincability;
    public GameObject Map;
    public GameObject MapTwo;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Tab))
        {
            Map.SetActive(true);
             MapTwo.SetActive(true);
        }
        else
        {
            Map.SetActive(false);
            MapTwo.SetActive(false);
        }
    }
}
