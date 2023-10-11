using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyState : MonoBehaviour
{
    public GameObject Player;
    public bool PlayerInRange;
    public Manager Manager;
    // Start is called before the first frame update
    void Awake()
    {
        Manager = GameObject.Find("Manager").GetComponent<Manager>();
        Player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 PlayerPosition = Player.transform.position;
        Vector2 ThisPosition = transform.position;
        float Distance = Vector2.Distance(ThisPosition, PlayerPosition);
        if (Distance <= 75)
        {
            PlayerInRange = true;
        }
        else 
        {
            PlayerInRange = false;
        }
    }
}
