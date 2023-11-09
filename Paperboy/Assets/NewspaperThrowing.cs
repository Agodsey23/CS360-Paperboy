using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Newspaper : MonoBehaviour
{
    public float throwSpeed = 10f;
    private Rigidbody2D rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        // Throw the newspaper to the left
        rb.velocity = new Vector2(-throwSpeed, 0);
    }

    // If you want to add interactions when the newspaper hits something, 
    // you can use the OnCollisionEnter2D or OnTriggerEnter2D methods.
    // For example:
    /*
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("House"))
        {
            // Logic for when the newspaper hits a house
        }
    }
    */
}
