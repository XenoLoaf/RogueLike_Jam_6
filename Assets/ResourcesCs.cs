using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourcesCs : MonoBehaviour
{
    public float ShipFuel;
    public float Hunger;
    public GameObject Carrying;
    public GameObject CarryEmpty;

    public GameObject MerchantIndicator;
    public GameObject Merchant;
    public float deactivationDistance = 3f;
    
    public Vector2 CarryPosition;
    public float BtwPickup;

    void Awake()
    {
        CarryPosition = new Vector2(0, 0);
        MerchantIndicator.SetActive(false);
    }

    void Update()
    {
        BtwPickup -= Time.deltaTime;
        if (Carrying != null)
        {
        CarryPosition = new Vector2(transform.position.x, transform.position.y + 1.5f);
        Carrying.transform.position = CarryPosition;
        Carrying.layer = this.gameObject.layer;
        }

        if (Carrying != null && Input.GetKey("q") && BtwPickup <= 0)
        {
            Carrying = null;
            BtwPickup = 0.5f;
            MerchantIndicator.SetActive(false);
        }

        if(Carrying != null)
        {
            float distanceToMerchant = Vector3.Distance(MerchantIndicator.transform.position, Merchant.transform.position);
            if (distanceToMerchant <= deactivationDistance)
            {
                MerchantIndicator.SetActive(false);
            }
            else
            {
                MerchantIndicator.SetActive(true);
            }
        }
    }

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.transform.tag == "CarryAble" && Input.GetKeyDown("q") && BtwPickup <= 0 && Carrying == null)
        {
            Carrying = other.gameObject;
            BtwPickup = 0.5f;
            MerchantIndicator.SetActive(true);
        }
    }
}
