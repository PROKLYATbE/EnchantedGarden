using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GardenControl : MonoBehaviour
{
    [SerializeField] Text[] coins;
    [SerializeField] string lvlName;

    public static int countCoin = 0;
    public static int bonusCoin = 10;

    void Start()
    {
        if (PlayerPrefs.GetInt(lvlName) == 1)
        {
            bonusCoin = 1;
        }

        if (PlayerPrefs.HasKey("Coins"))
        {
            countCoin = PlayerPrefs.GetInt("Coins");
        }
        else
        {
            countCoin = 0;
        }
        UpdateText();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            SaveBank();
            UpdateText();
        }

    }

    public void UpdateText()
    {
        foreach (var coin in coins)
        {
            coin.text = countCoin.ToString();
        }
    }

    public void SaveBank()
    {
        PlayerPrefs.SetInt("Coins", countCoin);
    }

}
