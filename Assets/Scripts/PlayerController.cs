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
    private float lastInput;
    private float velocity;
    [SerializeField]
    private float speed = 10.0f;
    public bool isAttacking = false;
    public bool isBlocking = false;
    public static PlayerController Instance;
    public bool facingRight = false;
    public GameObject left = null;
    public GameObject right = null;
    public float distance = 0;
    public float distancer = 0;

    private void Awake()
    {
        Instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        Attack();
        lastInput = moveInput;
        if (Input.touchCount > 0)
        {
            var touch = Input.GetTouch(0);
            if (touch.position.x < Screen.width / 2)
            {
                //Left click
                moveInput = -1;
            }
            else
            {
                //Right click
                moveInput = 1;
            }
            if (touch.position.y > Screen.height / 2)
            {
                //upper click
                isBlocking = true;
                isAttacking = false;
            }
            else
            {
                isBlocking = false;
            }
        }
        else
        {
            isBlocking = false;
            moveInput = 0;
        }
        if (!facingRight && moveInput > 0)
        {
            Flip();
            Reset();
        }
        else if (facingRight && moveInput < 0)
        {
            Flip();
            Reset();
        }
        if (!isAttacking && !isBlocking)
        {
            if (moveInput != 0)
            {
                animator.SetBool("isWalking", true);
            }
            else
            {
                animator.SetBool("isWalking", false);
            }

            velocity = speed * moveInput;
            rb.velocity = new Vector2(velocity, 0);
            animator.SetFloat("Velocity", velocity);
        }
        else
        {
            velocity = 0;
            rb.velocity = new Vector2(velocity, 0);
            animator.SetFloat("Velocity", velocity);
        }

        int layerMask = 1 << 9;
        right = null;
        left = null;
        distance = 0;
        distancer = 0;
        RaycastHit2D hitLeft = Physics2D.Raycast(transform.position - new Vector3(0.5f, 0, 0), Vector2.left, 5f, layerMask);
        if (hitLeft.collider != null)
        {
            left = hitLeft.collider.transform.parent.gameObject;
            distance = hitLeft.distance;
            Debug.DrawRay(transform.position, Vector2.left * hitLeft.distance, Color.red);
        }
        RaycastHit2D hitRight = Physics2D.Raycast(transform.position + new Vector3(0.5f, 0, 0), Vector2.right, 5f, layerMask);
        if (hitRight.collider != null)
        {
            right = hitRight.collider.transform.parent.gameObject;
            distancer = hitRight.distance;
            Debug.DrawRay(transform.position, Vector2.right * hitRight.distance, Color.blue);
        }
    }

    void Attack()
    {
        if (left && !facingRight && !isAttacking)
        {
            isAttacking = true;
        }
        else if (right && facingRight && !isAttacking)
        {
            isAttacking = true;
        }
    }

    void Flip()
    {
        // Switch the way the player is labelled as facing
        facingRight = !facingRight;

        // Multiply the player's x local scale by -1
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }

    public void Dash()
    {
        if (left && !facingRight && distance > .2f)
        {
            if (left != right)
            {
                this.transform.position = left.transform.position + new Vector3(0.5f, 0, 0);
                Debug.Log(left.transform.position);
            }
        }
        else if (right && facingRight && distancer > .2f)
        {
            if (left != right)
            {
                this.transform.position = right.transform.position - new Vector3(0.5f, 0, 0);
            }
        }
    }

    public void Reset()
    {
        animator.Play("Idle");
        isAttacking = false;
    }
}
