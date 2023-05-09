using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundSpawner : MonoBehaviour
{
    [SerializeField] GameObject ground;
    [SerializeField] Transform grounds;
    Vector3 nextSpawnPoint;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 15; i++)
        {
            SpawnGround();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnGround()
    {
        GameObject newGround = Instantiate(ground, nextSpawnPoint, Quaternion.identity,grounds);
        nextSpawnPoint = newGround.transform.GetChild(1).transform.position;
    }
}
