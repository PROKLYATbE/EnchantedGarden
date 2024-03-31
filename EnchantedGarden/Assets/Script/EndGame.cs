using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour
{
    public string lvlName;
    public static string cntFoundItemsStateName;
    public static string cntFoundItemsToWinStateName;
    public int foundItem;

    void Start()
    {
        cntFoundItemsStateName = "FoundItems" + lvlName;
        cntFoundItemsToWinStateName = "ItemsToWin" + lvlName;
        PlayerPrefs.SetInt(cntFoundItemsToWinStateName, foundItem);
        PlayerPrefs.SetInt(lvlName, 0);
        PlayerPrefs.SetInt(cntFoundItemsStateName, 0);
    }

    void Update()
    {
        if (PlayerPrefs.GetInt(cntFoundItemsStateName) == foundItem)
        {
            PlayerPrefs.SetInt(lvlName, 1);
            SceneManager.LoadScene("WinScene");
        }
    }
}
