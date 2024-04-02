using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public
class AdminMode : MonoBehaviour
{
    public
        static string adminState = "Admin";
    public
        static string infMoneyState = "InfMoney";
    public
        static string infTimeState = "InfTime";


    [SerializeField] Button thisButton;
    [SerializeField] Button resetStateButton;
    [SerializeField] Button addMoneyButton;
    [SerializeField] Button infTimeButton;

    public
        void Start()
    {
        if (!PlayerPrefs.HasKey(adminState) ||
            PlayerPrefs.GetInt(adminState) == 0)
        {
            resetStateButton.interactable = false;
            addMoneyButton.interactable = false;
            infTimeButton.interactable = false;
        }
        if (PlayerPrefs.GetInt(adminState) == 1) 
        {
            thisButton.image.color = Color.green;
        }
        if (PlayerPrefs.GetInt(infMoneyState) == 1)
        {
            addMoneyButton.image.color = Color.green;
        }
        if (PlayerPrefs.GetInt(infTimeState) == 1)
        {
            infTimeButton.image.color = Color.green;
        }
    }
    public
        void SetAdminState()
    {
        if (!PlayerPrefs.HasKey(adminState))
        {
            PlayerPrefs.SetInt(adminState, 0);
            PlayerPrefs.SetInt(infMoneyState, 0);
            PlayerPrefs.SetInt(infTimeState, 0);
        }
        if (PlayerPrefs.GetInt(adminState) == 0)
        {
            infTimeButton.interactable = true;
            PlayerPrefs.SetInt(adminState, 1);
            resetStateButton.interactable = true;
            addMoneyButton.interactable = true;
            thisButton.image.color = Color.green;
        }
        else
        {
            PlayerPrefs.SetInt(adminState, 0);
            PlayerPrefs.SetInt(infMoneyState, 0);
            PlayerPrefs.SetInt(infTimeState, 0);
            resetStateButton.interactable = false;
            addMoneyButton.interactable = false;
            infTimeButton.interactable = false;
            addMoneyButton.image.color = Color.white;
            thisButton.image.color = Color.white;
            infTimeButton.image.color = Color.white;
        }
    }

    public
        void ResetState()
    {
        PlayerPrefs.DeleteAll();
        Control.countCoin = 0;
        PlayerPrefs.SetInt("Coins", 0);
        addMoneyButton.image.color = Color.white;
        infTimeButton.image.color = Color.white;
        PlayerPrefs.SetInt(infMoneyState, 0);
        PlayerPrefs.SetInt(adminState, 1);
        PlayerPrefs.SetInt(infTimeState, 0);
    }

    public
        void infinityMoney()
    {
        if (PlayerPrefs.GetInt(adminState) == 1 &&
            PlayerPrefs.GetInt(infMoneyState) == 0)
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

    public
        void InfiniteTime()
    {
        if (PlayerPrefs.GetInt(adminState) == 1 &&
            PlayerPrefs.GetInt(infTimeState) == 0)
        {
            PlayerPrefs.SetInt(infTimeState, 1);
            infTimeButton.image.color = Color.green;
        }
        else
        {
            PlayerPrefs.SetInt(infTimeState, 0);
            infTimeButton.image.color = Color.white;
        }
    }
}