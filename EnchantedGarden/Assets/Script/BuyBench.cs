using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuyBench : MonoBehaviour
{
    [SerializeField] GameObject button;
    [SerializeField] GameObject[] gameObjects;
    [SerializeField] Text[] textCost;
    public static string stateName = "Bench";
    [SerializeField] int cost = 20;
    void Start()
    {
        foreach (Text t in textCost)
        {
            t.text = cost.ToString();
        }

        if (PlayerPrefs.GetInt(stateName) == 1)
        {
            foreach (var gameObject in gameObjects)
            {
                gameObject.SetActive(true);
            }
            button.GetComponent<Image>().color = Color.green;
        }
    }

    public void buyBench()
    {
        if (!PlayerPrefs.HasKey(stateName))
        {
            PlayerPrefs.SetInt(stateName, 0);
        }
        if (PlayerPrefs.GetInt(stateName) == 1)
        {
            return;
        }
        if (PlayerPrefs.GetInt(BuyItem.garbageState) == 1)
        {
            if (PlayerPrefs.GetInt(AdminMode.infMoneyState) == 1)
            {
                foreach (var gameObject in gameObjects)
                {
                    gameObject.SetActive(true);
                }
                button.GetComponent<Image>().color = Color.green;
                PlayerPrefs.SetInt(stateName, 1);
            }
            else if (Control.countCoin >= cost)
            {
                Control.countCoin -= cost;
                foreach (var gameObject in gameObjects)
                {
                    gameObject.SetActive(true);
                }
                button.GetComponent<Image>().color = Color.green;
                PlayerPrefs.SetInt(stateName, 1);
            }
        }
    }
}
