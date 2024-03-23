using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour
{
    public string lvlName;
    public static string stateName;
    public int foundItem;

    void Start()
    {
        stateName = "FoundItems" + lvlName;
        PlayerPrefs.SetInt("ItemsToWin" +  lvlName, foundItem);
        PlayerPrefs.SetInt(lvlName, 0);
        PlayerPrefs.SetInt(stateName, 0);
    }

    void FixedUpdate()
    {
        if (PlayerPrefs.GetInt(stateName) == foundItem)
        {
            PlayerPrefs.SetInt(lvlName, 1);
            SceneManager.LoadScene("WinScene");
        }
    }
}
