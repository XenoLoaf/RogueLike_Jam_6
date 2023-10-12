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

    [HideInInspector]
    public Transform Camera;
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
        
    }

    // Update is called once per frame
    void Update()
    {


        if (Camera == null)
        {
            Camera = GameObject.Find("Main Camera").transform;
        }
        else 
        {
            transform.position = Camera.position;
        }
    }
}
