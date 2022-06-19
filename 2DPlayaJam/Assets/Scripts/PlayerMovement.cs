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
    [SerializeField] Transform groundCheck;
    [SerializeField] LayerMask layerGround;


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

    bool OnGround()
    {
        return Physics2D.OverlapCircle(groundCheck.position, 0.25f, layerGround);
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
    }




}
