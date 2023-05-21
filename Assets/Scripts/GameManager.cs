using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject restartPanel,resetPanel;
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
        PlayerMover.gameStarted = true;
        Time.timeScale = 1;
    }
    public void OpenResetPanel()
    {
        resetPanel.SetActive(true);
    }

    public void ResetPanelNo()
    {
        resetPanel.SetActive(false);
    }

    public void ResetPanelYes()
    {
        PlayerPrefs.SetInt("HighScore", 0);
    }
}
