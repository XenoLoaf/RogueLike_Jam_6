using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapShow : MonoBehaviour
{
        public GameObject Map;
    public GameObject MapTwo;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
                if (Input.GetKey(KeyCode.Tab))
        {
            Map.SetActive(true);
             MapTwo.SetActive(true);
        }
        else
        {
            Map.SetActive(false);
            MapTwo.SetActive(false);
        }
    }
}
