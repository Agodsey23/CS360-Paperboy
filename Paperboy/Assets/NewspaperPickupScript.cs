using UnityEngine;

public class NewspaperPickupScript : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            PlayerController player = collision.GetComponent<PlayerController>();
            if (player != null)
            {
                player.ReplenishAmmo(10); // Add 10 to the player's ammo
                Destroy(gameObject); // Destroy the pickup
            }
        }
    }
}
