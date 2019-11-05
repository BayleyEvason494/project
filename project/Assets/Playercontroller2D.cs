﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playercontroller2D : MonoBehaviour {
    Animator animator;
    Rigidbody2D rb2d;
    SpriteRenderer spriteRenderer;

    // Start is called before the first frame update
    void Start() {

        animator = GetComponent<Animator>();
        rb2d = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();

    }

    private void FixedUpdate()
    {
        if (Input.GetKey("d") || Input.GetKey("right"))
        {
            rb2d.velocity = new Vector2(4, rb2d.velocity.y);
            animator.Play("player_run");
        }
        else if (Input.GetKey("a") || Input.GetKey("left"))
        {
            rb2d.velocity = new Vector2(-4, rb2d.velocity.y);
            animator.Play("player_run");
        }
        else
        {
            animator.Play("player_idle");
        }
        if (Input.GetKey("space"))
        {
            rb2d.velocity = new Vector2(rb2d.velocity.x, 5);
            animator.Play("player_jump");
        }
    }
}
