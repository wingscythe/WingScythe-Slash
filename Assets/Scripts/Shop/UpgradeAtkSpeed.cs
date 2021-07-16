using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpgradeAtkSpeed : ShopManager
{
    [SerializeField]
    private PlayerGold player;
    private PlayerStat stat;
    private int cost = 100;
    public Button button;
    public Animator anim;
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
            Debug.Log("NOT ENOUGH GOLD" + "number of upgrades " + upgrades);
            return;
        }
        else if (maxUpgrades(max))
        {
            Debug.Log("MAX UPGRADES MADE");
            button.GetComponentInChildren<Text>().text = "MAX UPGRADES";
        }
        else
        {
            anim.SetFloat("atkspd", anim.GetFloat("atkspd") + (float)0.5);
            player.minusGold(new Gold(cost));
            increaseCost(10);
        }
    }
    public void increaseCost()
    {
        cost += 50;
    }

    //remove when implementing buttons
    /*     void Update()
        {
            AtkSpeedUp();
        } */
}