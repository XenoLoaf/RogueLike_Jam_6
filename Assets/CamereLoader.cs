using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamereLoader : MonoBehaviour
{
    public GameObject Camera;

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
