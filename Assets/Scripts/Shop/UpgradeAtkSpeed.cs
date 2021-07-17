using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpgradeAtkSpeed : ShopManager
{
    [SerializeField]
    private PlayerGold player;
    private PlayerStat stat;
    public GameObject stick;
    private int cost = 100;
    public UpgradeAtkSpeed()
    {
        this.upgrades = 0;
        this.max = 1;
    }

    //increases atkspeed in animator, change stats later
    public void AtkSpeedUp()
    {
        Debug.Log("Button pressed");
        if (player.showGold() < cost)
        {
            this.GetComponentInChildren<Text>().text = "NOT ENOUGH GOLD";
            return;
        }
        else
        {
            Animator anim = PlayerController.Instance.animator;
            Debug.Log(anim);
            anim.SetFloat("atkspd", anim.GetFloat("atkspd") + (float)0.5);
            player.minusGold(new Gold(cost));
            increaseCost();
            if (maxUpgrades(max))
            {
                Debug.Log("MAX UPGRADES MADE");
                this.GetComponentInChildren<Text>().text = "MAX UPGRADES";
            }
        }
    }
    public void increaseCost()
    {
        cost += 10;
        upgrades++;
    }

    //remove when implementing buttons
    /*     void Update()
        {
            AtkSpeedUp();
        } */
}