using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class CountItemDisplay : MonoBehaviour
{
    [SerializeField] Text countFoundItem;

    void Update()
    {
        countFoundItem.text = "Предметы: " + PlayerPrefs.GetInt(EndGame.cntFoundItemsStateName)+ " / " + PlayerPrefs.GetInt(EndGame.cntFoundItemsToWinStateName);
    }
}
