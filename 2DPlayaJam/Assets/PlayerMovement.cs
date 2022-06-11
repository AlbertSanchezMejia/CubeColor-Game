using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [HideInInspector] public Rigidbody2D rb2D;
    [SerializeField] int movementSpeed;
    Vector3 xMov;
    Vector3 yMov;

    [SerializeField] int jumpForce;
    [SerializeField] int gravityScale;
    bool onGround;

    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        rb2D.velocity = (xMov * movementSpeed * Time.fixedDeltaTime * 10) + yMov;
        Gravity();
    }

    void Gravity()
    {
        rb2D.AddForce(transform.up * gravityScale);
    }

    void Update()
    {
        xMov = transform.right * Input.GetAxis("Horizontal");
        yMov = transform.up * rb2D.velocity.y;

        Jump();
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

    private void OnTriggerEnter2D(Collider2D collision)
    {
        onGround = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        onGround = false;
    }

}
