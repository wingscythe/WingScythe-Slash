using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Simple script that locks on to target and moves in range
public class SimplePathFinder : MonoBehaviour
{
    [Header("General")]
    public GameObject target;
    public Rigidbody2D rb;
    public Animator anim;
    public float range = 0.5f;
    public float speed = 1.2f;

    [Header("Utility")]
    public bool inRange = false;
    public bool facingRight = false;
    public bool isWalking = false;

    // Start is called before the first frame update
    void Start()
    {
        if (!target)
        {
            Destroy(this);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (!facingRight && transform.position.x < target.transform.position.x)
        {
            Flip();
        }
        else if (facingRight && transform.position.x > target.transform.position.x)
        {
            Flip();
        }
        float distance = Vector3.Distance(target.transform.position, transform.position);
        if (distance > range)
        {
            if (facingRight)
            {
                rb.velocity = speed * new Vector3(1, 0, 0);
            }
            else
            {
                rb.velocity = speed * new Vector3(-1, 0, 0);
            }
            inRange = false;
            isWalking = true;
            anim.SetBool("isWalking", true);
        }
        else
        {
            rb.velocity = Vector2.zero;
            inRange = true;
            isWalking = false;
            anim.SetBool("isWalking", false);
        }
    }

    void Flip()
    {
        facingRight = !facingRight;

        // Multiply the player's x local scale by -1
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }
}
