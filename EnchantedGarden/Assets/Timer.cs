// using System;
// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
// using UnityEngine.PlayerLoop;
// using UnityEngine.SceneManagement;
// using UnityEngine.UI;
// public class Timer : MonoBehaviour
// {
//     public float timeRemaining = 10;
//     public bool timerIsRunning = false;
//     public Text timeText;

//     public Text timeOver;

//     public string levelName;

//     private void Start()
//     {
//         // Starts the timer automatically
//         timerIsRunning = true;
//     }
//     void Update()
//     {
//         if (timerIsRunning)
//         {
//             if (timeRemaining > 0)
//             {
//                 timeRemaining -= Time.deltaTime;
//                 DisplayTime(timeRemaining);
//             }
//             else
//             {
//                 timeRemaining = 0;
//                 timerIsRunning = false;
//                 // DisplayTextTimeOver();
//             }

//         }
//         if (timerIsRunning == false && Input.GetKeyDown("g"))
//             SceneManager.LoadScene(levelName, LoadSceneMode.Single);
//     }
//     void DisplayTime(float timeToDisplay)
//     {
//         timeToDisplay += 1;
//         float minutes = Mathf.FloorToInt(timeToDisplay / 60);
//         float seconds = Mathf.FloorToInt(timeToDisplay % 60);
//         timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
//     }

//     void DisplayTextTimeOver()
//     {
//         timeOver.text = "Your time is over";
//     }

//     void OnGUI()
//     {
//         if (timerIsRunning == false)
//             GUI.Box(new Rect(0, 50, 250, 25), "GAME OVER. Press 'g' " +
//             "to play again");
//     }



// }



