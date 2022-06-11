using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinState : MonoBehaviour
{
    public int platformNumber;

    void Start()
    {
        GameObject[] plat = GameObject.FindGameObjectsWithTag("Platform");
        platformNumber = plat.Length;
    }

    public void Win()
    {
        if (platformNumber <= 0)
        {
            Time.timeScale = 0;
            Debug.Log("Ganaste");
        }
    }

    public void Rest()
    {
        platformNumber--;
    }

}
