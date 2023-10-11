using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHpSystem : MonoBehaviour
{
    public float Hp;
    public GameObject ps;
    public GameObject DeathPs;
    public GameObject Drop;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Hp <= 0)
        {
            Destroy(this.gameObject);
            Instantiate(DeathPs, transform.position, ps.transform.rotation);
            Instantiate(Drop, transform.position, ps.transform.rotation);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.transform.tag == "Bullet")
        {
            Hp -= other.gameObject.GetComponent<ShootDamage>().Damage;
            Instantiate(ps, transform.position, ps.transform.rotation);
        }
    }
}
