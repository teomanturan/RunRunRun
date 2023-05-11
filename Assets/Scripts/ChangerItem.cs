using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangerItem : MonoBehaviour
{
    [SerializeField] GameObject player;
    List<GameObject> vehicleType = new List<GameObject>();

    private void Awake()
    {
        for (int i = 0; i < 3; i++)
        {
            vehicleType.Add(player.transform.GetChild(i).gameObject);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("ETKİLEŞ");
            ChangerItemCollected();
        }
    }

        #region Arac degistirme mekanigi
        public void ChangerItemCollected()
    {
        if (vehicleType[0].activeSelf)
        {
            Debug.Log("1");
            vehicleType[1].SetActive(true);
            vehicleType[0].SetActive(false);
        }
        else if (vehicleType[1].activeSelf)
        {
            Debug.Log("2");
            vehicleType[2].SetActive(true);
            vehicleType[1].SetActive(false);
        }
        else if (vehicleType[2].activeSelf)
        {
            Debug.Log("3");
            vehicleType[0].SetActive(true);
            vehicleType[2].SetActive(false);
        }
        Destroy(gameObject);
    }
    #endregion
}
