using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;

    public int score = 0;

    // Declare an event
    public delegate void OnScoreChanged(int newScore);
    public static event OnScoreChanged onScoreChanged;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void AddScore(int amount)
    {
        score += amount;
        Debug.Log("Score: " + score);

        // Trigger the event
        if (onScoreChanged != null)
        {
            onScoreChanged(score);
        }
    }
}
