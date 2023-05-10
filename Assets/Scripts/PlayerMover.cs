using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMover : MonoBehaviour
{
    [SerializeField] GameObject startPanel;
    public static bool gameStarted;
    public float speed = 10;
    public float horizontalSpeed = 30;
    int lane = 1;
    float laneDistance = 6;


    private void FixedUpdate()
    {
        if (!gameStarted)
        {
            return;
        }
        Mover();

    }

    private void Update()
    {
        if (!gameStarted)
        {
            return;
        }
        HorizontalMover();

    }

    #region Ileriye dogru hareket
    void Mover()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
    #endregion

    #region Yatay Hareket
    void HorizontalMover()
    {
        if(Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.D))
        {
            lane++;
            if(lane == 3)
            {
                lane = 2;
            }
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.A))
        {
            lane--;
            if(lane == -1)
            {
                lane = 0;
            }
        }
        Vector3 targetPosition = transform.position.z * transform.forward + transform.position.y * transform.up;

        if (lane == 0)
        {
            targetPosition += Vector3.left * laneDistance;
        }
        else if (lane == 2)
        {
            targetPosition += Vector3.right * laneDistance;
        }

        transform.position = Vector3.Lerp(transform.position, targetPosition, 3 * Time.fixedDeltaTime);
    }
    #endregion

    #region Oyuna Başlama İşlemi

    public void StartGame()
    {
        startPanel.SetActive(false);
        gameStarted = true;
        
    }

    #endregion
}//Class
