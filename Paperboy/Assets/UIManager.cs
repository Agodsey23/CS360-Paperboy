using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public PlayerController player;
    public TextMeshProUGUI healthText;
    public TextMeshProUGUI ammoText;
    public TextMeshProUGUI scoreText;

    private void OnEnable()
    {
        ScoreManager.onScoreChanged += UpdateScoreUI;
    }

    private void OnDisable()
    {
        ScoreManager.onScoreChanged -= UpdateScoreUI;
    }

    void Update()
    {
        healthText.text = "Health: " + player.health;
        ammoText.text = "Ammo: " + player.ammo;
    }

    void UpdateScoreUI(int newScore)
    {
        scoreText.text = "Score: " + newScore;
    }
}
