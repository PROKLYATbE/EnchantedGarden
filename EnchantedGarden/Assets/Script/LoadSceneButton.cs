using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneButton : MonoBehaviour
{
    [Header("����� ����������� �����")]
    public int sceneNumber;

    public void LoadScene()
    {
        Debug.Log("Load new scene");
        SceneManager.LoadScene(sceneNumber);
    }
}
