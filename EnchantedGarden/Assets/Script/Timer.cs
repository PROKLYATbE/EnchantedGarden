using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Timer : MonoBehaviour
{
    public float timeRemaining = 20;
    public bool timerIsRunning = false;
    public Text timeText;
    public Text timeOver;

    public static int totalClick = 0;
    public const int numClicksForPenalty = 5;
    public const int secondsTimePenalty = 5;

    public string lvlName;
    public int loseSceneNumber;

    private void Start()
    {
        PlayerPrefs.SetFloat("TimeRemaining" + lvlName, 0);
        PlayerPrefs.SetFloat("TimeTo" + lvlName, timeRemaining);
        if (PlayerPrefs.HasKey(AdminMode.infTimeState) &&
            PlayerPrefs.GetInt(AdminMode.infTimeState) == 1)
        {
            timeRemaining = 3600;
        }
        timerIsRunning = true;
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
            ++totalClick;

        if (totalClick == numClicksForPenalty)
        {
            timeRemaining -= secondsTimePenalty;
            totalClick = 0;
        }

        if (PlayerPrefs.GetInt(EndGame.cntFoundItemsStateName) == PlayerPrefs.GetInt("ItemsToWin" + lvlName))
        {
            if (PlayerPrefs.GetFloat("TimeRemaining" + lvlName) < timeRemaining)
            {
                PlayerPrefs.SetFloat("TimeRemaining" + lvlName, timeRemaining);
            }
        }

        if (timerIsRunning)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
                DisplayTime(timeRemaining);
            }
            else
            {
                timeRemaining = 0;
                timerIsRunning = false;
                // DisplayTextTimeOver();
            }
        }
        if (timerIsRunning == false /* && Input.GetKeyDown("g") */)
        {
            SceneManager.LoadScene(loseSceneNumber);
            //SceneManager.LoadScene(levelName, LoadSceneMode.Single);
        }
    }
    void DisplayTime(float timeToDisplay)
    {
        timeToDisplay += 1;
        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);
        timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

    void DisplayTextTimeOver()
    {
        timeOver.text = "Your time is over";
    }
    /*
    void OnGUI()
    {
        if (timerIsRunning == false)
            GUI.Box(new Rect(0, 50, 250, 25), "GAME OVER. Press 'g' " +
            "to play again");
    }
    */
}