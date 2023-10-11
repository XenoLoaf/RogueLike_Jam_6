using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resources : MonoBehaviour
{
    public float ShipFuel;
    public float Hunger;
    public GameObject Carrying;
    public Vector2 CarryPosition;
    public float BtwPickup;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        BtwPickup -= Time.deltaTime;
        CarryPosition = new Vector2(transform.position.x, transform.position.y + 1.5f);
        Carrying.transform.position = CarryPosition;

        if (Carrying != null && Input.GetKey("q") && BtwPickup <= 0)
        {
            Carrying = null;
            BtwPickup = 0.5f;
        }

        Carrying.layer = this.gameObject.layer;
    }

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.transform.tag == "CarryAble" && Input.GetKeyDown("q") && BtwPickup <= 0)
        {
            Carrying = other.gameObject;
            BtwPickup = 0.5f;
        }
    }
}
