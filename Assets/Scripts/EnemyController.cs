using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{

    [Header("General")]
    public float health = 1;


    // Update is called once per frame
    void Update()
    {
        
    }

    void headHit(float damage){
        //Play head hit animation
        
        //Decrease health
        takeDamage(damage);
    }

    void takeDamage(float damage){
        health-=damage;
        //check if dead

    }
}
