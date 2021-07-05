using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeHealth : ShopManager
{
    private PlayerGold player;
    private PlayerStat stat;
    private int cost;

    void HealthUp()
    {
        if (player.showGold() < cost)
        {
            return;
        }
        else
        {
            stat.Health.SetValue(stat.Health.getValue() + 5);
            increaseCost(50);
        }
    }
}