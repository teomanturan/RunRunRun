using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeath : MonoBehaviour
{
    [SerializeField] GameObject restartPaneL;
    public static bool isDead;
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Obstacle"))
        {
            restartPaneL.SetActive(true);
            Time.timeScale = 0;
            PlayerMover.gameStarted = false;
        }
    }
}
