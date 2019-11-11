using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playercontroller2D : MonoBehaviour
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
        if (Input.GetKey("d"))
        {
            rb2d.velocity = new Vector2(4, rb2d.velocity.y);
            animator.Play("player_run");
            spriteRenderer.flipX = false;
        }
        else if (Input.GetKey("a"))
        {
            rb2d.velocity = new Vector2(-4, rb2d.velocity.y);
            animator.Play("player_run");
            spriteRenderer.flipX = true;
        }
        if (Input.GetKey("w"))
        {
            rb2d.velocity = new Vector2(rb2d.velocity.x, 5);
            animator.Play("player_jump");
        }
        if (Input.GetKey("q"))
        {
            animator.Play("player_punch");
        }
        if (Input.GetKey("e"))
        {
            animator.Play("player_kick");
        }
        
    }
}  
