using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{

    [Header("General")]
    public float health = 1;
    public Gold gold;
    public Animator animator; 

    void Start(){
        gold = GetComponent<Gold>();
        animator = GetComponentInChildren<Animator>();  
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void headHit(float damage){
        Debug.Log("HeadHit");
        //Play head hit animation
        animator.Play("headhit");

        //Decrease health
        takeDamage(damage);
    }

    public void legHit(float damage){
        Debug.Log("LegHit");
        //Play head hit animation
        
        //Decrease health
        takeDamage(damage);
    }

    public void bodyHit(float damage){
        Debug.Log("BodyHit");
        //Play head hit animation
        
        //Decrease health
        takeDamage(damage);
    }

    public void takeDamage(float damage){
        health-=damage;
        //check if dead

        if(health <= 0){
            Debug.Log("Enemy Killed");

            //Reset player combo
            PlayerController.Instance.Reset();

            //Remove collider
            
            //Play death animation, then delete gameObject

            //Burst into coins

            //Add coins to player
            PlayerGold.Instance.addGold(gold);

            //Edit this with death animation length
            Destroy(gameObject);
        }
    }
}
