using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewspaperCollision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
{
    if (collision.CompareTag("House"))
    {
        ScoreManager.instance.AddScore(10); // Add 10 points for hitting a house
        Destroy(gameObject); // Destroy the newspaper
    }
    else if (collision.CompareTag("Mailbox"))
    {
        ScoreManager.instance.AddScore(50); // Add 50 points for hitting a mailbox
        Destroy(gameObject); // Destroy the newspaper
    }
}

}
