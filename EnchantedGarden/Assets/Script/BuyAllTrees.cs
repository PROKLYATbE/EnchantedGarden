using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuyAllTrees : MonoBehaviour
{
    [SerializeField] GameObject[] buttons;
    [SerializeField] GameObject[] gameObjects;
    [SerializeField] Text[] textCost;
    public static string[] stateNames = { "Tree", 
                                         "Tree2",
                                         "Tree3" };
    [SerializeField] int cost = 100;
    void Start()
    {
        foreach (Text t in textCost)
        {
            t.text = cost.ToString();
        }
        for (int i = 0; i < gameObjects.Length; i++)
        {
            if (PlayerPrefs.GetInt(stateNames[i]) == 1)
            {
                gameObjects[i].SetActive(true);
                buttons[i].GetComponent<Image>().color = Color.green;
            }
        }
    }

    public void buyTree(int i)
    {
        if (!PlayerPrefs.HasKey(stateNames[i]))
        {
            PlayerPrefs.SetInt(stateNames[i], 0);
        }
        if (PlayerPrefs.GetInt(stateNames[i]) == 1)
        {
            return;
        }
        if (PlayerPrefs.GetInt(BuyItem.garbageState) == 1)
        {
            if (PlayerPrefs.GetInt(AdminMode.infMoneyState) == 1)
            {
                gameObjects[i].SetActive(true);
                buttons[i].GetComponent<Image>().color = Color.green;
                PlayerPrefs.SetInt(stateNames[i], 1);
            }
            else if (Control.countCoin >= cost)
            {
                Control.countCoin -= cost;
                gameObjects[i].SetActive(true);
                buttons[i].GetComponent<Image>().color = Color.green;
                PlayerPrefs.SetInt(stateNames[i], 1);
            }
        }
    }
}
