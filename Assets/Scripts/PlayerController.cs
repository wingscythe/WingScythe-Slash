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
    private float speed = 1.0f;
    public bool isAttacking = false;
    public static PlayerController Instance;
    public bool facingRight = false;
    public GameObject left = null;
    public GameObject right = null;
    public float distance = 0;

    //Attacks
    public int attack = 0;

    private void Awake(){
        Instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        Attack();
        lastInput = moveInput;
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
        rb.velocity = new Vector2(speed*velocity,0);
        animator.SetFloat("Velocity", velocity);
        
        int layerMask = 1 << 9;
        right = null;
        left = null;
        distance = 0;
        RaycastHit2D hitLeft = Physics2D.Raycast(transform.position, Vector2.left, 5f, layerMask);
        if (hitLeft.collider != null)
        {
            left = hitLeft.collider.transform.parent.gameObject;
            distance = hitLeft.distance;
            Debug.DrawRay(transform.position, Vector2.left * hitLeft.distance, Color.red);
        }
        RaycastHit2D hitRight = Physics2D.Raycast(transform.position, Vector2.right, 5f, layerMask);
        if (hitRight.collider != null)
        {
            right = hitRight.collider.transform.parent.gameObject;
            Debug.DrawRay(transform.position, Vector2.right * hitRight.distance, Color.blue);
        }
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

    public void Dash(){
        if(left && !facingRight && distance > .2f){
            this.transform.Translate(Vector3.left * distance);  
        }
    }
}
