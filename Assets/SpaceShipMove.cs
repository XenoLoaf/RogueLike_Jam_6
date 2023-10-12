using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceShipMove : MonoBehaviour
{
    public Rigidbody2D rb;
    public GameObject EngineFire;
    public GameObject EngineGas;
    public Transform Thruster;
    public Transform MapIndicator;
    public string MovementType = "Rocket";
    public bool CanLand;
    public GameObject ShipPosition;
    public IsObjectFlying IsObjectFlying;
    public SpriteRenderer render;
    public Sprite[] sprites;
    float JustChanged;
    public Manager Manager;
    // Start is called before the first frame update
    void Start()
    {
        Thruster = this.gameObject.transform.GetChild(1); // this.gameObject.transform.GetChild(0);
    }

    // Update is called once per frame
    void Update()
    {
        JustChanged -= Time.deltaTime;

        if (MovementType == "Rocket")
        {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            rb.AddForce(transform.up * Time.deltaTime * 20,ForceMode2D.Impulse);
            Instantiate(EngineFire, Thruster.transform.position, Thruster.transform.rotation);
            Instantiate(EngineGas, Thruster.transform.position, Thruster.transform.rotation);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            rb.AddForce(transform.up * Time.deltaTime * -20,ForceMode2D.Impulse);
            Instantiate(EngineFire, Thruster.transform.position, Thruster.transform.rotation);
            Instantiate(EngineGas, Thruster.transform.position, Thruster.transform.rotation);
        }

        if (Input.GetKeyDown("space"))
        {
            rb.AddForce(transform.up * Time.deltaTime * 200,ForceMode2D.Impulse);
            Instantiate(EngineFire, transform.position, transform.rotation);
        }
       
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(0, 0, -5, Space.Self);
            MapIndicator.transform.rotation = transform.rotation;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(0, 0, 5, Space.Self);
            MapIndicator.transform.rotation = transform.rotation;
        }
        }
        if (MovementType == "Landed")
        {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            rb.velocity = new Vector2(0 , Manager.SpeedGrounded);
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            rb.velocity = new Vector2(0 , - Manager.SpeedGrounded);
            transform.rotation = Quaternion.Euler(0, 0, 180);
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.velocity = new Vector2(- Manager.SpeedGrounded, 0);
            transform.rotation = Quaternion.Euler(0, 0, 90);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.velocity = new Vector2( Manager.SpeedGrounded, 0);
            transform.rotation = Quaternion.Euler(0, 0, -90);
        }
        else
        {
            rb.velocity = Vector2.zero;
        }
        }

        if (CanLand && Input.GetKeyDown("s") && MovementType != "Landed" && JustChanged <= 0)
        {
            MovementType = "Landed";
            transform.localScale = new Vector2(1.5f, 1.5f);
            render.sprite = sprites[1];
            Instantiate(ShipPosition, transform.position, transform.rotation);
            this.gameObject.layer = 3;
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.transform.tag == "LandAblePlanet")
        {
            CanLand = true;
        }
    }       
    
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.transform.tag == "LandAblePlanet")
        {
                CanLand = false;

        }
    }

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.transform.tag == "ShipPosition" && Input.GetKeyDown("s") && MovementType == "Landed")
        {
            MovementType = "Rocket";
            transform.localScale = new Vector2(2f, 2f);
            render.sprite = sprites[0];
            this.gameObject.layer = 6;
            Destroy(other.gameObject);
            JustChanged = 0.5f;
        }
    }
}
