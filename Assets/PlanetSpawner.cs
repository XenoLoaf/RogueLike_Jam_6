using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetSpawner : MonoBehaviour
{
    public string TagToReloadFrom;

    void Awake()
    {
        transform.position = new Vector2(Random.Range(-200, 200), Random.Range(-200, 200));
    }

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.transform.tag == TagToReloadFrom && other.transform.parent != transform)
        {
            transform.position = new Vector2(Random.Range(-200, 200), Random.Range(-200, 200));
        }
    }
}
