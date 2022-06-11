using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    Rigidbody2D rb2D;
    [SerializeField] int jumpForce;
    [SerializeField] int gravityScale;
    [SerializeField] float rayLength;

    [SerializeField] bool onGround;

    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Jump();
        onGround = Physics2D.Raycast(transform.position - (transform.up * 0.6f), -transform.up, rayLength);
    }

    void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.W))
        {
            if (onGround)
            {
                rb2D.AddForce(transform.up * jumpForce * 100);
            }
        }
    }

    void Gravity()
    {
        rb2D.AddForce(-transform.up * gravityScale);
    }

    void FixedUpdate()
    {
        Gravity();
    }

}
