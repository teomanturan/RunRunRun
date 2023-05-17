using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject restartPanel;
    public static bool gameRestarted;
    public void QuitGame()
    {
        Application.Quit();
    }

    public void RestartGame()
    {
        restartPanel.SetActive(false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        gameRestarted = true;
        PlayerDeath.isDead = false;
        PlayerMover.gameStarted = true;
        Time.timeScale = 1;
    }
}
