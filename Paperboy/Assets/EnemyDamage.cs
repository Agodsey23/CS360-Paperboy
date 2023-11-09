using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    public int damageAmount = 1;
    public float damageCooldown = 2f;

    private float lastDamageTime;

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && Time.time >= lastDamageTime + damageCooldown)
        {
            PlayerController player = collision.GetComponent<PlayerController>();
            if (player != null)
            {
                player.TakeDamage(damageAmount);
                lastDamageTime = Time.time;
            }
        }
    }
}
