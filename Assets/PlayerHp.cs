using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHp : MonoBehaviour
{
    public Manager Manager;
    public GameObject HurtPs;
    public GameObject[] Hearths;
    public float DamageInvincabilityBtw;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        DamageInvincabilityBtw -= Time.deltaTime;
        
        if (Manager.Hp <= 0)
        {
            SceneManager.LoadScene("SampleScene");
        }

        if (Manager.Hp == 1)
        {
            Hearths[0].SetActive(true);
        }
        else 
        {
            Hearths[0].SetActive(false);
        }

                if (Manager.Hp == 2)
        {
            Hearths[1].SetActive(true);
        }
        else 
        {
            Hearths[1].SetActive(false);
        }

        if (Manager.Hp == 3)
        {
            Hearths[2].SetActive(true);
        }
        else
        {
            Hearths[2].SetActive(false);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.transform.tag == "BulletEnemy" && DamageInvincabilityBtw <= 0)
        {
            Manager.Hp -= other.gameObject.GetComponent<ShootDamage>().Damage;
            Instantiate(HurtPs, transform.position, HurtPs.transform.rotation);
            DamageInvincabilityBtw = Manager.DamageInvincability;
        }
        if (other.transform.tag == "Enemy" && DamageInvincabilityBtw <= 0)
        {
            Manager.Hp -= 1;
            Instantiate(HurtPs, transform.position, HurtPs.transform.rotation);
            DamageInvincabilityBtw = Manager.DamageInvincability;
        }
    }
}
