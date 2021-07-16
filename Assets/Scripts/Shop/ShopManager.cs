using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopManager : MonoBehaviour
{
    private int cost;
    protected int max;
    protected int upgrades;
    public void increaseCost(int gold)
    {
        cost += gold;
        upgrades++;
    }

    public bool maxUpgrades(int max)
    {
        if (upgrades == max) return true;
        else return false;
    }

}