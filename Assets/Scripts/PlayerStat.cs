using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStat : MonoBehaviour {
    public int maxHealth = 10;
    public int currentHealth { get; private set; }
    public Stat Strength;
    public Stat Speed;
    public Stat AtkSpeed;
    public Stat Health;

    void Awake() {
        currentHealth = maxHealth;
    }

    void Start() {
        //Get saved PlayerStat if relevant
        if (Save.Instance.getStats("Strength") != null) {
            Strength = Save.Instance.getStats("Strength");
        }
        if (Save.Instance.getStats("Speed") != null) {
            Speed = Save.Instance.getStats("Speed");
        }
        if (Save.Instance.getStats("AtkSpeed") != null) {
            AtkSpeed = Save.Instance.getStats("AtkSpeed");
        }
        if (Save.Instance.getStats("Health") != null) {
            Health = Save.Instance.getStats("Health");
        }
    }

    public void TakeDamage(int damage) {
        currentHealth -= damage;
        if (currentHealth <= 0) {
            // death
        }
    }

    public int getSpeed() {
        return Speed.getValue();
    }
    public int getHealth() {
        return currentHealth;
    }
    public double getAtkSpeed() {
        return this.GetComponent<Animator>().GetFloat("atkspd");
    }
    public int getStrength() {
        return Strength.getValue();
    }
    //setting/changing stats
    public int setSpeed(int _speed) {
        return Speed.SetValue(_speed);
    }
    public int setHealth(int _health) {
        return Health.SetValue(_health);
    }
    public double setAtkSpeed(int _atkspeed) {
        return AtkSpeed.SetValue(_atkspeed);
    }
    public int setStrength(int _strength) {
        return Strength.SetValue(_strength);

    }
}
