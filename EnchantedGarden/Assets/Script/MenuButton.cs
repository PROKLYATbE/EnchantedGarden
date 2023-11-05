using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButton : MonoBehaviour
{
    public GameObject settingsMenu;

    void Start() {
        
    }
    void Update() {
        
    }
    public void QuitGame() {
        Debug.Log("Выход");
        Application.Quit();
    }
    public void StartGame() {
        Debug.Log("Начало игры");
        SceneManager.LoadScene("SampleScene");
    }
}
