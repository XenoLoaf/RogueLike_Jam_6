using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetEnemyChild : MonoBehaviour
{
    float StartTimer = 0.1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        StartTimer -= Time.deltaTime;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.transform.tag == "Enemy" && StartTimer >= 0)
        {
            transform.parent = other.gameObject.transform;
        }
    }
}
