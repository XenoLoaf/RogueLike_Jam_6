using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticalDamageRessources : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnParticleCollision(GameObject other)
    {
        if (other.transform.tag == "RessourcePart")
        {
            MineableResource Parent = other.transform.parent.GetComponent<MineableResource>();
            Parent.ResourceParts -= 1;
            Destroy(other.gameObject);
            Debug.Log("Show");
        }
    }
}
