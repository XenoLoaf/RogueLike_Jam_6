using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EnemyHpSystem : MonoBehaviour
{
    public float Hp;
    public Manager Manager;
    public GameObject ps;
    public GameObject DeathPs;
    public GameObject Drop;
    public bool FinalBoss;
    // Start is called before the first frame update
    void Start()
    {
        Manager = GameObject.Find("Manager").GetComponent<Manager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Hp <= 0)
        {
            Destroy(this.gameObject);

            if (FinalBoss)
            {
                SceneManager.LoadScene("SampleScene");
                Manager.Camera = null;
            }

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
