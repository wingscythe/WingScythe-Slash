using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStat : MonoBehaviour
{
    public int maxHealth = 10;
    public int currentHealth { get; private set; }
    public Stat Strength;
    public Stat Speed;
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

    public int getSpeed()
    {
        return Speed.getValue();
    }
    public int getHealth()
    {
        return Health.getValue();
    }
    public int getAtkSpeed()
    {
        return AtkSpeed.getValue();
    }
    public int getStrength()
    {
        return Strength.getValue();

    }
    //setting/changing stats
    public int setSpeed(int _speed)
    {
        return Speed.SetValue(_speed);
    }
    public int setHealth(int _health)
    {
        return Health.SetValue(_health);
    }
    public int setAtkSpeed(int _atkspeed)
    {
        return AtkSpeed.SetValue(_atkspeed);
    }
    public int setStrength(int _strength)
    {
        return Strength.SetValue(_strength);

    }
}
