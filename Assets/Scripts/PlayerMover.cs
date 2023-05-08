using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMover : MonoBehaviour
{
    float speed = 10;
    private void FixedUpdate()
    {
        Mover();
    }

    #region
    void Mover()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
    #endregion
}//Class
