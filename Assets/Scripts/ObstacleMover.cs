using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMover : MonoBehaviour
{
    private void FixedUpdate()
    {
        if(!PlayerMover.gameStarted)
        transform.Translate(Vector3.right * 3 * Time.deltaTime);
    }
}
