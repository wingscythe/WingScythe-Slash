using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeAtkSpeed : ShopManager
{
    [SerializeField]
    private PlayerGold player;
    private PlayerStat stat;
    private int cost = 100;

    void AtkSpeedUp()
    {
        if (player.showGold() < cost)
        {
            return;
        }
        else
        {
            Animator anim = GetComponent<Animator>();
            anim.SetFloat("atkspd", anim.GetFloat("atkspd") + (float)0.1);
            player.minusGold(new Gold(cost));
            increaseCost(50);
        }
    }
    public override void increaseCost(int gold)
    {
        cost += gold;
    }
    void Update()
    {
        AtkSpeedUp();
    }
}