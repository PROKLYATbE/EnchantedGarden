using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLvlScene : MonoBehaviour
{
    [SerializeField] string[] lvlNames;

    public void loadRandomLvl()
    {
        System.Random random = new System.Random();
        SceneManager.LoadScene(lvlNames[random.Next(0, lvlNames.Length)]);
    }
}
