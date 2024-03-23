using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetAllState : MonoBehaviour
{
   public void ResetState()
    {
        //PlayerPrefs.SetInt("Coins", 0);
        PlayerPrefs.DeleteAll();
    }
}
