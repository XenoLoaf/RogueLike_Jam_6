using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundedEnemyAi : MonoBehaviour
{
    public Rigidbody2D rb;
    public float Speed;
    public GameObject[] Attacks;
    public float[] AttackTimers;
    public int[] MovementKind;
    public float ActualBtwAttacks;
    public GameObject Planet;
    int Rando;
    bool CanMove;
    GameObject Player;
    float PlayerDistance;
    public bool FirstDash = true;

    void Start()
    {
        Rando = Random.Range(0, Attacks.Length);
        Player = GameObject.FindWithTag("Player");
    }

    void Update()
    {
        ActualBtwAttacks -= Time.deltaTime;
        Vector2 PlanetVector = Planet.transform.position;
        Vector2 Vector = transform.position;
        Vector2 PlayerVector = Player.transform.position;

        PlayerDistance = Vector2.Distance(PlayerVector, Vector);
        if (ActualBtwAttacks <= 0 && Player.layer == 3 && PlayerDistance <= 20)
        {
            transform.up = Player.transform.position - transform.position;
            Instantiate(Attacks[Rando], transform.position, transform.rotation);
            Debug.Log("Why are you repeting");
            Rando = Random.Range(0, Attacks.Length);
            ActualBtwAttacks = AttackTimers[Rando];
            FirstDash = true;
        }
        if (Player.layer == 3 && PlayerDistance <= 20)
        {
        if (MovementKind[Rando] == 1)
        {
            transform.position = Vector2.MoveTowards(Vector, PlanetVector, Speed * Time.deltaTime);
            transform.up = Player.transform.position - transform.position;
            Debug.Log("Show");
        }
        if (MovementKind[Rando] == 2)
        {
            transform.position = Vector2.MoveTowards(Vector, PlayerVector, Speed * Time.deltaTime);
            transform.up = Player.transform.position - transform.position;
        }
        if (MovementKind[Rando] == 3 && FirstDash)
        {
            transform.up = Player.transform.position - transform.position;
            rb.velocity = transform.up * Time.deltaTime * 600;
            FirstDash = false;
        }
        else if (FirstDash == true)
        {
            rb.velocity = Vector2.zero;
        }
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.transform.tag == "LandAblePlanet")
        {
            Planet = other.gameObject;
        }
    }

}
