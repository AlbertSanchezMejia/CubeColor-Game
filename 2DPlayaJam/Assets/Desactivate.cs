using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Desactivate : MonoBehaviour
{

    private void OnCollisionExit2D(Collision2D collision)
    {
        gameObject.SetActive(false);
    }

}
