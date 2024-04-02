using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenShop : MonoBehaviour
{
    [SerializeField] GameObject shop;
    public void openShop()
    {
        shop.SetActive(true);
    }
    public void closeShop()
    {
        shop.SetActive(false);
    }
}
