using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMover : MonoBehaviour
{
    public float speed = 10;
    float horizontalInput;

    private void FixedUpdate()
    {
        Mover();
    }

    private void Update()
    {
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
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * speed * Time.deltaTime);
    }

    #endregion
}//Class
