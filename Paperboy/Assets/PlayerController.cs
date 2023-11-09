using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f;
    public GameObject newspaperPrefab; 
    public Transform throwPoint; 
    public float throwSpeed = 10f;

    public int health = 3; // Player's health
    public int ammo = 10;    // Number of newspapers
    public int score = 0;    // Player's score

    private void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector2 movement = new Vector2(horizontal, vertical);
        transform.Translate(movement * speed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Space) && ammo > 0) // Check if there are newspapers left
        {
            ThrowNewspaper();
            ammo--; // Decrease the number of newspapers
        }
    }

    void ThrowNewspaper()
    {
        GameObject newspaper = Instantiate(newspaperPrefab, throwPoint.position, Quaternion.identity);
        Rigidbody2D rb = newspaper.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(-throwSpeed, 0); 
    }

     public void ReplenishAmmo(int amount)
    {
        ammo += amount;
        ammo = Mathf.Clamp(ammo, 0, 10); // Ensure ammo doesn't exceed 10
    }

    public void TakeDamage(int damage)
{
    // Subtract damage from player's health
    health -= damage;

    // Check if health is 0 or less, then handle player death (if needed)
    if (health <= 0)
    {
        // Handle player death, e.g., restart the level or show game over screen
    }
}

}
