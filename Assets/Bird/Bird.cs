using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Bird : MonoBehaviour
{
    [SerializeField]
    public Text currentScoreText;
    private int currentScore = 0;

    private Rigidbody2D rb;

    public float jumpForce = 1.0f;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(new Vector2(0, jumpForce));
        }
    }

    private void OnCollisionEnter2D()
    {
        PlayerPrefs.SetInt("currentScore", currentScore);
        SceneManager.LoadScene("Assets/Scenes/Menu.unity");
    }

    private void OnTriggerEnter2D()
    {
        currentScore++;
        currentScoreText.text = currentScore.ToString();
    }
}
