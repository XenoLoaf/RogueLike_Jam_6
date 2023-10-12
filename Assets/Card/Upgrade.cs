using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Upgrade : MonoBehaviour
{
    public GameObject Card;
    public GameObject[] Spawnpoints;
    public GameObject[] CardsSpawned;
    public GameObject VisualCard;

    public void UpgradeSpawn()
    {
        Instantiate(Card, Spawnpoints[0].transform.position, Card.transform.rotation);
        Instantiate(Card, Spawnpoints[1].transform.position, Card.transform.rotation);
        Instantiate(Card, Spawnpoints[2].transform.position, Card.transform.rotation);
        CardsSpawned[0] = GameObject.Find("Card(Clone)");
        CardsSpawned[0].transform.name = "Card";
        CardsSpawned[1] = GameObject.Find("Card(Clone)");
        CardsSpawned[1].transform.name = "Card";
        CardsSpawned[2] = GameObject.Find("Card(Clone)");
        CardsSpawned[2].transform.name = "Card";
    }

    public void UpgradeDelete()
    {
        Instantiate(VisualCard, CardsSpawned[0].transform.position, transform.rotation);
        Instantiate(VisualCard, CardsSpawned[1].transform.position, transform.rotation);
        Instantiate(VisualCard, CardsSpawned[2].transform.position, transform.rotation);
        Destroy(CardsSpawned[0]);
        Destroy(CardsSpawned[1]);
        Destroy(CardsSpawned[2]);
    }
}
