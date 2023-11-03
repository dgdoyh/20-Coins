using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI coinText;

    public void ModifyCoinUI(int currCoins)
    {
        coinText.text = "Coins: " + currCoins;
    }
}
