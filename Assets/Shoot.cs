using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public Rigidbody2D rb;
    public bool PlayerShoot;
    public Manager Manager;
    // Start is called before the first frame update
    void Start()
    {
        Manager = GameObject.Find("Manager").GetComponent<Manager>();
    }

    // Update is called once per frame
    void Update()
    {
        


        if (PlayerShoot)
        {
            transform.localScale = new Vector2(Manager.BulletSize * 5, Manager.BulletSize);
                    rb.AddForce(transform.up * Time.deltaTime * Manager.BulletSpeed, ForceMode2D.Impulse);
        }
        else 
        {
                    rb.AddForce(transform.up * Time.deltaTime * 30, ForceMode2D.Impulse);
        }
    }
}
