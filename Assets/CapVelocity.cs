using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapVelocity : MonoBehaviour
{
    public Rigidbody2D rb;
    public float MaxVelocity;
    public float UncappedVelocity;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (UncappedVelocity <= 0)
        {
            if (rb.velocity.x >= MaxVelocity)
        {
            rb.velocity = new Vector2(MaxVelocity, rb.velocity.y);
        }
            if (rb.velocity.x <= -MaxVelocity)
        {
            rb.velocity = new Vector2(-MaxVelocity, rb.velocity.y);
        }
            if (rb.velocity.y >= MaxVelocity)
        {
            rb.velocity = new Vector2(rb.velocity.x, MaxVelocity);
        }
            if (rb.velocity.y <= -MaxVelocity)
        {
            rb.velocity = new Vector2(rb.velocity.x, -MaxVelocity);
        }
        }
    }
}
