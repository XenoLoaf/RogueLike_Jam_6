using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsObjectFlying : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         Physics2D.IgnoreLayerCollision(6, 7, true);
    }
}
