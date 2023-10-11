using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourcePart : MonoBehaviour
{
    public MineableResource Parent;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.transform.tag == "Bullet")
        {
            Parent.ResourceParts -= 1;
            Destroy(this.gameObject);
            Destroy(other.gameObject);
        }
    }
        void OnParticleCollision(GameObject other)
    {
        if (other.transform.tag == "Bullet")
        {
            Parent.ResourceParts -= 1;
            Destroy(this.gameObject);
            Destroy(other.gameObject);
        }
    }
}