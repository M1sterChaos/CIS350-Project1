/*
 * Austin Buck, Zach Daly
 * Project 1
 * Controls player movement
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehavior : PhysicsObject {

    public float maxSpeed = 7;
    public float jumpTakeOffSpeed = 12;

    public static bool playerFlipX = false;

    private SpriteRenderer spriteRenderer;
    private Animator animator;

    public static bool allowJump = true;
    public static bool allowMove = true;

    // Use this for initialization
    void Awake () 
    {
        spriteRenderer = GetComponent<SpriteRenderer> (); 
        animator = GetComponent<Animator> ();
    }

    protected override void ComputeVelocity()
    {
        if (Input.GetKeyDown(KeyCode.W) && grounded && allowJump) {
            velocity.y = jumpTakeOffSpeed;
        }

        if(!allowMove) return; 

        Vector2 move = Vector2.zero;

        move.x = Input.GetAxis ("Horizontal");

        if(move.x > 0.01f)
        {
            if(spriteRenderer.flipX == true)
            {
                spriteRenderer.flipX = false;
                playerFlipX = false;
            }
        } 
        else if (move.x < -0.01f)
        {
            if(spriteRenderer.flipX == false)
            {
                spriteRenderer.flipX = true;
                playerFlipX = true;
            }
        }

        animator.SetBool ("grounded", grounded);
        animator.SetFloat ("velocityX", Mathf.Abs (velocity.x) / maxSpeed);
        animator.SetFloat ("velocityY", velocity.y);

        targetVelocity = move * maxSpeed;
    }

    void Update(){
        base.Update();
        animator.SetBool ("gameover", LoseOnFall.gameOver);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        grounded = true;
    }
}