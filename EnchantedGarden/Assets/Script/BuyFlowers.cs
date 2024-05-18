using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuyFlowers : MonoBehaviour
{
    [SerializeField] GameObject[] buttons;
    [SerializeField] GameObject[] gameObjects;
    [SerializeField] Text[] textCost;
    public static string[] stateNames = { "Flower1_2", "Flower3_4_5", "Flower6_7", "Flower8_10" };
    [SerializeField] int cost = 20;
    void Start()
    {
        foreach (Text t in textCost)
        {
            t.text = cost.ToString();
        }

        if (PlayerPrefs.GetInt(stateNames[0]) == 1)
        {
            buttons[0].GetComponent<Image>().color = Color.green;
            for (int i = 0; i < 2; i++)
            {
                gameObjects[i].SetActive(true);
            }
        }
        if (PlayerPrefs.GetInt(stateNames[1]) == 1)
        {
            buttons[1].GetComponent<Image>().color = Color.green;
            for (int i = 2; i < 5; i++)
            {
                gameObjects[i].SetActive(true);
            }
        }
        if (PlayerPrefs.GetInt(stateNames[2]) == 1)
        {
            buttons[2].GetComponent<Image>().color = Color.green;
            for (int i = 5; i < 7; i++)
            {
                gameObjects[i].SetActive(true);
            }
        }
        if (PlayerPrefs.GetInt(stateNames[3]) == 1)
        {
            buttons[3].GetComponent<Image>().color = Color.green;
            for (int i = 7; i < gameObjects.Length; i++)
            {
                gameObjects[i].SetActive(true);
            }
        }
    }

    public void buyFlowers1_2()
    {
        if (!PlayerPrefs.HasKey(stateNames[0]))
        {
            PlayerPrefs.SetInt(stateNames[0], 0);
        }
        if (PlayerPrefs.GetInt(stateNames[0]) == 1)
        {
            return;
        }

        for (int i = 0; i < 2; i++)
        {
            if (PlayerPrefs.GetInt(BuyItem.garbageState) == 1)
            {
                if (PlayerPrefs.GetInt(AdminMode.infMoneyState) == 1)
                {
                    gameObjects[i].SetActive(true);
                    buttons[0].GetComponent<Image>().color = Color.green;
                    PlayerPrefs.SetInt(stateNames[0], 1);
                }
                else if (Control.countCoin >= cost)
                {
                    Control.countCoin -= cost;
                    gameObjects[i].SetActive(true);
                    buttons[0].GetComponent<Image>().color = Color.green;
                    PlayerPrefs.SetInt(stateNames[0], 1);
                }
            }
        }
    }
    public void buyFlowers3_4_5()
    {
        if (!PlayerPrefs.HasKey(stateNames[1]))
        {
            PlayerPrefs.SetInt(stateNames[1], 0);
        }
        if (PlayerPrefs.GetInt(stateNames[1]) == 1)
        {
            return;
        }

        for (int i = 2; i < 5; i++)
        {
            if (PlayerPrefs.GetInt(BuyItem.garbageState) == 1)
            {
                if (PlayerPrefs.GetInt(AdminMode.infMoneyState) == 1)
                {
                    gameObjects[i].SetActive(true);
                    buttons[1].GetComponent<Image>().color = Color.green;
                    PlayerPrefs.SetInt(stateNames[1], 1);
                }
                else if (Control.countCoin >= cost)
                {
                    Control.countCoin -= cost;
                    gameObjects[i].SetActive(true);
                    buttons[1].GetComponent<Image>().color = Color.green;
                    PlayerPrefs.SetInt(stateNames[1], 1);
                }
            }
        }
    }
    public void buyFlowers6_7()
    {
        if (!PlayerPrefs.HasKey(stateNames[2]))
        {
            PlayerPrefs.SetInt(stateNames[2], 0);
        }
        if (PlayerPrefs.GetInt(stateNames[2]) == 1)
        {
            return;
        }

        for (int i = 5; i < 7; i++)
        {
            if (PlayerPrefs.GetInt(BuyItem.garbageState) == 1)
            {
                if (PlayerPrefs.GetInt(AdminMode.infMoneyState) == 1)
                {
                    gameObjects[i].SetActive(true);
                    buttons[2].GetComponent<Image>().color = Color.green;
                    PlayerPrefs.SetInt(stateNames[2], 1);
                }
                else if (Control.countCoin >= cost)
                {
                    Control.countCoin -= cost;
                    gameObjects[i].SetActive(true);
                    buttons[2].GetComponent<Image>().color = Color.green;
                    PlayerPrefs.SetInt(stateNames[2], 1);
                }
            }
        }
    }
    public void buyFlowers8_10()
    {
        if (!PlayerPrefs.HasKey(stateNames[3]))
        {
            PlayerPrefs.SetInt(stateNames[3], 0);
        }
        if (PlayerPrefs.GetInt(stateNames[3]) == 1)
        {
            return;
        }
        for (int i = 7; i < gameObjects.Length; i++)
        {
            if (PlayerPrefs.GetInt(BuyItem.garbageState) == 1)
            {
                if (PlayerPrefs.GetInt(AdminMode.infMoneyState) == 1)
                {
                    gameObjects[i].SetActive(true);
                    buttons[3].GetComponent<Image>().color = Color.green;
                    PlayerPrefs.SetInt(stateNames[3], 1);
                }
                else if (Control.countCoin >= cost)
                {
                    Control.countCoin -= cost;
                    gameObjects[i].SetActive(true);
                    buttons[3].GetComponent<Image>().color = Color.green;
                    PlayerPrefs.SetInt(stateNames[3], 1);
                }
            }
        }
    }
}
