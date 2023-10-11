using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetResourceSpawning : MonoBehaviour
{
    public GameObject[] Resources;
    public float XArea;
    public float YArea;
    public int AmountToSpawn;
    float StartWait = 2;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        StartWait -= Time.deltaTime;
        if (AmountToSpawn >= 0 && StartWait <= 0)
        {
            Vector2 ThisPosition = transform.position;
            Instantiate(Resources[Random.Range(0, Resources.Length)], ThisPosition += new Vector2(Random.Range(-XArea , XArea ) ,Random.Range(-XArea, XArea)), transform.rotation);
            AmountToSpawn -= 1;
        }
    }
}
