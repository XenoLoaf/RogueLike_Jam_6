using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAt : MonoBehaviour
{
    public GameObject Target;
    public string TargetName;
    // Start is called before the first frame update
    void Start()
    {
        Target = GameObject.Find(TargetName);
    }

    // Update is called once per frame
    void Update()
    {
        transform.up = Target.transform.position - transform.position;
    }
}
