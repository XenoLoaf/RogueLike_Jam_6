using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDetection : MonoBehaviour
{
    public Manager Manager;
    public GameObject This;
    // Start is called before the first frame update
    void Start()
    {
        Manager = GameObject.Find("Manager").GetComponent<Manager>();
    }

    // Update is called once per frame
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
        if (other.transform.tag == "Player")
        {
            Resources Resources = other.gameObject.GetComponent<Resources>();
            PickUpAbleObject PickUpAbleObject = Resources.Carrying.GetComponent<PickUpAbleObject>();
            if (PickUpAbleObject.ItemType == "Contraband")
            {
                Manager.WantedLevel += 1;
            }
        }
    }
}
