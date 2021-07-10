using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeHealth : ShopManager
{
    private PlayerGold player;
    private PlayerStat stat;
    private int cost = 250;

    void HealthUp()
    {
        if (player.showGold() < cost)
        {
            return;
        }
        else
        {
            stat.Health.SetValue(stat.Health.getValue() + 50);
            player.minusGold(new Gold(cost));
            increaseCost();
        }
    }

    public void increaseCost()
    {
        cost += 100;
    }
}