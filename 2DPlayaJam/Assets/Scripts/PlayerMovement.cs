using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [HideInInspector] public Rigidbody2D rb2D;
    [SerializeField] int movementSpeed;
    float xMov;

    [SerializeField] int jumpForce;
    [SerializeField] int gravityScale;
    bool onGround;

    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        rb2D.velocity = new Vector2(xMov * movementSpeed * Time.fixedDeltaTime * 10, rb2D.velocity.y);

        Gravity();
    }

    void Gravity()
    {
        rb2D.AddForce(-transform.up * gravityScale);
    }

    void Update()
    {
        xMov = Input.GetAxis("Horizontal");

        Jump();
    }

    void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.W))
        {
            if (onGround)
            {
                rb2D.velocity = new Vector2(rb2D.velocity.x, jumpForce);
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        onGround = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        onGround = false;
    }

}
