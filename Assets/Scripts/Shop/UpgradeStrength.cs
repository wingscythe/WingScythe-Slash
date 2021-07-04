using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeStrength : ShopManager
{
    private PlayerGold player;
    private PlayerStat stat;
    private int cost;

    void StrengthUp()
    {
        if (player.showGold() < cost)
        {
            return;
        }
        else
        {
            stat.Strength.SetValue(stat.Strength.getValue() + 10);
            increaseCost(50);
        }
    }
}