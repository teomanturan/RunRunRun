using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMover : MonoBehaviour
{
    private void FixedUpdate()
    {
        if (!PlayerMover.gameStarted)
            return;
        transform.Translate(Vector3.right * 1.5f * Time.deltaTime);
    }
}
