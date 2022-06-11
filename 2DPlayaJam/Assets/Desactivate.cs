using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Desactivate : MonoBehaviour
{
    public WinState win;

    private void OnCollisionExit2D(Collision2D collision)
    {
        win.Rest();
        gameObject.SetActive(false);
        win.Win();
    }

}
