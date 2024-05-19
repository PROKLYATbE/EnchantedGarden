using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HintScript : MonoBehaviour
{
    [SerializeField] int numHints = 3;
    public static string parent_name = "Interactive_Item";
    [SerializeField] List<GameObject> objects;
    public static System.Random rand = new System.Random();

    void Update()
    {
        if (numHints <= 0)
            GetComponent<Button>().interactable = false;
    }


    public void EnableHint()
    {
        if (numHints <= 0)
            return;

        var obj = objects[rand.Next(0, objects.Count)];

        while (!obj.activeSelf)
            obj = objects[rand.Next(0, objects.Count)];

        obj.GetComponent<SpriteRenderer>().color = new Color(0, 255, 0);
        --numHints;
    }

}
