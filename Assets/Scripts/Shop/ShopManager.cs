using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopManager : MonoBehaviour {
    protected int max;
    protected int upgrades;

    public bool maxUpgrades(int max) {
        if (upgrades == max) return true;
        else return false;
    }

}