using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public Transform leftBoundary;
    public Transform rightBoundary;
    public float moveSpeed = 2f;

    private bool movingRight = true;

    void Update()
    {
        if (movingRight)
        {
            transform.Translate(Vector2.right * moveSpeed * Time.deltaTime);
            if (transform.position.x >= rightBoundary.position.x)
            {
                movingRight = false;
            }
        }
        else
        {
            transform.Translate(Vector2.left * moveSpeed * Time.deltaTime);
            if (transform.position.x <= leftBoundary.position.x)
            {
                movingRight = true;
            }
        }
    }
}
