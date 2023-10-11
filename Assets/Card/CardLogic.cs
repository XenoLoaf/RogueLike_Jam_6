using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardLogic : MonoBehaviour
{
    public int CardType;
    public GameObject[] CardTypeShow;
    public Manager Manager;
    public Upgrade Upgrade;
    // Start is called before the first frame update
    void Start()
    {
        Manager = GameObject.Find("Manager").GetComponent<Manager>();
        Upgrade = GameObject.Find("Manager").GetComponent<Upgrade>();
        CardType = Random.Range(1, 4);
    }

    // Update is called once per frame
    void Update()
    {
        if (CardType == 1)
        {
            CardTypeShow[0].SetActive(true);
        }
        if (CardType == 2)
        {
            CardTypeShow[1].SetActive(true);
        }
        if (CardType == 3)
        {
            CardTypeShow[2].SetActive(true);
        }
        if (CardType == 4)
        {
            CardTypeShow[3].SetActive(true);
        }
    }

    void OnMouseDown()
    {
        if (CardType == 1)
        {
            Manager.SpeedGrounded *= 1.3f;
        }
        if (CardType == 2)
        {
            Manager.Hp = 3;
        }
        if (CardType == 3)
        {
            Manager.BulletSize += 0.5f;
        }
        if (CardType == 4)
        {
            Manager.BulletSpeed += 3;
        }
        Upgrade.UpgradeDelete();
    }
}
