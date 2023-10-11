using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MineableResource : MonoBehaviour
{
    public int ResourceParts;
    public GameObject[] Drops;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (ResourceParts <= 0)
        {
            Instantiate(Drops[Random.Range(0, Drops.Length)], transform.position, transform.rotation);
            Destroy(this.gameObject);
        }
    }
}
