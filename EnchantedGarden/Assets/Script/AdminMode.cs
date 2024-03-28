using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class AdminMode : MonoBehaviour
{
    public static string adminState = "Admin";
    public static string infMoneyState = "InfMoney";

    [SerializeField] Button thisButton;
    [SerializeField] Button resetStateButton;
    [SerializeField] Button addMoneyButton;

    public void Start()
    {
        PlayerPrefs.SetInt(adminState, 0);
        PlayerPrefs.SetInt(infMoneyState, 0);
        resetStateButton.interactable = false;
        addMoneyButton.interactable = false;
    }
    public void SetAdminState()
    {
        if (PlayerPrefs.GetInt(adminState) == 0)
        {
            PlayerPrefs.SetInt (adminState, 1);
            resetStateButton.interactable = true;
            addMoneyButton.interactable = true;
            thisButton.image.color = Color.green;
        }
        else
        {
            PlayerPrefs.SetInt(adminState, 0);
            PlayerPrefs.SetInt(infMoneyState, 0);
            resetStateButton.interactable = false;
            addMoneyButton.interactable = false;
            addMoneyButton.image.color = Color.white;
            thisButton.image.color = Color.white;
        }
    }

    public void ResetState()
    {
        PlayerPrefs.DeleteAll();
        PlayerPrefs.SetInt("Coins", 0);
        addMoneyButton.image.color = Color.white;
        PlayerPrefs.SetInt(infMoneyState, 0);
        PlayerPrefs.SetInt(adminState, 1);
    }

    public void infinityMoney()
    {
        if (PlayerPrefs.GetInt(adminState) == 1 && PlayerPrefs.GetInt(infMoneyState) == 0)
        {
            PlayerPrefs.SetInt(infMoneyState, 1);
            addMoneyButton.image.color = Color.green;
        }
        else
        {
            PlayerPrefs.SetInt(infMoneyState, 0);
            addMoneyButton.image.color = Color.white;
        }
    }

}
