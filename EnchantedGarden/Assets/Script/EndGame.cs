using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour
{
    public GameObject[] iteractiveObjs;

    void FixedUpdate()
    {
        bool flag = true;
        foreach (var obj in iteractiveObjs)
        {
            if (obj.activeSelf)
            {
                flag = false;
                break;
            }
        }
        if (flag)
        {
            SceneManager.LoadScene("WinScene");
        }
    }
}
