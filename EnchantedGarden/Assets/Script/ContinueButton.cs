using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContinueButton : MonoBehaviour
{
    public GameObject settingsMenu;
    public GameObject escButton;
    public GameObject hintButton;

    public void Continue()
    {
        settingsMenu.SetActive(false);
        escButton.SetActive(true);
        hintButton.SetActive(true);
    }
}
