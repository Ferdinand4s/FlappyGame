using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    private int bestScore;
    private int currentScore;

    [SerializeField]
    public Text bestScoreText;
    [SerializeField]
    public Text currentScoreText;

    private void Awake()
    {
        currentScore = PlayerPrefs.GetInt("currentScore", 0);
        bestScore = PlayerPrefs.GetInt("bestScore", 0);
        
        if (currentScore > bestScore)
        {
            bestScore = currentScore;
            PlayerPrefs.SetInt("bestScore", bestScore);
        }

        currentScoreText.text = "Score: " + currentScore;
        bestScoreText.text = "Best: " + bestScore;
    }

    public void StartGame()
    {
        SceneManager.LoadScene("Assets/Scenes/Game.unity");
    }
}
