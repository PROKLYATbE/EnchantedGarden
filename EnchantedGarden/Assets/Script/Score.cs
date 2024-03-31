using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    [SerializeField] Sprite star;
    [SerializeField] GameObject star1;
    [SerializeField] GameObject star2;
    [SerializeField] GameObject star3;
    [SerializeField] string lvlName;
    [SerializeField] float scoreToStar2 = 0.5f;
    [SerializeField] float scoreToStar3 = 0.8f;
    void Start()
    {
        float f1 = PlayerPrefs.GetFloat("TimeRemaining" + lvlName);
        float f2 = PlayerPrefs.GetFloat("TimeTo" + lvlName);
        if (PlayerPrefs.GetInt(lvlName) == 1)
        {
            star1.GetComponent<SpriteRenderer>().sprite = star;
        }
        if (PlayerPrefs.GetFloat("TimeRemaining" + lvlName) > scoreToStar2 * PlayerPrefs.GetFloat("TimeTo" + lvlName))
        {
            star2.GetComponent<SpriteRenderer>().sprite = star;
        }
        if (PlayerPrefs.GetFloat("TimeRemaining" + lvlName) > scoreToStar3 * PlayerPrefs.GetFloat("TimeTo" + lvlName))
        {
            star3.GetComponent<SpriteRenderer>().sprite = star;
        }
    }
}
