using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coins : MonoBehaviour
{
    [SerializeField] private int currCoins = 0;
    private int maxCoins = 100;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Coin"))
        {
            if (currCoins < maxCoins)
            {
                currCoins += 1;
                Destroy(other.gameObject);
            }
        }
    }
}
