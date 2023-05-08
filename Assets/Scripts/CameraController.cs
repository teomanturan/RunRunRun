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
        transform.position = target.transform.position + distance;
    }

}//Class
