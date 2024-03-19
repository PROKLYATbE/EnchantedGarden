using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Control : MonoBehaviour
{
    [SerializeField] GameObject[] iteractiveObjs;


    [SerializeField] Text coins;
    public static int countCoin = 0;
    public static int bonusCoin = 10;

    void Start()
    {
        if (PlayerPrefs.HasKey("Coins"))
        {
            countCoin = PlayerPrefs.GetInt("Coins");
        }
        else
        {
            countCoin = 0;
        }
        coins.text = "Coins: " + countCoin.ToString();
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
        coins.text = "Coins: " + countCoin.ToString();
    }

    public void SaveBank()
    {
        PlayerPrefs.SetInt("Coins", countCoin);
    }
}
