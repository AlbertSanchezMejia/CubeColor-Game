using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformDesactivate : MonoBehaviour
{
    void OnCollisionExit2D(Collision2D collision)
    {
        gameObject.SetActive(false);
        FindObjectOfType<WinState>().CkeckVictory();
    }

}
