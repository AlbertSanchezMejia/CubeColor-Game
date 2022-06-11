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
    [SerializeField] float rayLength;
    bool onGround;
    public LayerMask groundLayer;

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
            bool onGround1 = Physics2D.Raycast(transform.position + (Vector3.right * 0.35f), Vector2.down, rayLength, groundLayer);
            bool onGround2 = Physics2D.Raycast(transform.position + (Vector3.right * -0.35f), Vector2.down, rayLength, groundLayer);

            if (onGround1 || onGround2)
            {
                rb2D.AddForce(transform.up * jumpForce * 100);
            }
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawLine(transform.position, transform.position + (Vector3.down * rayLength) + (Vector3.right * 0.35f));
        Gizmos.DrawLine(transform.position, transform.position + (Vector3.down * rayLength) + (Vector3.right * -0.35f));
    }

}
