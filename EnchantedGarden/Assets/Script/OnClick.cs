using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnClick : MonoBehaviour
{
    [SerializeField] public GameObject obj_name;
    public static string obj_txt;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    
    void OnMouseDown() {
        obj_txt = gameObject.name;
        Destroy (gameObject);
        Destroy (obj_name);
    }
}
