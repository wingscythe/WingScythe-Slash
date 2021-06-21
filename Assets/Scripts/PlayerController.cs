using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rb;

    [Header("General")]
    [SerializeField]
    private Animator animator;
    private float moveInput;
    private float velocity;
    [SerializeField]
    private float speed = 1.0f;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        moveInput = Input.GetAxis("Horizontal");
        if (moveInput != 0) {
            animator.SetBool("isWalking", true);
        } else {
            animator.SetBool("isWalking", false);
        }
        velocity = speed * moveInput;
        rb.velocity = new Vector2(velocity,0);
        animator.SetFloat("Velocity", velocity);
    }
}
