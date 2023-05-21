using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerCollector : MonoBehaviour
{
    public static int score;
    [SerializeField] Text currentScoreText, highScoreText, startPanelHighScoreText;
    private int multiplier = 1;
    // Start is called before the first frame update
    void Start()
    {
        highScoreText.text = "High Score: " + PlayerPrefs.GetInt("HighScore");
        startPanelHighScoreText.text = "High Score: " + PlayerPrefs.GetInt("HighScore");

    }

    private void FixedUpdate()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Coin"))
        {
            score += 5 * multiplier;
            if (score > PlayerPrefs.GetInt("HighScore"))
                PlayerPrefs.SetInt("HighScore", score);
            currentScoreText.text = "Score: " + score.ToString();
            highScoreText.text = "High Score: " + PlayerPrefs.GetInt("HighScore");
            startPanelHighScoreText.text = "High Score: " + PlayerPrefs.GetInt("HighScore");
            Destroy(other.gameObject);
        }
        if (other.CompareTag("MultiplierItem"))
        {
            StartCoroutine(ScoreDoubler());
        }
    }

    #region Score Double for 10 Seconds
    IEnumerator ScoreDoubler()
    {
        multiplier = 2;
        yield return new WaitForSeconds(10);
        multiplier = 1;
    }
    #endregion
}
