using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStat : MonoBehaviour
{
    public int maxHealth = 10;
    public int currentHealth { get; private set; }
    public Stat Strength;
    public Stat speed;
    public Stat AtkSpeed;
    public Stat Health;
    void Awake()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        if (currentHealth <= 0)
        {
            // death
        }
    }
    //setting/changing stats
    public void setSpeed(int _speed)
    {
        speed.SetValue(_speed);   
    }

    public void setHealth(int _health)
    {
        Health.SetValue(_health);
    }

    public void setAtkSpeed(int _atkspeed)
    {
        AtkSpeed.SetValue(_atkspeed);
    }

    public void setStrength(int _strength)
    {
        Strength.SetValue(_strength);
    }
}
