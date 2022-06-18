using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinState : MonoBehaviour
{
    public int platformNumber;
    AudioSource audioData;
    public Color color;

    void Start()
    {
        Time.timeScale = 1;
        GameObject[] plat = GameObject.FindGameObjectsWithTag("Platform");
        platformNumber = plat.Length;

        audioData = GetComponent<AudioSource>();
    }

    public void CkeckVictory()
    {
        platformNumber--;

        if (platformNumber <= 0)
        {
            //Time.timeScale = 0;
            Debug.Log("Ganaste");
            return;
        }
        audioData.Play();
    }

}
