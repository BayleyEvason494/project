using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2controller2D : MonoBehaviour
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

        bool ihavepressedkey = false;

        if (Input.GetKey("up") && isGrounded)
        {
            ihavepressedkey = true;
            rb2d.velocity = new Vector2(rb2d.velocity.x,6);
            animator.Play("Player2_jump");
        }
        if (Input.GetKey("k"))
        {
            ihavepressedkey = true;
            if (isGrounded)
                animator.Play("Player2_punch");
        }
        if (Input.GetKey("l"))
        {
            ihavepressedkey = true;
            if (isGrounded)
                animator.Play("Player2_kick");
        }


        if (Input.GetKey("right"))
        {
            ihavepressedkey = true;
            rb2d.velocity = new Vector2(8, rb2d.velocity.y);
            if (isGrounded)
                animator.Play("Player2_run");
            spriteRenderer.flipX = false;
        }
        else if (Input.GetKey("left"))
        {
            ihavepressedkey = true;
            rb2d.velocity = new Vector2(-8, rb2d.velocity.y);
            if (isGrounded)
                animator.Play("Player2_run");
            spriteRenderer.flipX = true;

        }
        if (ihavepressedkey == false)
        {
            if (isGrounded)
                animator.Play("Player2_idle");
        }

    }
}


