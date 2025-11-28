using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour
{
    public float speed = 5.0f;
    private float horizontalInput; // Stores horizontal input

    private Rigidbody2D rb;
    private Animator animator;

    private bool isFacingRight = true;

    // This enum matches your Animator Controller in the image
    enum PlayerStates
    {
        Idle = 0,
        Run = 1
        // You can add Jump, Death, etc. here later
    }

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame - used for Input
    void Update()
    {
        // Get input in Update()
        horizontalInput = Input.GetAxisRaw("Horizontal");

        // --- Handle Animation ---
        if (horizontalInput != 0)
        {
            // Set the "Act" parameter to 1 (which is 'Run' in your Animator)
            animator.SetInteger("Act", (int)PlayerStates.Run);
        }
        else
        {
            // Set the "Act" parameter to 0 (which should be 'Idle')
            animator.SetInteger("Act", (int)PlayerStates.Idle);
        }

        // --- Handle Sprite Flipping ---
        if (horizontalInput > 0 && !isFacingRight)
        {
            Flip();
        }
        else if (horizontalInput < 0 && isFacingRight)
        {
            Flip();
        }
    }

    // FixedUpdate is called at a fixed interval - used for Physics
    private void FixedUpdate()
    {
        // Apply physics movement in FixedUpdate()
        // We set the x velocity, but keep the y velocity (for gravity)
        rb.velocity = new Vector2(horizontalInput * speed, rb.velocity.y);
    }

    // Flips the character sprite
    private void Flip()
    {
        isFacingRight = !isFacingRight;
        Vector3 localScale = transform.localScale;
        localScale.x *= -1f;
        transform.localScale = localScale;
    }
}
