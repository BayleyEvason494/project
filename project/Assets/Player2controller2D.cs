using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2controller2D : MonoBehaviour
{

    Animator animator;
    Rigidbody2D rb2d;
    SpriteRenderer spriteRenderer;

    void Start()
    {

        animator = GetComponent<Animator>();
        rb2d = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    private void FixedUpdate()
    {
        if (Input.GetKey("right"))
        {
            rb2d.velocity = new Vector2(4, rb2d.velocity.y);
            animator.Play("Player_run");
            spriteRenderer.flipX = false;
        }
        else if (Input.GetKey("left"))
        {
            rb2d.velocity = new Vector2(-4, rb2d.velocity.y);
            animator.Play("Player_run");
            spriteRenderer.flipX = true;

        }
        if (Input.GetKey("up"))
        {
            rb2d.velocity = new Vector2(rb2d.velocity.x, 5);
            animator.Play("Player_jump");
        }
        if (Input.GetKey("q"))
        {
            animator.Play("Player_punch");
        }
        if (Input.GetKey("e"))
        {
            animator.Play("Player_kick");
        }

    }
}


