using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    [SerializeField] GameObject star1;
    [SerializeField] GameObject star2;
    [SerializeField] GameObject star3;
    [SerializeField] string lvlName;
    void Start()
    {
        float f1 = PlayerPrefs.GetFloat("TimeRemaining" + lvlName);
        float f2 = PlayerPrefs.GetFloat("TimeTo" + lvlName);
        if (PlayerPrefs.GetInt(lvlName) == 1)
        {
            star1.SetActive(true);
        }
        if (PlayerPrefs.GetFloat("TimeRemaining" + lvlName) > 0.5 * PlayerPrefs.GetFloat("TimeTo" + lvlName))
        {
            star2.SetActive(true);
        }
        if (PlayerPrefs.GetFloat("TimeRemaining" + lvlName) > 0.8 * PlayerPrefs.GetFloat("TimeTo" + lvlName))
        {
            star3.SetActive(true);
        }
    }
}
