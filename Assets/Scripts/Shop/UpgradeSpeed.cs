using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeSpeed : ShopManager
{
    private PlayerGold player;
    private PlayerStat stat;
    private int cost;

    void SpeedUp()
    {
        if (player.showGold() < cost)
        {
            return;
        }
        else
        {
            stat.Speed.SetValue(stat.Speed.getValue() + 1);
            increaseCost(50);
        }
    }
}