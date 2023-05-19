using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerDeath : MonoBehaviour
{
    [SerializeField] GameObject restartPaneL;
    [SerializeField] Text restartPanelHighScoreText;
    public static bool isDead;
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Obstacle"))
        {
            restartPanelHighScoreText.text = "High Score: " + PlayerPrefs.GetInt("HighScore");
            restartPaneL.SetActive(true);
            Time.timeScale = 0;
            PlayerMover.gameStarted = false;
            PlayerCollector.score = 0;
        }
    }
}
