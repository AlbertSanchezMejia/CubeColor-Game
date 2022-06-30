using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformChangeColor : MonoBehaviour
{
    WinState winState;
    bool hasChanged = false;

    void Start()
    {
        winState = FindObjectOfType<WinState>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (hasChanged == false)
        {
            GetComponent<SpriteRenderer>().color = winState.color;
            hasChanged = true;
            winState.CkeckVictory();
        }
    }

}
