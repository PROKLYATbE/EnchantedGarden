using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuyFence : MonoBehaviour
{
    [SerializeField] GameObject button;
    [SerializeField] GameObject[] gameObjects;
    public static string stateName = "Fence";
    [SerializeField] int cost = 20;
    void Start()
    {
        if (PlayerPrefs.GetInt(stateName) == 1)
        {
            foreach (var gameObject in gameObjects)
            {
                gameObject.SetActive(true);
            }
            button.GetComponent<Image>().color = Color.green;
        }
    }

    public void buyFence()
    {
        if (!PlayerPrefs.HasKey(stateName))
        {
            PlayerPrefs.SetInt(stateName, 0);
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
