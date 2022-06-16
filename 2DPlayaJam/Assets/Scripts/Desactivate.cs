using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Desactivate : MonoBehaviour
{
    public WinState win;

    private void OnCollisionExit2D(Collision2D collision)
    {
        FindObjectOfType<WinState>().CkeckVictory();
        gameObject.SetActive(false);
    }

}
