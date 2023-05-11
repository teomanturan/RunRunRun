using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerCollector : MonoBehaviour
{
    public static int score;
    [SerializeField] Text currentScoreText,highScoreText,startPanelHighScoreText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void FixedUpdate()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Coin"))
        {
            score += 5;
            if (score > PlayerPrefs.GetInt("HighScore"))
            PlayerPrefs.SetInt("HighScore", score);
            currentScoreText.text = "Score: " + score.ToString();
            highScoreText.text = "High Score: " + PlayerPrefs.GetInt("HighScore");
            startPanelHighScoreText.text = "High Score: " + PlayerPrefs.GetInt("HighScore");
            Destroy(other.gameObject);
        }
    }
}
