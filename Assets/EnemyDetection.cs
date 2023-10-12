using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDetection : MonoBehaviour
{
    public Manager Manager;
    public GameObject This;

    void Start()
    {
        Manager = GameObject.Find("Manager").GetComponent<Manager>();
    }

    void Update()
    {
        if (Manager.WantedLevel >= 2)
        {
            This.SetActive(false);
        }
        else
        {
            This.SetActive(true);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.transform.tag == "Player")
        {
            print(other);
            // Resources Resources = other.gameObject.GetComponent<Resources>();
            // PickUpAbleObject PickUpAbleObject = Resources.Carrying.GetComponent<PickUpAbleObject>();
            // if(PickUpAbleObject.ItemType == "Contraband")
            // {
            //     Manager.WantedLevel += 1;
            // }
            // else {} 
        }
        else {}
    }
}
