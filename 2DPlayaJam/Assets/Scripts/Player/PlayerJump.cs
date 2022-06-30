using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    Rigidbody2D rb2D;
    [SerializeField] float jumpForce = 11f;
    [SerializeField] float gravityValue = 2.5f;
    [SerializeField] LayerMask layerGround;
    Transform groundCheck;

    void Start()
    {
        groundCheck = transform.GetChild(0);
        rb2D = GetComponent<Rigidbody2D>();
        rb2D.gravityScale = gravityValue;
    }

    void Update()
    {
        Jump();
    }

    bool OnGround()
    {
        return Physics2D.OverlapCircle(groundCheck.position, 0.34f, layerGround);
    }
    void Jump()
    {
        if (Input.GetButtonDown("Jump")) //Teclas Space, W o Flecha arriba.
        {
            if (OnGround())
            {
                rb2D.velocity = new Vector2(rb2D.velocity.x, jumpForce);
            }
        }
        if (Input.GetButtonUp("Jump") && rb2D.velocity.y > 0) //Teclas Space, W o Flecha arriba.
        {
            rb2D.velocity = new Vector2(rb2D.velocity.x, rb2D.velocity.y * 0.5f);
        }
    }

}
