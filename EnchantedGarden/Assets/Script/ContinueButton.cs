using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContinueButton : MonoBehaviour
{
    public GameObject settingsMenu;
    public GameObject escButton;

    public void Continue()
    {
        settingsMenu.SetActive(false);
        escButton.SetActive(true);
        Time.timeScale = 1f;
    }
}
