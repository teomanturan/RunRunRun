using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollector : MonoBehaviour
{
    public static int score;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(score);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Coin"))
        {
            score += 5;
            Destroy(other.gameObject);
        }
    }
}
