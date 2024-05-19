using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GardenControl : MonoBehaviour
{
    [SerializeField] Text[] coins;
    [SerializeField] string lvlName;

    void Start()
    {
        UpdateText();
    }

    private void Update()
    {
        UpdateText();
        SaveBank();
    }

    public void UpdateText()
    {
        foreach (var coin in coins)
        {
            coin.text = Control.countCoin.ToString();
        }
    }

    public void SaveBank()
    {
        PlayerPrefs.SetInt("Coins", Control.countCoin);
    }

}
