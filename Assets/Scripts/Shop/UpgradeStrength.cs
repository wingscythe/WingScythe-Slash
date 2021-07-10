using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeStrength : ShopManager
{
    private PlayerGold player;
    private PlayerStat stat;
    private int cost = 200;

    void StrengthUp()
    {
        if (player.showGold() < cost)
        {
            return;
        }
        else
        {
            stat.Strength.SetValue(stat.Strength.getValue() + 20);
            player.minusGold(new Gold(cost));
            increaseCost();
        }
    }
    public void increaseCost()
    {
        cost += 200;
    }
}