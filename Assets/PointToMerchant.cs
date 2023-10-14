using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointToMerchant : MonoBehaviour
{
    public GameObject Player; // Player object
    public GameObject Merchant; // Merchant object
    public float radius = 5.0f; // Radius of the circle
    public float angleOffset = -90.0f; // Default angle offset
    private Vector3 targetPosition;
    private float angle = 0.0f; // Current angle

    void Start()
    {
        radius = 5.0f;
    }

    void Update()
    {
        // Calculate the position of the player
        Vector3 playerPosition = Player.transform.position;

        // Calculate the position of the merchant
        Vector3 merchantPosition = Merchant.transform.position;

        // Calculate the direction from the player to the merchant
        Vector3 direction = merchantPosition - playerPosition;

        // Calculate the angle to rotate the indicator sprite
        angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        // Calculate the position for the indicator
        Vector3 offset = Quaternion.Euler(0, 0, angle + angleOffset) * (Vector3.right * radius);
        Vector3 indicatorPosition = playerPosition + offset;

        // Calculate the target position within the radius
        targetPosition = playerPosition + direction.normalized * radius;

        // Snap the indicator sprite to the target position
        transform.position = targetPosition;

        // Apply the rotation to the indicator sprite to point at the merchant
        transform.rotation = Quaternion.Euler(0, 0, angle + angleOffset);
    }
}
