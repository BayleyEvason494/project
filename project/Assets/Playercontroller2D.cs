using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playercontroller2D : MonoBehaviour
{
    Animator animator;
    Rigidbody2D rb2d;
    SpriteRenderer spriteRenderer;

    bool isGrounded;

    [SerializeField]
    Transform groundCheck;
    void Start()
    {

    animator = GetComponent<Animator>();
    rb2d = GetComponent<Rigidbody2D>();
    spriteRenderer = GetComponent<SpriteRenderer>();

    }
    private void FixedUpdate()
    {
        if (Physics2D.Linecast(transform.position, groundCheck.position, 1 << LayerMask.NameToLayer("Ground")))
        {
        isGrounded = true;
        }
        else
        {
        isGrounded = false;
        }
        if (Input.GetKey("d"))
        {
        rb2d.velocity = new Vector2(8, rb2d.velocity.y);
        if (isGrounded)
        animator.Play("Player_run");
        spriteRenderer.flipX = false;
        }
        else if (Input.GetKey("a"))
        {
        rb2d.velocity = new Vector2(-8, rb2d.velocity.y);
        if (isGrounded)
        animator.Play("Player_run");
        spriteRenderer.flipX = true;
        }
        else
        {
        if (isGrounded)
        animator.Play("Player_idle");
        }
        if (Input.GetKey("w") && isGrounded)
        {
        rb2d.velocity = new Vector2(rb2d.velocity.x, 6);
        animator.Play("Player_jump");
        }
        if (Input.GetKey("q"))
        {
        if (isGrounded)
        animator.Play("Player_punch");
        }
        if (Input.GetKey("e"))
        {
        if (isGrounded)
        animator.Play("Player_kick");
        }

    }
}  
