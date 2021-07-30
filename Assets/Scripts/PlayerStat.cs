using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStat : MonoBehaviour {
    public Stat Strength;
    public Stat Speed;
    public Stat AtkSpeed; //TODO: change attack speed to divide by 10 to make it a float
    public Stat Health;
    public Stat MaxHealth;

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
        if (Save.Instance.getStats("MaxHealth") != null) {
            MaxHealth = Save.Instance.getStats("MaxHealth");
        }
    }

    public int getSpeed() {
        return Speed.getValue();
    }
    public int getHealth() {
        return Health.getValue();
    }

    public int getMaxHealth() {
        return MaxHealth.getValue();
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
    public int setMaxHealth(int _health) {
        return MaxHealth.SetValue(_health);
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

    public void takeDamage(int damage) {
        int health = getHealth() - damage;
        setHealth(health);
        //check if dead

        if (health <= 0) {
            Debug.Log("Player Killed");

            //TODO: Death logic

            //Edit this with death animation length
            Destroy(gameObject);
        }
    }
}
