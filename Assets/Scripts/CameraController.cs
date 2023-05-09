using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] GameObject target;
    Vector3 distance;

    private void Start()
    {
        distance = transform.position - target.transform.position;
    }

    private void LateUpdate()
    {
        Vector3 newPosition = new Vector3(transform.position.x, transform.position.y, distance.z + target.transform.position.z);
        transform.position = newPosition;
    }
}//Class
