using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuyItem : MonoBehaviour
{
    [SerializeField] GameObject button;
    [SerializeField] GameObject garbage;
    public static string garbageState = "Garbage";
    int garbageDeleteCost = 50;
    void Start()
    {
        if (PlayerPrefs.GetInt(garbageState) == 1)
        {
            garbage.SetActive(false);
            button.SetActive(false);
        }
    }

    public void DeleteGarbage()
    {
        if (!PlayerPrefs.HasKey(garbageState))
        {
            PlayerPrefs.SetInt(garbageState, 0);
        }
        if (PlayerPrefs.GetInt(AdminMode.infMoneyState) == 1)
        {
            garbage.SetActive(false);
            button.SetActive(false);
            PlayerPrefs.SetInt(garbageState, 1);
        }
        else if (Control.countCoin >= garbageDeleteCost)
        {
            Control.countCoin -= garbageDeleteCost;
            garbage.SetActive(false);
            button.SetActive(false);
            PlayerPrefs.SetInt(garbageState, 1);
        }
    }
}
