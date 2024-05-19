using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class TimerManagerScript : MonoBehaviour
{
    public int timerStartNumber;
    public TMP_Text timerText;
    public int timerCount;
    public Canvas timerCanvas;
    public string TimerEndMessage;

    // TODO remove after Debug
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            StartTimer();
    }

    public void StartTimer()
    {
        timerCount = timerStartNumber;
        timerCanvas.gameObject.SetActive(true);
        Time.timeScale = 0;

        StartCoroutine(routine: TimerCorutine());
    }

    private IEnumerator TimerCorutine()
    {
        if (timerCount > 0)

            timerText.text = timerCount.ToString();
        else
            timerText.text = TimerEndMessage;

        yield return new WaitForSeconds(1f);
        timerCount--;

        if (timerCount >= 0)
            StartCoroutine(routine: TimerCorutine());
        else
        {
            Debug.Log(message: "Timer finished");
            timerCanvas.gameObject.SetActive(false);
            Time.timeScale = 1;
        }

    }

}
