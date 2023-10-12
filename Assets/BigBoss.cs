using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigBoss : MonoBehaviour
{
    public GameObject[] Cannons;
    public GameObject[] Bullets;
    public Rigidbody2D rb;
    public EnemyHpSystem EnemyHpSystem;
    public float Speed;
    float BtwMovement;
    public GameObject Render;
    GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        BtwMovement -= Time.deltaTime;
        if (EnemyHpSystem.Hp >= 25)
        {
            FirstStage();
        }
        else
        {
            SecondStage();
        }
    }

    void  FirstStage()
    {
        if (BtwMovement <= 0)
        {
            BtwMovement = 3;
            int Direction = Random.Range(1, 5);

            if (Direction == 1)
            {
                rb.velocity = new Vector2(0, Speed);
                Render.transform.rotation = Quaternion.Euler(0, 0, 0);
            }

            if (Direction == 2)
            {
                rb.velocity = new Vector2(0, -Speed);
                                Render.transform.rotation = Quaternion.Euler(0, 0, -180);
            }

            
            if (Direction == 3)
            {
                rb.velocity = new Vector2(-Speed, 0);
                                Render.transform.rotation = Quaternion.Euler(0, 0, 90);
            }

            if (Direction == 4)
            {
                rb.velocity = new Vector2(Speed, 0);
                                Render.transform.rotation = Quaternion.Euler(0, 0, -90);
            }

            for  (int i = Cannons.Length - 1; i > -1; i -= 1)
            {
                Instantiate(Bullets[Random.Range(0, Bullets.Length)], Cannons[i].transform.position, Cannons[i].transform.rotation);
                Debug.Log("ss");
            }
        }
    }

     void  SecondStage()
     {
        if (BtwMovement <= 0)
        {
            transform.up = Player.transform.position - transform.position;
            rb.velocity = transform.up * 8;

            for  (int i = Cannons.Length - 1; i > -1; i -= 1)
            {
                Instantiate(Bullets[0], Cannons[i].transform.position, Cannons[i].transform.rotation);
            }

            BtwMovement = .1f;
        }
     }
}
