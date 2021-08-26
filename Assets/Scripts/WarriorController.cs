using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarriorController : MonoBehaviour
{
    // Start is called before the first frame update
    public float checkRadius;
    public LayerMask player;
    public GameObject playerCheck;
    Rigidbody2D rb;
    Animator anim;
    public float speed;

    bool isContactWithPlayer;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        isContactWithPlayer=false;
        checkRadius = 0;
    }

    // Update is called once per frame
    void Update()
    {
        isContactWithPlayer=Physics2D.OverlapCircle(playerCheck.transform.position, checkRadius, player)
        
    }

}
