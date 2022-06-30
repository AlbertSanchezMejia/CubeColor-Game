using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D rb2D;
    [SerializeField] int movementSpeed = 30;
    float xMov;

    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        rb2D.velocity = new Vector2(xMov * movementSpeed * Time.fixedDeltaTime * 10, rb2D.velocity.y);
    }

    void Update()
    {
        xMov = Input.GetAxis("Horizontal");
    }

}
