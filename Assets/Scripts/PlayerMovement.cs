using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 0.7f;

    public Rigidbody2D rb;
    public Animator animator;
    public SpriteRenderer sprite;


    string facing = "right";

    Vector2 movement;

    void Start()
    {

    }

    void Update()
    {
        MovementInput();
    }

    void FixedUpdate()
    {
        rb.velocity = movement * moveSpeed;
    }

    void MovementInput()
    {
        float mx = Input.GetAxisRaw("Vertical");
        float my = -1 * Input.GetAxisRaw("Horizontal");
        

        movement = new Vector2(mx, my).normalized;

        // changement de direction (flip du sprite)
        if (movement.y > 0)
        {
            sprite.flipX = true;
            facing = "left";
        }
        else if (movement.y < 0)
        {
            sprite.flipX = false;
            facing = "right";
        }

        // changement d'animation 
        if (movement.Equals(new Vector2(0,0)))
        {
            animator.SetBool("running", false);
        } else
        {
            animator.SetBool("running", true);
        }
       
    }

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("collision");
    }
}
