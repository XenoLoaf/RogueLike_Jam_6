using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class MerchantSystem : MonoBehaviour
{
    public string[] QuestTexts;
    public string[] QuestObjectNeeded;
    public int Quest;
    public TextMeshProUGUI CurrentQuestText;
    public GameObject Ps;
    float wait;
    bool waiting;
    int AmountGiven;
    public Upgrade Upgrade;
    public Manager Manager;
    bool Allow = true;
    public GameObject FinalBoss;

    void Start()
    {
        Quest = Random.Range(0, QuestTexts.Length);
        Manager = GameObject.Find("Manager").GetComponent<Manager>();
        Upgrade = GameObject.Find("Manager").GetComponent<Upgrade>();
    }

    void Update()
    {
        wait -= Time.deltaTime;

        CurrentQuestText.text = QuestTexts[Quest];

        if (AmountGiven >= 3 && Allow)
        {
            Instantiate(FinalBoss, transform.position, transform.rotation);
            Allow = false;
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.transform.tag == "CarryAble")
        {
            PickUpAbleObject PickUpAbleObject = other.gameObject.GetComponent<PickUpAbleObject>();
            if (PickUpAbleObject.ItemName == QuestObjectNeeded[Quest])
            {
                ReroleQuest();
                Destroy(other.gameObject);
                Instantiate(Ps, transform.position, Ps.transform.rotation);
                waiting = true;
                wait = 1f;
                AmountGiven += 1;
                Upgrade.UpgradeSpawn();
                Manager.WantedLevel += 1;
            }
        }
    }

    void ReroleQuest()
    {
        Quest = Random.Range(0, QuestTexts.Length);
        Debug.Log("QuestRelloaded");
    }
}
