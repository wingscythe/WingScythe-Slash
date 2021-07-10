using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeAtkSpeed : ShopManager
{
    [SerializeField]
    private PlayerGold player;
    private PlayerStat stat;
    private int cost = 200;

    void AtkSpeedUp()
    {
        if (player.showGold() < cost)
        {
            return;
        }
        else
        {
            Animator anim = GetComponent<Animator>();
            anim.SetFloat("atkspd", anim.GetFloat("atkspd") + (float)0.5);
            player.minusGold(new Gold(cost));
            increaseCost();
        }
    }
    public void increaseCost()
    {
        cost += 50;
    }
    void Update()
    {
        AtkSpeedUp();
    }
}