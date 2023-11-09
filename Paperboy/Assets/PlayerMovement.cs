using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public Transform leftBoundary;  // Drag your LeftBoundary GameObject here in the inspector
    public Transform rightBoundary; // Drag your RightBoundary GameObject here in the inspector

    private float halfPlayerWidth;
    private float halfPlayerHeight;

    private void Start()
    {
        // Assuming the player sprite's pivot is in the center
        halfPlayerWidth = GetComponent<SpriteRenderer>().bounds.extents.x;
        halfPlayerHeight = GetComponent<SpriteRenderer>().bounds.extents.y;
    }

    void Update()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");
        
        transform.Translate(new Vector3(moveX, moveY, 0) * moveSpeed * Time.deltaTime);

        // Use the x positions of the boundary GameObjects as your left and right boundaries
        float leftBound = leftBoundary.position.x + halfPlayerWidth;
        float rightBound = rightBoundary.position.x - halfPlayerWidth;
        float topBoundary = Camera.main.ViewportToWorldPoint(new Vector3(0, 0.95f, 0)).y - halfPlayerHeight;
        float bottomBoundary = Camera.main.ViewportToWorldPoint(new Vector3(0, 0.05f, 0)).y + halfPlayerHeight;

        Vector3 playerWorldPosition = transform.position;
        playerWorldPosition.x = Mathf.Clamp(playerWorldPosition.x, leftBound, rightBound);
        playerWorldPosition.y = Mathf.Clamp(playerWorldPosition.y, bottomBoundary, topBoundary);
        transform.position = playerWorldPosition;
    }
}
