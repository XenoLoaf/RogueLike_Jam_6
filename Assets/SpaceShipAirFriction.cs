using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceShipAirFriction : MonoBehaviour
{
    public Rigidbody2D rb;
    public float Friction;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (rb.velocity.x >= 0 && Input.GetKey(KeyCode.UpArrow) == false && Input.GetKey(KeyCode.DownArrow) == false)
        {
            rb.velocity = new Vector2(rb.velocity.x - Friction, rb.velocity.y);
        }
        if (rb.velocity.x <= 0 && Input.GetKey(KeyCode.UpArrow) == false && Input.GetKey(KeyCode.DownArrow) == false)
        {
            rb.velocity = new Vector2(rb.velocity.x + Friction, rb.velocity.y);
        }
        if (rb.velocity.y >= 0 && Input.GetKey(KeyCode.UpArrow) == false && Input.GetKey(KeyCode.DownArrow) == false)
        {
            rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y - Friction);
        }
        if (rb.velocity.y <= 0 && Input.GetKey(KeyCode.UpArrow) == false && Input.GetKey(KeyCode.DownArrow) == false)
        {
            rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y + Friction);
        }

        if (rb.velocity.x  <= 0.25f && rb.velocity.x  >= -0.25f && Input.GetKey(KeyCode.UpArrow) == false && Input.GetKey(KeyCode.DownArrow) == false)
        {
            rb.velocity = new Vector2(0, rb.velocity.y);
        }
        
        if (rb.velocity.y <= 0.25f && rb.velocity.y >= -0.25f && Input.GetKey(KeyCode.UpArrow) == false && Input.GetKey(KeyCode.DownArrow) == false)
        {
            rb.velocity = new Vector2(rb.velocity.x, 0);
        }
    }
}
