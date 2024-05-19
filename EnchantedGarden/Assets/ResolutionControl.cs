using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResolutionControl : MonoBehaviour
{
    [SerializeField] GameObject[] gos;

    private double height;
    private double width;
    void Start()
    {
        height = Screen.height;
        width = Screen.width;

        if (System.Math.Abs(width / height) < 2)
        {
            foreach (GameObject go in gos)
            {
                go.GetComponent<CanvasScaler>().matchWidthOrHeight = 0;
            }
        }
        else if (System.Math.Abs(width / height) > 2)
        {
            foreach (GameObject go in gos)
            {
                go.GetComponent<CanvasScaler>().matchWidthOrHeight = 1;
            }
        }
    }
}
