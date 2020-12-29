using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Animator animator;
    Rigidbody2D rb;
    SpriteRenderer sprite;

    [SerializeField]
    int speed;
    [SerializeField]
    int jumpForce;


    private void Start()
    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        sprite = GetComponent<SpriteRenderer>();
    }

    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.D))
        {
            rb.velocity = new Vector2(speed, rb.velocity.y);
            animator.Play("Player_Run");
            sprite.flipX = false;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            rb.velocity = new Vector2(-speed, rb.velocity.y);
            animator.Play("Player_Run");
            sprite.flipX = true;
        }
        else
        {
            rb.velocity = new Vector2(0, rb.velocity.y);
            animator.Play("Player_Idle");
        }

        if (Input.GetKey(KeyCode.W))
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
            animator.Play("Player_Jump");
        }
    }
}
