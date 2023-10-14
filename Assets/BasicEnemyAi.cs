using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicEnemyAi : MonoBehaviour
{
    public Rigidbody2D rb;
    public GameObject Player;
    EnemyState EnemyState;
    public SoundLibrary soundLibrary;

    void Start()
    {
        EnemyState = GetComponent<EnemyState>();
        Player = GameObject.Find("Player");
        soundLibrary = GameObject.Find("SoundLibrary").GetComponent<SoundLibrary>();
    }

    void Update()
    {
        if (EnemyState.PlayerInRange && EnemyState.Manager.WantedLevel == 2 && Player.layer != 3 || EnemyState.PlayerInRange && EnemyState.Manager.WantedLevel >= 2 && Player.layer != 3)
        {
        transform.up = Player.transform.position - transform.position;
        rb.AddForce(transform.up * 20);
        }
        else
        {
            transform.Rotate(0, 0, -1, Space.Self);
        }
    }
    
    void OnDestroy()
    {
        soundLibrary.Explosion();
    }
}
