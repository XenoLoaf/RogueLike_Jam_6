using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetSpawner : MonoBehaviour
{
    public string TagToReloadFrom;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector2(Random.Range(-200, 200), Random.Range(-200, 200));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.transform.tag == TagToReloadFrom && other.transform.parent != transform)
        {
            transform.position = new Vector2(Random.Range(-200, 200), Random.Range(-200, 200));
        }
    }
}
