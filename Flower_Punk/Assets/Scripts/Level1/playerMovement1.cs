using System.Collections;
using System.Collections.Generic;
using UnityEditor.XR;
using UnityEngine;

public class playerMovement1 : MonoBehaviour
{

    private float moveSpeed = 10f;
    private float jumpForce = 7f;

    public Transform groundCheck;
    public float groundCheckRadius;
    public LayerMask groundLayer;
    public bool isGrounded;

    private float Direction =  0f;

    private Rigidbody2D rb;

    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
    }

    
    void Update()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position,groundCheckRadius, groundLayer );

        Direction = Input.GetAxis("Horizontal");
        Debug.Log(Direction);

        if(Direction>0f)
        {
            rb.velocity = new Vector2(Direction * moveSpeed, rb.velocity.y);
            transform.localScale = new Vector2(1,1);
        }
        else if(Direction<0f) {
            rb.velocity = new Vector2(Direction * moveSpeed, rb.velocity.y);
            transform.localScale = new Vector2(-1, 1);
        }
        else
        {
            rb.velocity = new Vector2(0, rb.velocity.y);
        }
        

        if(Input.GetButtonDown("Jump") && isGrounded)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        }
    }
}
