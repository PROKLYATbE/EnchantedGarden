using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnClick : MonoBehaviour
{
    public GameObject obj_name;
    public static string obj_txt;

    void OnMouseDown() {
        obj_txt = gameObject.name;
        gameObject.SetActive(false);
        obj_name.SetActive(false);
    }
}
