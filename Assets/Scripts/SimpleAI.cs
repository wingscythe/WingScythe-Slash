using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleAI : MonoBehaviour
{
    [Header("General")]
    public SimplePathFinder pathFinder;
    public Animator animator;

    [Header("Utility")]
    public bool isAttacking = false;

    // Start is called before the first frame update
    void Start()
    {
        pathFinder = GetComponent<SimplePathFinder>();
        if (!pathFinder || !pathFinder.target)
        {
            Destroy(this);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (pathFinder.inRange)
        {
            //Start Attack
            isAttacking = true;
            animator.SetBool("isAttacking", true);
        }
        else
        {
            isAttacking = false;
            animator.SetBool("isAttacking", false);
        }
    }
}
