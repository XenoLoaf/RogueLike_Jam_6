using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MerchantSystem : MonoBehaviour
{
    public string[] QuestTexts;
    public string[] QuestObjectNeeded;
    public int Quest;
    public Text QuestDisplay;
    public GameObject Ps;
    float wait;
    bool waiting;
    int AmountGiven;
    public Upgrade Upgrade;
    public Manager Manager;
    // Start is called before the first frame update
    void Start()
    {
        Quest = Random.Range(0, QuestTexts.Length);
    }

    // Update is called once per frame
    void Update()
    {
        wait -= Time.deltaTime;

        QuestDisplay.text = QuestTexts[Quest];

        if (AmountGiven >= 3)
        {

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
