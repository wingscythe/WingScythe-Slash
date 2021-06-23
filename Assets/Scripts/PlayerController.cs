using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("General")]
    public Animator animator;
    [SerializeField]
    private Rigidbody2D rb;
    private float moveInput;
    private float velocity;
    [SerializeField]
    private float speed = 1.0f;
    public bool isAttacking = false;
    public static PlayerController Instance;
    public bool facingRight = false;

    private void Awake(){
        Instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        Attack();
        moveInput = Input.GetAxis("Horizontal");
        if (moveInput != 0) {
            animator.SetBool("isWalking", true);
        } else {
            animator.SetBool("isWalking", false);
        }
        if (!facingRight && moveInput > 0) {
            Flip();
        } else if (facingRight && moveInput < 0) {
            Flip();
        }
        velocity = speed * moveInput;
        rb.velocity = new Vector2(velocity,0);
        animator.SetFloat("Velocity", velocity);
    }

    void Attack(){
        if(Input.GetKeyDown(KeyCode.X) && !isAttacking){
            isAttacking = true;
        }
    }

    void Flip(){
        // Switch the way the player is labelled as facing
        facingRight = !facingRight;

        // Multiply the player's x local scale by -1
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }
}
