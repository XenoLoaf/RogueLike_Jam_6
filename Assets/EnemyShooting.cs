using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooting : MonoBehaviour
{
    public float BtwShoot;
    public float BtwShooting;
    public GameObject Bullet;
    public GameObject ShootingPs;
    EnemyState EnemyState;
    public GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        EnemyState = GetComponent<EnemyState>();
                Player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (EnemyState.PlayerInRange && EnemyState.Manager.WantedLevel == 2  && Player.layer != 3 || EnemyState.PlayerInRange && EnemyState.Manager.WantedLevel >= 2  && Player.layer != 3)
        {
        BtwShooting -= Time.deltaTime;
        
        if (BtwShooting <= 0)
        {
            Instantiate(Bullet, transform.position, transform.rotation);
            BtwShooting = BtwShoot;
            Instantiate(ShootingPs, transform.position, transform.rotation, transform);
        }
        }
    }
}
