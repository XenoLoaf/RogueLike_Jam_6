using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamereLoader : MonoBehaviour
{
    public GameObject Camera;
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
        if (other.transform.tag == "Player")
        {
        Camera.SetActive(true);
        }
    }

        void OnTriggerExit2D(Collider2D other)
    {
        if (other.transform.tag == "Player")
        {
        Camera.SetActive(false);
        }
    }
}
