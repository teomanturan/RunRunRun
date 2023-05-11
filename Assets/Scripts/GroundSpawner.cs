using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundSpawner : MonoBehaviour
{
    [SerializeField] GameObject[] ground;
    [SerializeField] Transform grounds;
    Vector3 nextSpawnPoint;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 20; i++)
        {
            SpawnGround();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnGround()
    {
        int caseNumber = Random.Range(0, 3);
        switch (caseNumber)
        {
            case 0:
                SpawnCases(caseNumber);
                break;

            case 1:
                SpawnCases(caseNumber);
                break;

            case 2:
                SpawnCases(caseNumber);
                break;
        }
    }
    
    void SpawnCases(int indexNo)
    {
        GameObject newGround = Instantiate(ground[indexNo], nextSpawnPoint, Quaternion.identity, grounds);
        nextSpawnPoint = newGround.transform.GetChild(1).transform.position;
    }
}
