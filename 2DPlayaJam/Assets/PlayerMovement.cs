using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] int movementSpeed;
    Rigidbody2D rb2D;
    Vector3 xMov;
    Vector3 yMov;

    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        rb2D.velocity = (xMov * movementSpeed * Time.fixedDeltaTime * 10) + yMov;
    }

    void Update()
    {
        xMov = transform.right * Input.GetAxis("Horizontal");
        yMov = transform.up * rb2D.velocity.y;
    }

}
