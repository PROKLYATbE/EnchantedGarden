using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EscMenuButton : MonoBehaviour
{
    public GameObject settingsMenu;
    public GameObject escButton;
    /*
    public void Pause()
    {
        if (Time.timeScale == 1f)
            Time.timeScale = 0f;
        else
            Time.timeScale = 1f;
    }
    */
    public void OpenEscMenu()
    {
        settingsMenu.SetActive(true);
        escButton.SetActive(false);
    }
}
